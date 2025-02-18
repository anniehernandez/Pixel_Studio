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
        private FiltersUserCrtl filtersCtrl;
        public Image originalImage;

        public ImageEditing(FiltersUserCrtl filtersCtrl)
        {
            this.filtersCtrl = filtersCtrl;
            InitializeComponent();
        }
        private void Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog chooseFile = new OpenFileDialog();

            chooseFile.Filter = "Image Files| *.jpg; *.jpeg; *.png; *.bmp; *.gif";//Filter only image formats
            chooseFile.Title = "Select Media Element";

            if (chooseFile.ShowDialog() == DialogResult.OK)
            {
                string filePath = chooseFile.FileName;
                string fileExtension = Path.GetExtension(filePath).ToLower();//Gets the file extension

                if (fileExtension == ".jpg" || fileExtension == ".jpeg" || fileExtension == ".png" || fileExtension == ".bmp" || fileExtension == ".gif")
                {
                    Display.Image = Image.FromFile(filePath);

                    originalImage = Display.Image;
                    Bitmap img = new Bitmap(originalImage);

                    this.filtersCtrl.RGBHistorgram_Start(img);
                }
                else
                {
                    MessageBox.Show("Ups! Unsupported file format! :(", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

    }
}
