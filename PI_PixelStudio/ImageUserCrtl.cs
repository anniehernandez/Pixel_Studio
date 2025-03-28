using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace PI_PixelStudio
{
    public partial class ImageUserCrtl : UserControl
    {
        public Image originalImage;
        private int[] hystogramR = new int[256];
        private int[] hystogramG = new int[256];
        private int[] hystogramB = new int[256];
        private int activeFilter;
        private int filterValue;

        public ImageUserCrtl()
        {
            InitializeComponent();

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
        //FILTERS
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
        //private FilterParamForm filterParam;
        private void FilterPanel_Click(object sender, EventArgs e)
        {
            Control clickedControl = (Control)sender;

            Panel panel = clickedControl as Panel ?? clickedControl.Parent as Panel;

            if (panel != null && panel.Tag is Filters filter)
            {
                activeFilter = filter.FilterNumber;
                ApplyFilter(activeFilter);
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
                ApplyFilter(activeFilter);
            }
            else
            {
                MessageBox.Show("Incorrect Value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ApplyFilter(int filterNumber)
        {
            try
            {
                if (originalImage == null)
                {
                    throw new InvalidOperationException("Hold on! Select an image first!");
                }
                Bitmap img = new Bitmap(originalImage);


                switch (filterNumber)
                {
                    case 0:
                        Display.Image = originalImage;
                        RGBHistorgram_Start(img);
                        FilterManagerPanel.Visible = false;
                        break;

                    case 1:
                        Display.Image = Invert(img);
                        FilterManagerPanel.Visible = false;
                        break;

                    case 2:
                        Display.Image = GrayScale(img);
                        FilterManagerPanel.Visible = false;
                        break;

                    case 3:
                        Display.Image = Negative(img);
                        FilterManagerPanel.Visible = false;
                        break;

                    case 4:
                        FilterManagerPanel.Visible = true;
                        if (filterValue == 0 || filterValue < 0)
                        {
                            filterValue = 40;
                        }
                        SetValueFilter("Contrast Intensity:", filterValue);
                        Display.Image = Contrast(img);
                        break;

                    case 5:
                        Display.Image = HeatMap(img);
                        FilterManagerPanel.Visible = false;
                        break;

                    case 6:
                        FilterManagerPanel.Visible = true;
                        if (filterValue == 0 || filterValue < 0)
                        {
                            filterValue = 4;
                        }
                        SetValueFilter("Levels:", filterValue);
                        Display.Image = Posterize(img);
                        break;

                    case 7:
                        Display.Image = Emboss(img);
                        FilterManagerPanel.Visible = false;
                        break;

                    case 8:
                        Display.Image = Comic(img);
                        FilterManagerPanel.Visible = false;
                        break;

                    case 9:
                        FilterManagerPanel.Visible = true;
                        if (filterValue == 0 || filterValue < 0)
                        {
                            filterValue = 10;
                        }
                        SetValueFilter("Pixel Size:", filterValue);
                        Display.Image = Pixel(img);
                        break;

                    case 10:
                        Display.Image = Glitch(img);
                        FilterManagerPanel.Visible = false;
                        break;

                    case 11:
                        FilterManagerPanel.Visible = true;
                        if (filterValue == 0 || filterValue < 0)
                        {
                            filterValue = 8;
                        }
                        SetValueFilter("Glitch Intensity:", filterValue);
                        Display.Image = Glitch_1(img);
                        break;

                    case 12:
                        FilterManagerPanel.Visible = true;
                        if (filterValue == 0 || filterValue < 0)
                        {
                            filterValue = 8;
                        }
                        SetValueFilter("Glitch Intensity:", filterValue);
                        Display.Image = Glitch_2(img);
                        break;

                    case 13:
                        FilterManagerPanel.Visible = true;
                        if (filterValue == 0 || filterValue < 0)
                        {
                            filterValue = 8;
                        }
                        SetValueFilter("Glitch Intensity:", filterValue);
                        Display.Image = Glitch_3(img);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog chooseFile = new OpenFileDialog();

            chooseFile.Title = "Select Media Element";

            chooseFile.Filter = "Image Files| *.jpg; *.jpeg; *.png; *.bmp; *.gif";

            if (chooseFile.ShowDialog() == DialogResult.OK)
            {
                string filePath = chooseFile.FileName;
                string fileExtension = Path.GetExtension(filePath).ToLower();

                if (fileExtension == ".jpg" || fileExtension == ".jpeg" || fileExtension == ".png" || fileExtension == ".bmp" || fileExtension == ".gif")
                {
                    Display.Image = Image.FromFile(filePath);
                    FilterManagerPanel.Visible = false;

                    originalImage = new Bitmap(Display.Image);

                    Bitmap img = new Bitmap(originalImage);

                    RGBHistorgram_Start(img);
                }
                else
                {
                    MessageBox.Show("Ups! Unsupported file format! :(", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        private void Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Image Files| *.jpg; *.jpeg; *.png; *.bmp; *.gif";//Filter only image formats
            Image img = Display.Image;

            if (img != null)
            {
                MessageBox.Show("No image loaded!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (save.ShowDialog() == DialogResult.OK)
                {
                    img.Save(save.FileName);
                    MessageBox.Show("Image saved succesfully", "Image Saved", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
        }
        #region HYSTOGRAMS
        //GENERATE HYSTOGRAM
        public void RGBHistorgram_Start(Bitmap img)
        {
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
            Hystogram_Draw_RGB(Hystogram_R, hystogramR, Color.Red);
            Hystogram_Draw_RGB(Hystogram_G, hystogramG, Color.Green);
            Hystogram_Draw_RGB(Hystogram_B, hystogramB, Color.Blue);
        }
        //DRAW HYSTOGRAMS
        private void Hystogram_Draw(PictureBox pictureBox, int[] hystogramR, int[] hystogramG, int[] hystogramB)//RGB
        {
            int pictureBoxW = pictureBox.Width;
            int pictureBoxH = pictureBox.Height;

            Bitmap hystogramImg = new Bitmap(pictureBoxW, pictureBoxH);

            Graphics g = Graphics.FromImage(hystogramImg);

            int max = Math.Max(Math.Max(hystogramR.Max(), hystogramG.Max()), hystogramB.Max());

            if (max == 0) return;

            float scaleX = pictureBoxW / 256f;

            for (int i = 0; i < 256; i++)
            {
                int valueH_R = (int)((hystogramR[i] / (float)max) * pictureBoxH);
                int valueH_G = (int)((hystogramG[i] / (float)max) * pictureBoxH);
                int valueH_B = (int)((hystogramB[i] / (float)max) * pictureBoxH);

                int PosX = (int)(i * scaleX);

                g.DrawLine(new Pen(Color.Red), PosX, pictureBoxH, PosX, pictureBoxH - valueH_R);
                g.DrawLine(new Pen(Color.Green), PosX, pictureBoxH, PosX, pictureBoxH - valueH_G);
                g.DrawLine(new Pen(Color.Blue), PosX, pictureBoxH, PosX, pictureBoxH - valueH_B);
            }

            pictureBox.Image = hystogramImg;
        }
        private void Hystogram_Draw_RGB(PictureBox pictureBox, int[] hystogram, Color color)//RGB
        {
            int pictureBoxW = pictureBox.Width;
            int pictureBoxH = pictureBox.Height;

            Bitmap hystogramImg = new Bitmap(pictureBoxW, pictureBoxH);

            Graphics g = Graphics.FromImage(hystogramImg);

            int max = Math.Max(Math.Max(hystogramR.Max(), hystogramG.Max()), hystogramB.Max());

            if (max == 0) return;

            float scaleX = pictureBoxW / 256f;

            for (int i = 0; i < 256; i++)
            {
                int valueH = (int)((hystogram[i] / (float)max) * pictureBoxH);

                int PosX = (int)(i * scaleX);

                g.DrawLine(new Pen(color), PosX, pictureBoxH, PosX, pictureBoxH - valueH);
            }

            pictureBox.Image = hystogramImg;
        }

        #region Paint Hystograms
        private void Hystogram1_Paint(object sender, PaintEventArgs e)//RGB
        {
            Graphics g = e.Graphics;
            Pen penAxis = new Pen(Color.White);

            g.DrawLine(penAxis, 4, 126, 126, 126);
            g.DrawLine(penAxis, 4, 126, 4, 4);
        }
        private void Hystogram2_Paint(object sender, PaintEventArgs e)//R
        {
            Graphics g = e.Graphics;
            Pen penAxis = new Pen(Color.Red);

            g.DrawLine(penAxis, 4, 126, 126, 126);
            g.DrawLine(penAxis, 4, 126, 4, 4);
        }
        private void Hystogram3_Paint(object sender, PaintEventArgs e)//G
        {
            Graphics g = e.Graphics;
            Pen penAxis = new Pen(Color.Green);

            g.DrawLine(penAxis, 4, 126, 126, 126);
            g.DrawLine(penAxis, 4, 126, 4, 4);
        }
        private void Hystogram4_Paint(object sender, PaintEventArgs e)//B
        {
            Graphics g = e.Graphics;
            Pen penAxis = new Pen(Color.Blue);

            g.DrawLine(penAxis, 4, 126, 126, 126);
            g.DrawLine(penAxis, 4, 126, 4, 4);

            //for (int i = 0; i < 256; i++)
            //{
            //    g.DrawLine(penBlue, i + 20, 121, i + 20, 121 - hystogramB[i]);
            //}
        }
        #endregion

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

                    for (iPixel = i; iPixel < (i + filterValue); iPixel++)//Sums the value of a particular set of pixels depending of the Pixel size (gets the Pixel color)
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