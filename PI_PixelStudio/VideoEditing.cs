using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_PixelStudio
{
    public partial class VideoEditing : UserControl
    {
        bool play = true;
        public VideoEditing()
        {
            InitializeComponent();
            VideoDisplay.uiMode = "none";
        }

        private void Play_Pause_Click(object sender, EventArgs e)
        {
            if (play == true)
            {
                Play_Pause.Image = Image.FromFile("C://Users//luish//source//repos//PI_PixelStudio//PI_PixelStudio//Resources//pause.png");
                VideoDisplay.Ctlcontrols.play();
                play = false;
            }
            else
            {
                Play_Pause.Image = Image.FromFile("C://Users//luish//source//repos//PI_PixelStudio//PI_PixelStudio//Resources//play.png");
                VideoDisplay.Ctlcontrols.pause();
                play = true;
            }
        }

        private void Backward_Click(object sender, EventArgs e)
        {
            VideoDisplay.Ctlcontrols.currentPosition -= 5;
        }

        private void Forward_Click(object sender, EventArgs e)
        {
            VideoDisplay.Ctlcontrols.currentPosition += 5;
        }

        private void Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog chooseFile = new OpenFileDialog();

            chooseFile.Filter = "Video Files| *.mp4; *.avi; *.wmv; *.mov";
            chooseFile.Title = "Select a Video";

            if(chooseFile.ShowDialog() == DialogResult.OK)
            {
                string filePath = chooseFile.FileName;
                string fileExtension = Path.GetExtension(filePath);

                if(fileExtension == ".mp4" || fileExtension == ".avi" || fileExtension == ".wmv" || fileExtension == ".mov")
                {
                    VideoDisplay.URL = filePath;
                    VideoDisplay.Ctlcontrols.play();
                }
                else
                {
                    MessageBox.Show("Ups! Unsupported file format! :(", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
