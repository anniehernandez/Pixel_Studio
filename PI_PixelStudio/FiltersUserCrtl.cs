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

namespace PI_PixelStudio
{
    public partial class FiltersUserCrtl : UserControl
    {
        public Image originalImage;
        private int[] hystogramR = new int[256];
        private int[] hystogramG = new int[256];
        private int[] hystogramB = new int[256];

        bool play = true;

        public FiltersUserCrtl()
        {
            InitializeComponent();

            List<Filters> filters = new List<Filters>
            {
                new Filters("Filter 1", Properties.Resources.Picture, 0),
                new Filters("Filter 2", Properties.Resources.PixelStudio, 1),
                new Filters("Filter 3", Properties.Resources.Logo, 2)
            };
            LoadFilters(filters);

            ButtonControl.Visible = false;
            ControlBar.Visible = false;
            Display.Visible = false;
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
                Size = new Size(140, 153),
                BackColor = Color.FromArgb(36, 41, 62),
                BorderStyle = BorderStyle.None,
                Name = "FilterPanel",
                Tag = filter
            };
            PictureBox pictureBox = new PictureBox
            {
                Size = new Size(117, 109),
                Image = filter.FilterImage,
                Name = "FIlterPicture",
                SizeMode = PictureBoxSizeMode.Zoom,
                Location = new Point(12, 12)
            };
            Label label = new Label
            {
                Text = filter.FilterName,
                Size = new Size(75, 17),
                AutoSize = true,
                Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0),
                ForeColor = Color.White,
                Name = "FilterName",
                Location = new Point(32, 124)
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
                MessageBox.Show("Message" + filter.FilterNumber, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.None);

                ApplyFilter(filter.FilterNumber);
            }
        }
        private void ApplyFilter(int filterNumber)
        {
            switch (filterNumber)
            {
                case 0:
                    Display.Image = originalImage;
                    break;
                case 1:
                    break;
            }
        }
        private void imageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ButtonControl.Visible = false;
            ControlBar.Visible = true;
            Display.Visible = true;
        }
        private void videoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ButtonControl.Visible = true;
            ControlBar.Visible = true;
            ZoomIn.Visible = false;
            ZoomOut.Visible = false;
            Display.Visible = true;
        }
        private void Play_Pause_Click(object sender, EventArgs e)
        {

            if (play == true)
            {
                Play_Pause.Image = Properties.Resources.pause;
                play = false;
            }
            else
            {
                Play_Pause.Image = Properties.Resources.play;
                play = true;
            }
        }
        private void Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog chooseFile = new OpenFileDialog();

            chooseFile.Filter = "Image Files| *.jpg; *.jpeg; *.png; *.bmp; *.gif| Video Files| *.mp4; *.avi; *.wmv; *.mov";//Filter only image formats
            chooseFile.Title = "Select Media Element";

            if (chooseFile.ShowDialog() == DialogResult.OK)
            {
                string filePath = chooseFile.FileName;
                string fileExtension = Path.GetExtension(filePath).ToLower();//Gets the file extension

                if (fileExtension == ".jpg" || fileExtension == ".jpeg" || fileExtension == ".png" || fileExtension == ".bmp" || fileExtension == ".gif")
                {
                    Display.Image = Image.FromFile(filePath);

                    originalImage = new Bitmap(Display.Image);

                    Bitmap img = new Bitmap(originalImage);

                    RGBHistorgram_Start(img);
                }
                else if (fileExtension == ".mp4" || fileExtension == ".avi" || fileExtension == ".wmv" || fileExtension == ".mov")
                {

                }
                else
                {
                    MessageBox.Show("Ups! Unsupported file format! :(", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
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
    }
}
