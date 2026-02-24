using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PI_PixelStudio
{
    public partial class UserManualUserCtrl : UserControl
    {
        public UserManualUserCtrl()
        {
            InitializeComponent();

            SectionNameLabel.Text = "Menu";
            SectionPicture.Image = Properties.Resources._1;
            ContentRichBox.Text = @"Welcome to PixelStudio! Feeling a little lost? Let's start and go over out main window: We can divide this window into 3 panels.";
            Bold(ContentRichBox, "\n\n1⭐"); Regular(ContentRichBox, "Window Options.");
            Bold(ContentRichBox, "\n2⭐"); Regular(ContentRichBox, "Menu.");
            Bold(ContentRichBox, "\n3⭐"); Regular(ContentRichBox, "Main Panel.");

            Bold(ContentRichBox, "\n\n1⭐"); Regular(ContentRichBox, "Window Options:\n\tContains the(?) Help, [-] Minimize, [□] Maximize, and[x] Exit Buttons in that respective order from left to right.");
            Bold(ContentRichBox, "\r\n2⭐"); Regular(ContentRichBox, "Menu:\n\t Contains all the 3 Main sections of our application 1) Image, 2) Video, and 3) Camera. In the menu at the top you can find more about each specific section.");
            Bold(ContentRichBox, "\r\n3⭐"); Regular(ContentRichBox, "Main Panel:\n\tThis Panel will cointain the actual workspace of the application.");
        }
        private void Reset()
        {
            SectionPicture.Visible = true;
            DownloadDoc.Visible = false;
        }
        private void Bold(RichTextBox richTextBox, string text)
        {
            int startSelection = richTextBox.TextLength;

            richTextBox.AppendText(text);
            richTextBox.Select(startSelection, text.Length);

            richTextBox.SelectionFont = new Font(richTextBox.Font, FontStyle.Bold);
            richTextBox.SelectionColor = Color.FromArgb(113, 109, 214);

            richTextBox.Select(startSelection + text.Length, 0);
        }
        private void Regular(RichTextBox richTextBox, string text)
        {
            int startSelection = richTextBox.TextLength;

            richTextBox.AppendText(text);
            richTextBox.Select(startSelection, text.Length);
            richTextBox.SelectionFont = new Font(richTextBox.Font, FontStyle.Regular);
            richTextBox.SelectionColor = Color.White;

            richTextBox.Select(startSelection + text.Length, 0);
        }
        private void MenuItem_Click(object sender, EventArgs e)
        {
            Reset();
            SectionNameLabel.Text = "Menu";
            SectionPicture.Image = Properties.Resources._1;
            ContentRichBox.Text = @"Welcome to PixelStudio! Feeling a little lost? Let's start and go over out main window: We can divide this window into 3 panels.";
            Bold(ContentRichBox, "\n\n1⭐"); Regular(ContentRichBox, "Window Options.");
            Bold(ContentRichBox, "\n2⭐"); Regular(ContentRichBox, "Menu.");
            Bold(ContentRichBox, "\n3⭐"); Regular(ContentRichBox, "Main Panel.");

            Bold(ContentRichBox, "\n\n1⭐"); Regular(ContentRichBox, "Window Options:\n\tContains the:" +
                "\n\t(?) Help Button.\n\t[-] Minimize Button.\n\t[□] Maximize Button.\n\t[x] Exit Button." +
                "\nin that respective order from left to right.");
            Bold(ContentRichBox, "\r\n2⭐"); Regular(ContentRichBox, "Menu:\n\t Contains all the 3 Main sections of our application 1) Image, 2) Video, and 3) Camera. In the menu at the top you can find more about each specific section.");
            Bold(ContentRichBox, "\r\n3⭐"); Regular(ContentRichBox, "Main Panel:\n\tThis Panel will cointain the actual workspace of the application.");
        }
        private void ImageStrip_Click(object sender, EventArgs e)
        {
            Reset();
            SectionNameLabel.Text = "Image";
            SectionPicture.Image = Properties.Resources._2;
            ContentRichBox.Text = @"Get to know the workspace for Images! Let's go over the details: We hace 4 main sections to go through.";
            Bold(ContentRichBox, "\n\n1⭐"); Regular(ContentRichBox, "Image Viewport.");
            Bold(ContentRichBox, "\n2⭐"); Regular(ContentRichBox, "Options Bar.");
            Bold(ContentRichBox, "\n3⭐"); Regular(ContentRichBox, "Hystograms.");
            Bold(ContentRichBox, "\n4⭐"); Regular(ContentRichBox, "Filters.");

            Bold(ContentRichBox, "\n\n1⭐"); Regular(ContentRichBox, "Image Viewport:\n\tIn this space we'll be able to upload the image we wish to edit and see the changes applied to it.");
            Bold(ContentRichBox, "\r\n2⭐"); Regular(ContentRichBox, "Options Bar:\n\tThis bar contains the Upload and Save buttons for our images.");
            Bold(ContentRichBox, "\r\n3⭐"); Regular(ContentRichBox, "Hystograms:\n\tIn this space we'll see the hystogram of our image in RGB and R, G & B separately.");
            Bold(ContentRichBox, "\r\n4⭐"); Regular(ContentRichBox, "Filters:\n\tHere we'll see the list of filters be displayed. We can apply any filter to our image simply by clicking on the desired filter.");
        }

        private void VideoStrip_Click(object sender, EventArgs e)
        {
            SectionNameLabel.Text = "Video";
            SectionPicture.Image = Properties.Resources._3;
            ContentRichBox.Text = @"Get to know the workspace for Videos! Let's go over the details: We hace 5 main sections to go through.";
            Bold(ContentRichBox, "\n\n1⭐"); Regular(ContentRichBox, "Video Viewport.");
            Bold(ContentRichBox, "\n2⭐"); Regular(ContentRichBox, "Options Bar.");
            Bold(ContentRichBox, "\n3⭐"); Regular(ContentRichBox, "Video Controls.");
            Bold(ContentRichBox, "\n4⭐"); Regular(ContentRichBox, "Hystograms.");
            Bold(ContentRichBox, "\n5⭐"); Regular(ContentRichBox, "Filters.");

            Bold(ContentRichBox, "\n\n1⭐"); Regular(ContentRichBox, "Video Viewport:\n\tIn this space we'll be able to upload the video we wish to edit and see the changes applied to it.");
            Bold(ContentRichBox, "\r\n2⭐"); Regular(ContentRichBox, "Options Bar:\n\tThis bar contains the Upload buttons for our videos.");
            Bold(ContentRichBox, "\r\n3⭐"); Regular(ContentRichBox, "Video Controls:\n\tThis bar contains the Pause & Play buttons to control our video.");
            Bold(ContentRichBox, "\r\n4⭐"); Regular(ContentRichBox, "Hystograms:\n\tIn this space we'll see the hystogram of our video in RGB and R, G & B separately.");
            Bold(ContentRichBox, "\r\n5⭐"); Regular(ContentRichBox, "Filters:\n\tHere we'll see the list of filters be displayed. We can apply any filter to our video simply by clicking on the desired filter.");
        }
        private void CameraStrip_Click(object sender, EventArgs e)
        {
            Reset();
            SectionNameLabel.Text = "Camera";
            SectionPicture.Image = Properties.Resources._3;
            ContentRichBox.Text = @"Get to know the workspace for Camera! Let's go over the details: We hace 5 main sections to go through.";
            Bold(ContentRichBox, "\n\n1⭐"); Regular(ContentRichBox, "Camera Viewport.");
            Bold(ContentRichBox, "\n2⭐"); Regular(ContentRichBox, "Options Bar.");
            Bold(ContentRichBox, "\n3⭐"); Regular(ContentRichBox, "Color Lab.");

            Bold(ContentRichBox, "\n\n1⭐"); Regular(ContentRichBox, "Camera Viewport:\n\tIn this space we'll be able to see the image from our camera.");
            Bold(ContentRichBox, "\r\n2⭐"); Regular(ContentRichBox, "Options Bar:\n\tThis bar contains the Open/Close Button for our camera image.");
            Bold(ContentRichBox, "\r\n3⭐"); Regular(ContentRichBox, "Color Lab:\n\tThis space contains the:\n\t1) Color viewport: to see the color that is being detected from our camera." +
                "\n\t2) Hexadecimal Code: that will display The color code in hexadecimal value." +
                "\n\t3) CIELAB Color space: were they'll be displayed the L, a & b values of the CIELAB Colorspace." +
                "\n\t4) Capture Button: To capture or freeze the color detected.");
        }
        private void MoreStrip_Click(object sender, EventArgs e)
        {
            SectionNameLabel.Text = "Contact Information / Documentation";
            SectionPicture.Visible = false;
            ContentRichBox.Text = "If you enjoyed our app or have any questions regrading it make sure to take a look to our documentation and contact info!\n";
                Bold(ContentRichBox, "\t📧"); Regular(ContentRichBox, " Email: anasofia.hernandez002@gmail.com\n");
                Bold(ContentRichBox, "\t📖"); Regular(ContentRichBox, " Download the documentation!\n");
            //"\t🌐 Website: www.yourapp.com\n" +
            //"\t📱 Social Media: @YourAppOfficial\n" +
            DownloadDoc.Visible = true;
        }
        private void DownloadDoc_Click(object sender, EventArgs e)
        {
            string pdfPath = Application.StartupPath + @"\Resources\PixelStudio_Documentation.pdf";
            if (System.IO.File.Exists(pdfPath))
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                {
                    FileName = pdfPath,
                    UseShellExecute = true
                });
            }
            else
            {
                MessageBox.Show($"Documentation file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
