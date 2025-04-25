using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using static System.Collections.Specialized.BitVector32;

namespace PI_PixelStudio
{
    public partial class VideoUserCtrl : UserControl
    {
        private VideoCapture _videoCapture;
        private System.Windows.Forms.Timer _frameTimer;
        private Mat _frame;
        private int[] hystogramR = new int[256];
        private int[] hystogramG = new int[256];
        private int[] hystogramB = new int[256];

        private bool play = false;

        private int activeFilter = 0;
        private int filterValue;

        private System.Windows.Forms.ProgressBar progressBar;
        private Label progressLabel;
        public VideoUserCtrl()
        {
            InitializeComponent();

            _frameTimer = new System.Windows.Forms.Timer();
            _frameTimer.Interval = 33;
            _frameTimer.Tick += FrameTimer_Tick;
            _frame = new Mat();

            List<Filters> filters = new List<Filters>
            {
                new Filters("None", Properties.Resources.None, 0),
                new Filters("Inverted", Properties.Resources.Inverted, 1),
                new Filters("Gray Scale", Properties.Resources.GrayScale, 2),
                new Filters("Negative", Properties.Resources.Negative, 3),
                new Filters("Contrast", Properties.Resources.Contrast, 4),
                new Filters("Heat Map", Properties.Resources.Heatmap, 5),
                new Filters("Posterize", Properties.Resources.Posterize1, 6),
                new Filters("Emboss", Properties.Resources.Emboss1, 7),
                new Filters("Comic", Properties.Resources.Dithering, 8),
                new Filters("Pixel", Properties.Resources.Pixel, 9),
                new Filters("Glitch", Properties.Resources.Glitch, 10),
                new Filters("Glitch 1", Properties.Resources.Glitch_1, 11),
                new Filters("Glitch 2", Properties.Resources.Glitch_2, 12),
                new Filters("Glitch 3", Properties.Resources.Glitch_3, 13)
            };
            LoadFilters(filters);
        }
        public void LoadFilters(List<Filters> filters)
        {
            FiltersFlowPanel.Controls.Clear();

            foreach (var filter in filters)
            {
                Panel filterPanel = NewFilterPanel(filter);
                FiltersFlowPanel.Controls.Add(filterPanel);
            }
        }
        private Panel NewFilterPanel(Filters filter)
        {
            Panel panel = new Panel
            {
                Size = new Size(128, 150),
                BackColor = Color.FromArgb(36, 41, 62),
                BorderStyle = BorderStyle.None,
                Name = "FilterPanel",
                Tag = filter
            };
            PictureBox pictureBox = new PictureBox
            {
                Size = new Size(110, 110),
                Image = filter.FilterImage,
                Name = "FIlterPicture",
                SizeMode = PictureBoxSizeMode.Zoom,
                Location = new Point(9, 9)
            };
            Label label = new Label
            {
                Text = filter.FilterName,
                TextAlign = ContentAlignment.MiddleCenter,
                Size = new Size(75, 17),
                AutoSize = true,
                Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0),
                ForeColor = Color.White,
                Name = "FilterName",
                Location = new Point(9, 125)
            };
            panel.Controls.Add(pictureBox);
            panel.Controls.Add(label);

            panel.Click += FilterPanel_Click;
            pictureBox.Click += FilterPanel_Click;
            label.Click += FilterPanel_Click;

            return panel;
        }
        private void FilterPanel_Click(object sender, EventArgs e)
        {
            Control clickedControl = (Control)sender;

            Panel panel = clickedControl as Panel ?? clickedControl.Parent as Panel;

            if (panel != null && panel.Tag is Filters filter)
            {
                try
                {
                    if (_frame.IsEmpty)
                    {
                        throw new InvalidOperationException("Hold on! Select a video first!");
                    }
                    activeFilter = filter.FilterNumber;
                    switch (activeFilter)
                    {
                        case 0:
                            FilterManagerPanel.Visible = false;
                            break;
                        case 1:
                            FilterManagerPanel.Visible = false;
                            break;
                        case 2:
                            FilterManagerPanel.Visible = false;
                            break;
                        case 3:
                            FilterManagerPanel.Visible = false;
                            break;
                        case 4:
                            FilterManagerPanel.Visible = true;
                            if (filterValue == 0 || filterValue < 0)
                            {
                                filterValue = 40;
                            }
                            SetValueFilter("Contrast Intensity:", filterValue);
                            break;
                        case 5:
                            FilterManagerPanel.Visible = false;
                            break;
                        case 6:
                            FilterManagerPanel.Visible = true;
                            if (filterValue == 0 || filterValue < 0)
                            {
                                filterValue = 4;
                            }
                            SetValueFilter("Levels:", filterValue);
                            break;
                        case 7:
                            FilterManagerPanel.Visible = false;
                            break;
                        case 8:
                            FilterManagerPanel.Visible = false;
                            break;
                        case 9:
                            FilterManagerPanel.Visible = true;
                            if (filterValue == 0 || filterValue < 0)
                            {
                                filterValue = 10;
                            }
                            SetValueFilter("Pixel Size:", filterValue);
                            break;
                        case 10:
                            FilterManagerPanel.Visible = false;
                            break;
                        case 11:
                            FilterManagerPanel.Visible = true;
                            if (filterValue == 0 || filterValue < 0)
                            {
                                filterValue = 8;
                            }
                            SetValueFilter("Glitch Intensity:", filterValue);
                            break;
                        case 12:
                            FilterManagerPanel.Visible = true;
                            if (filterValue == 0 || filterValue < 0)
                            {
                                filterValue = 8;
                            }
                            SetValueFilter("Glitch Intensity:", filterValue);
                            break;
                        case 13:
                            FilterManagerPanel.Visible = true;
                            if (filterValue == 0 || filterValue < 0)
                            {
                                filterValue = 8;
                            }
                            SetValueFilter("Glitch Intensity:", filterValue);
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void SetValueFilter(string name, int value)
        {
            ValueName.Text = name;
            FilterValueTextBox.Text = value.ToString();
        }
        private void Apply_Click(object sender, EventArgs e)
        {
            string filterValueText = FilterValueTextBox.Text;
            int value;

            if (int.TryParse(filterValueText, out value))
            {
                filterValue = value;
            }
            else
            {
                MessageBox.Show("Incorrect Value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private Bitmap ApplyFilter(int filterNumber, Bitmap frame)
        {
            switch (filterNumber)
            {
                case 0: 
                    return frame;
                case 1: 
                    return Invert(frame);
                case 2: 
                    return GrayScale(frame);
                case 3: 
                    return Negative(frame);
                case 4:
                    return Contrast(frame);
                case 5: 
                    return HeatMap(frame);
                case 6: 
                    return Posterize(frame);
                case 7: 
                    return Emboss(frame);
                case 8: 
                    return Comic(frame);
                case 9: 
                    return Pixel(frame);
                case 10: 
                    return Glitch(frame);
                case 11: 
                    return Glitch_1(frame);
                case 12: 
                    return Glitch_2(frame);
                case 13:
                    return Glitch_3(frame);
                default: 
                    FilterManagerPanel.Visible = false; 
                    return frame;
            }
        }
        //VIDEO CONTROLS
        private void Play_Pause_Click(object sender, EventArgs e)
        {
            Play_Pause_Control();
        }
        private void Play_Pause_Control()
        {
            if (play == true)
            {
                _frameTimer.Start();
                Play_Pause.Image = Properties.Resources.pause;
                play = false;
            }
            else
            {
                _frameTimer.Stop();
                Play_Pause.Image = Properties.Resources.play;
                play = true;
            }
        }
        private void Restart_Click(object sender, EventArgs e)
        {
            if (_videoCapture == null || !_videoCapture.IsOpened)
                return;

            _videoCapture.Set(Emgu.CV.CvEnum.CapProp.PosFrames, 0);
        }
        private void Backward_Click(object sender, EventArgs e)
        {

        }

        private void Forward_Click(object sender, EventArgs e)
        {

        }
        private void Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog chooseFile = new OpenFileDialog();

            chooseFile.Title = "Select Media Element";
            chooseFile.Filter = "Video Files| *.mp4; *.avi; *.wmv; *.mov";


            if (chooseFile.ShowDialog() == DialogResult.OK)
            {
                string filePath = chooseFile.FileName;
                string fileExtension = Path.GetExtension(filePath).ToLower();

                if (fileExtension == ".mp4" || fileExtension == ".avi" || fileExtension == ".wmv" || fileExtension == ".mov")
                {
                    PlayVideo(filePath);
                    Play_Pause.Enabled = true;
                    Restart.Enabled = true;
                    Backward.Enabled = true;
                    Forward.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Ups! Unsupported file format! :(", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        private void PlayVideo(string filePath)
        {
            _videoCapture?.Dispose();
            _videoCapture = new VideoCapture(filePath);

            if (_videoCapture.IsOpened)
            {
                _frameTimer.Start();
                Play_Pause.Image = Properties.Resources.pause;
            }
            else
            {
                MessageBox.Show("Failed to open video! :(", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FrameTimer_Tick(object sender, EventArgs e)
        {
            if (_videoCapture.Read(_frame) && !_frame.IsEmpty)
            {
                var inputFrame = _frame.ToImage<Bgr, byte>();

                int VideoWidth = inputFrame.Width;
                int VideoHeight = inputFrame.Height;

                int DisplayWidth = Display.Width;
                int DisplayHeight = Display.Height;

                float aspectRatio = (float)VideoWidth / VideoHeight;

                int newWidth, newHeight;

                if ((DisplayWidth / (float)DisplayHeight) > aspectRatio)
                {
                    newHeight = DisplayHeight;
                    newWidth = (int)(DisplayHeight * aspectRatio);
                }
                else
                {
                    newWidth = DisplayWidth;
                    newHeight = (int)(DisplayWidth / aspectRatio);
                }

                var resizedFrame = inputFrame.Resize(newWidth, newHeight, Emgu.CV.CvEnum.Inter.Linear);

                Display.Image?.Dispose();
                Display.Image = resizedFrame.ToBitmap();



                Display.Image = ApplyFilter(activeFilter, resizedFrame.ToBitmap());
                RGBHistorgram_Start(resizedFrame.ToBitmap());
            }
            else
            {
                _videoCapture.Set(Emgu.CV.CvEnum.CapProp.PosFrames, 0);
                _frameTimer.Start();
            }
        }
        public void VideoClear()
        {
            _frameTimer?.Stop();
            _videoCapture?.Dispose();
            _frame?.Dispose();
        }
        //SAVE VIDEO
        private void Save_Click(object sender, EventArgs e)
        {
            Play_Pause_Control();
            try
            {
                if (_frame.IsEmpty)
                {
                    throw new InvalidOperationException("Hold on! Select a video first!");
                }
                else
                {
                    SaveFileDialog saveDialog = new SaveFileDialog
                    {
                        Filter = "Video Files| *.mp4; *.avi; *.wmv; *.mov",
                        Title = "Save Processed Video"
                    };

                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveDialog.FileName;

                        ProgressBarForm progressForm = new ProgressBarForm();
                        progressForm.Show();

                        try
                        {
                            int totalFrames = (int)_videoCapture.Get(Emgu.CV.CvEnum.CapProp.FrameCount);
                            double fps = (int)_videoCapture.Get(Emgu.CV.CvEnum.CapProp.Fps);
                            int width = _videoCapture.Width;
                            int height = _videoCapture.Height;

                            using (var videoWriter = new Emgu.CV.VideoWriter(filePath, Emgu.CV.VideoWriter.Fourcc('M', 'J', 'P', 'G'), fps, new System.Drawing.Size(width, height), true))
                            {
                                List<Mat> buffer = new List<Mat>();

                                int processedFrames = 0;

                                for (int i = 0; i < totalFrames; i++)
                                {
                                    double currentFrame = _videoCapture.Get(Emgu.CV.CvEnum.CapProp.PosFrames);

                                    if (!_videoCapture.Read(_frame) || _frame.IsEmpty)
                                    {
                                        MessageBox.Show($"Error: Unable to read frame at {i + 1}/{totalFrames}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        break;
                                    }
                                    if (currentFrame >= totalFrames - 1)
                                    {
                                        MessageBox.Show($"Reached the last frame: {i + 1}/{totalFrames}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        break;
                                    }

                                    var resizedFrame = _frame.ToImage<Bgr, byte>();
                                    resizedFrame = resizedFrame.Resize(Display.Width, Display.Height, Emgu.CV.CvEnum.Inter.Linear);
                                    Bitmap filteredFrame = ApplyFilter(activeFilter, resizedFrame.ToBitmap());

                                    if (filteredFrame == null)
                                    {
                                        MessageBox.Show($"Error: Filtered frame at {i + 1}/{totalFrames} is null!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        break;
                                    }

                                    using (Emgu.CV.Mat processedMat = Emgu.CV.BitmapExtension.ToMat(filteredFrame))
                                    {
                                        if (processedMat.IsEmpty)
                                        {
                                            MessageBox.Show($"Error: Processed frame at {i + 1}/{totalFrames} is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            break;
                                        }

                                        buffer.Add(processedMat.Clone());

                                        if (buffer.Count >= 10)
                                        {
                                            foreach (var frame in buffer)
                                                videoWriter.Write(frame);
                                            buffer.Clear();
                                        }

                                        processedFrames++;
                                    }

                                    progressForm.Invoke(new Action(() =>
                                    {
                                        progressForm.UpdateProgress((int)((processedFrames) / (float)totalFrames * 100));
                                    }));
                                }

                                foreach (var frame in buffer)
                                    videoWriter.Write(frame);
                                buffer.Clear();

                                MessageBox.Show($"Video processing complete! {processedFrames}/{totalFrames} frames written.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error saving video: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            progressForm.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #region HYSTOGRAMS

        public void RGBHistorgram_Start(Bitmap img)
        {
            //Clear hystograms
            hystogramR = new int[256];
            hystogramG = new int[256];
            hystogramB = new int[256];

            if (Display.Image == null) return;

            for (int y = 0; y < img.Height; y++)
            {
                for (int x = 0; x < img.Width; x++)
                {
                    Color pixel = img.GetPixel(x, y);

                    hystogramR[pixel.R]++;
                    hystogramG[pixel.G]++;
                    hystogramB[pixel.B]++;
                }
            }
            Hystogram_Draw(Hystogram_RGB, hystogramR, hystogramG, hystogramB);
            Hystogram_Draw_RGB(Hystogram_R, hystogramR, Color.Red, 1);
            Hystogram_Draw_RGB(Hystogram_G, hystogramG, Color.Green, 2);
            Hystogram_Draw_RGB(Hystogram_B, hystogramB, Color.Blue, 3);
        }
        private void Hystogram_Draw(PictureBox pictureBox, int[] hystogramR, int[] hystogramG, int[] hystogramB)
        {
            int pictureBoxW = pictureBox.Width;
            int pictureBoxH = pictureBox.Height;

            Bitmap hystogramImg = new Bitmap(pictureBoxW, pictureBoxH);

            using (Graphics g = Graphics.FromImage(hystogramImg))
            {
                int max = Math.Max(Math.Max(hystogramR.Max(), hystogramG.Max()), hystogramB.Max());

                if (max == 0) return;

                //float scaleX = pictureBoxW / 256f; 
                float scaleY = pictureBoxH / (float)max; 

                for (int i = 0; i < 256; i++)
                {
                    int valueH_R = (int)(hystogramR[i] * scaleY);
                    int valueH_G = (int)(hystogramG[i] * scaleY);
                    int valueH_B = (int)(hystogramB[i] * scaleY);

                    //int posX = (int)(i * scaleX);

                    g.DrawLine(Pens.Red, i, pictureBoxH, i, pictureBoxH - valueH_R);
                    g.DrawLine(Pens.Green, i, pictureBoxH, i, pictureBoxH - valueH_G);
                    g.DrawLine(Pens.Blue, i, pictureBoxH, i, pictureBoxH - valueH_B);
                }
            }

            pictureBox.Image = hystogramImg;
        }
        private void Hystogram_Draw_RGB(PictureBox pictureBox, int[] hystogram, Color color, int colorId)//RGB
        {
            int pictureBoxW = pictureBox.Width;
            int pictureBoxH = pictureBox.Height;

            Bitmap hystogramImg = new Bitmap(pictureBoxW, pictureBoxH);

            Graphics g = Graphics.FromImage(hystogramImg);
            int max = 0;
            switch (colorId)
            {
                case 1:
                    max = hystogramR.Max();
                    break;
                case 2:
                    max = hystogramG.Max();
                    break;
                case 3:
                    max = hystogramB.Max();
                    break;
            }

            if (max == 0) return;

            float scaleY = pictureBoxH / (float)max;

            for (int i = 0; i < 256; i++)
            {
                int valueH = (int)(hystogram[i] * scaleY);

                g.DrawLine(new Pen(color), i, pictureBoxH, i, pictureBoxH - valueH);
            }

            pictureBox.Image = hystogramImg;
        }
        #endregion
        #region FILTERS
        //FILTERS
        private Bitmap Invert(Bitmap img)
        {
            for (int j = 0; j < img.Height; j++)
            {
                for (int i = 0; i < img.Width; i++)
                {
                    Color color = img.GetPixel(i, j);

                    int R = color.R;
                    int G = color.G;
                    int B = color.B;

                    img.SetPixel(i, j, Color.FromArgb(B, G, R));//We put the colors in the inverted channel
                }
            }
            RGBHistorgram_Start(img);
            return img;
        }
        private Bitmap GrayScale(Bitmap img)
        {
            for (int j = 0; j < img.Height; j++)
            {
                for (int i = 0; i < img.Width; i++)
                {
                    Color color = img.GetPixel(i, j);

                    int R = color.R;
                    int G = color.G;
                    int B = color.B;
                    int Gray = (R + G + B) / 3;

                    img.SetPixel(i, j, Color.FromArgb(Gray, Gray, Gray));
                }
            }
            RGBHistorgram_Start(img);
            return img;
        }
        private Bitmap Negative(Bitmap img)
        {
            for (int j = 0; j < img.Height; j++)
            {
                for (int i = 0; i < img.Width; i++)
                {
                    Color color = img.GetPixel(i, j);

                    int R = Math.Abs(color.R - 255);
                    int G = Math.Abs(color.G - 255);
                    int B = Math.Abs(color.B - 255);

                    img.SetPixel(i, j, Color.FromArgb(R, G, B));
                }
            }
            RGBHistorgram_Start(img);
            return img;
        }
        private Bitmap Contrast(Bitmap img)
        {
            //int contrastIntensity = 40;

            float Contrast = (100.0f + filterValue) / 100.0f;
            Contrast *= Contrast;

            for (int j = 0; j < img.Height; j++)
            {
                for (int i = 0; i < img.Width; i++)
                {
                    Color color = img.GetPixel(i, j);

                    float R = ((((color.R / 255.0f) - 0.5f) * Contrast) + 0.5f) * 255;
                    if (R > 255) R = 255;
                    if (R < 0) R = 0;
                    float G = ((((color.G / 255.0f) - 0.5f) * Contrast) + 0.5f) * 255;
                    if (G > 255) G = 255;
                    if (G < 0) G = 0;
                    float B = ((((color.B / 255.0f) - 0.5f) * Contrast) + 0.5f) * 255;
                    if (B > 255) B = 255;
                    if (B < 0) B = 0;

                    img.SetPixel(i, j, Color.FromArgb((int)R, (int)G, (int)B));
                }
            }

            RGBHistorgram_Start(img);
            return img;
        }
        private Bitmap HeatMap(Bitmap img)
        {
            for (int j = 0; j < img.Height; j++)
            {
                for (int i = 0; i < img.Width; i++)
                {
                    Color color = img.GetPixel(i, j);
                    int intensity = (color.R + color.G + color.B) / 3;

                    int R = intensity > 128 ? 255 : intensity * 2;
                    if (R > 255) R = 255;
                    if (R < 0) R = 0;
                    int G = intensity > 128 ? (255 - intensity) * 2 : 0;
                    if (G > 255) G = 255;
                    if (G < 0) G = 0;
                    int B = intensity < 128 ? 255 : (255 - intensity) * 2;
                    if (B > 255) B = 255;
                    if (B < 0) B = 0;

                    img.SetPixel(i, j, Color.FromArgb(R, G, B));
                }
            }
            RGBHistorgram_Start(img);
            return img;
        }
        private Bitmap Posterize(Bitmap img)
        {
            //int levels = 4;
            int factor = 255 / (filterValue - 1);

            for (int j = 0; j < img.Height; j++)
            {
                for (int i = 0; i < img.Width; i++)
                {
                    Color color = img.GetPixel(i, j);

                    int R = (color.R / factor) * factor;
                    int G = (color.G / factor) * factor;
                    int B = (color.B / factor) * factor;

                    img.SetPixel(i, j, Color.FromArgb(R, G, B));
                }
            }
            RGBHistorgram_Start(img);
            return img;
        }
        private Bitmap Emboss(Bitmap img)
        {
            for (int j = 0; j < img.Height - 2; j++)
            {
                for (int i = 0; i < img.Width - 2; i++)
                {
                    Color color = img.GetPixel(i, j);
                    Color color2 = img.GetPixel(i + 2, j + 2);

                    int R = Math.Clamp(128 + (color.R - color2.R), 0, 255);
                    int G = Math.Clamp(128 + (color.G - color2.G), 0, 255);
                    int B = Math.Clamp(128 + (color.B - color2.B), 0, 255);

                    img.SetPixel(i, j, Color.FromArgb(R, G, B));
                }
            }
            RGBHistorgram_Start(img);
            return img;
        }
        private Bitmap Comic(Bitmap img)
        {
            for (int j = 0; j < img.Height; j++)
            {
                for (int i = 0; i < img.Width; i++)
                {
                    Color color = img.GetPixel(i, j);

                    int R = (color.R > 128) ? 255 : 0;
                    int G = (color.G > 128) ? 255 : 0;
                    int B = (color.B > 128) ? 255 : 0;

                    img.SetPixel(i, j, Color.FromArgb(R, G, B));
                }
            }
            RGBHistorgram_Start(img);
            return img;
        }
        private Bitmap Pixel(Bitmap img)
        {
            //int Pixel = 10;//pizel size
            int iPixel, jPixel;
            int sumR, sumG, sumB;

            for (int i = 0; i < img.Width - filterValue; i += filterValue)
            {
                for (int j = 0; j < img.Height - filterValue; j += filterValue)
                {
                    sumR = 0;
                    sumG = 0;
                    sumB = 0;

                    for (iPixel = i; iPixel < (i + filterValue); iPixel++)
                    {
                        for (jPixel = j; jPixel < (j + filterValue); jPixel++)
                        {
                            Color color = img.GetPixel(iPixel, jPixel);

                            sumR += color.R;
                            sumG += color.G;
                            sumB += color.B;
                        }
                    }

                    int R = sumR / (filterValue * filterValue);
                    int G = sumG / (filterValue * filterValue);
                    int B = sumB / (filterValue * filterValue);

                    Color colorM = Color.FromArgb(R, G, B);

                    for (iPixel = i; iPixel < (i + filterValue); iPixel++)
                    {
                        for (jPixel = j; jPixel < (j + filterValue); jPixel++)
                        {
                            img.SetPixel(iPixel, jPixel, colorM);
                        }
                    }
                }
            }

            return img;
        }
        private Bitmap Glitch(Bitmap img)
        {
            Random rnd = new Random();

            for (int j = 0; j < img.Height; j++)
            {
                int glitchShift = rnd.Next(-2, 2);

                for (int i = 0; i < img.Width; i++)
                {
                    if (i + glitchShift >= 0 && i + glitchShift < img.Width)
                    {
                        Color color = img.GetPixel(i, j);

                        int R = Math.Clamp(color.R + rnd.Next(-20, 20), 0, 255);
                        int G = Math.Clamp(color.G + rnd.Next(-20, 20), 0, 255);
                        int B = Math.Clamp(color.B + rnd.Next(-20, 20), 0, 255);

                        img.SetPixel(i + glitchShift, j, Color.FromArgb(R, G, B));
                    }
                }
                if (rnd.NextDouble() > 0.98)
                {
                    for (int i = 0; i < img.Width; i++)
                    {
                        int R = rnd.Next(0, 256);
                        int G = rnd.Next(0, 256);
                        int B = rnd.Next(0, 256);

                        img.SetPixel(i, j, Color.FromArgb(R, G, B));
                    }
                }
            }
            RGBHistorgram_Start(img);
            return img;
        }
        private Bitmap Glitch_1(Bitmap img)
        {
            //int filterValue = 8;
            int R, G, B;

            for (int j = 0; j < img.Height; j++)
            {
                for (int i = 0; i < img.Width; i++)
                {
                    G = img.GetPixel(i, j).G;

                    if (i + filterValue < img.Width)
                    {
                        R = img.GetPixel(i + filterValue, j).R;
                    }
                    else
                    {
                        R = 0;
                    }

                    if (i - filterValue >= 0)
                    {
                        B = img.GetPixel(i - filterValue, j).B;
                    }
                    else
                    {
                        B = 0;
                    }

                    img.SetPixel(i, j, Color.FromArgb(R, G, B));
                }
            }
            RGBHistorgram_Start(img);
            return img;
        }
        private Bitmap Glitch_2(Bitmap img)
        {
            int filterValue = 8;
            int R, G, B;

            for (int j = 0; j < img.Height; j++)
            {
                for (int i = 0; i < img.Width; i++)
                {
                    R = img.GetPixel(i, j).R;

                    if (i + filterValue < img.Width)
                    {
                        B = img.GetPixel(i + filterValue, j).B;
                    }
                    else
                    {
                        B = 0;
                    }

                    if (i - filterValue >= 0)
                    {
                        G = img.GetPixel(i - filterValue, j).G;
                    }
                    else
                    {
                        G = 0;
                    }

                    img.SetPixel(i, j, Color.FromArgb(R, G, B));
                }
            }
            RGBHistorgram_Start(img);
            return img;
        }
        private Bitmap Glitch_3(Bitmap img)
        {
            int filterValue = 8;
            int R, G, B;

            for (int j = 0; j < img.Height; j++)
            {
                for (int i = 0; i < img.Width; i++)
                {
                    B = img.GetPixel(i, j).B;

                    if (i + filterValue < img.Width)
                    {
                        G = img.GetPixel(i + filterValue, j).G;
                    }
                    else
                    {
                        G = 0;
                    }

                    if (i - filterValue >= 0)
                    {
                        R = img.GetPixel(i - filterValue, j).R;
                    }
                    else
                    {
                        R = 0;
                    }

                    img.SetPixel(i, j, Color.FromArgb(R, G, B));
                }
            }
            RGBHistorgram_Start(img);
            return img;
        }
        #endregion

    }
}
