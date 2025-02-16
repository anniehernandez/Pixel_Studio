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
    public partial class ImageEditing : UserControl
    {
        public ImageEditing()
        {
            InitializeComponent();
        }

        private void Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog chooseFile = new OpenFileDialog();

            chooseFile.Filter = "Image Files| *.jpg; *.jpeg; *.png; *.bmp; *.gif";//Filter only image formats
            chooseFile.Title = "Select an Image";

            if (chooseFile.ShowDialog() == DialogResult.OK)
            {
                string filePath = chooseFile.FileName;
                string fileExtension = Path.GetExtension(filePath).ToLower();//Gets the file extension

                if (fileExtension == ".jpg" || fileExtension == ".jpeg" || fileExtension == ".png" || fileExtension == ".bmp" || fileExtension == ".gif")
                {
                    ImageDisplay.Image = Image.FromFile(filePath);
                }
                else
                {
                    MessageBox.Show("Ups! Unsuported File format! :(", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
