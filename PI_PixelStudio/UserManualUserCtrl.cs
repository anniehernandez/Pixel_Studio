using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            Intro.Text = "Welcome to PixelStudio! Feeling a little lost? Let's start and go over out main window:";
            SectionPicture.Image = Image.FromFile("C://Users//luish//source//repos//PI_PixelStudio//PI_PixelStudio//Resources//UserManual.png");
            ContentRichBox.Text = @"We can divide this window into 3 panels.";
                Bold(ContentRichBox, "\n\n1⭐"); Regular(ContentRichBox, "Window Border.");
                Bold(ContentRichBox, "\n2⭐"); Regular(ContentRichBox, "Menu.");
                Bold(ContentRichBox, "\n3⭐"); Regular(ContentRichBox, "Main Panel.");

                Bold(ContentRichBox, "\n\n1⭐"); Regular(ContentRichBox, "Window Border: Contains the(?) Help, [-] Minimize, [□] Maximize, and[x] Exit Buttons in that respective order from left to right.");
                Bold(ContentRichBox, "\r\n2⭐"); Regular(ContentRichBox, "Menu: Contains all the different modes of our application 1) Effects, 2) Filters, and 3) Camera.In the menu at the top you can find more about each specific mode.");
                Bold(ContentRichBox, "\r\n3⭐"); Regular(ContentRichBox, "Main Panel: This Panel will cointain the actual workspace of the application.");
        }

        private void Bold(RichTextBox richTextBox, string text)
        {
            int startSelection = richTextBox.TextLength;

            richTextBox.AppendText(text); 
            richTextBox.Select(startSelection, text.Length);

            //MessageBox.Show("Seleccion:" + startSelection + "Text.len" + text.Length, "Info", MessageBoxButtons.OK, MessageBoxIcon.Question);

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
            SectionNameLabel.Text = "Menu";
            Intro.Text = "Welcome to PixelStudio! Feeling a little lost? Let's start and go over out main window:";
            ContentRichBox.Text = @"We can divide this window into 3 panels.";
                Bold(ContentRichBox, "\n\n1⭐"); Regular(ContentRichBox, "Window Border.");
                Bold(ContentRichBox, "\n2⭐"); Regular(ContentRichBox, "Menu.");
                Bold(ContentRichBox, "\n3⭐"); Regular(ContentRichBox, "Main Panel.");

                Bold(ContentRichBox, "\n\n1⭐"); Regular(ContentRichBox, "Window Border: Contains the(?) Help, [-] Minimize, [□] Maximize, and[x] Exit Buttons in that respective order from left to right.");
                Bold(ContentRichBox, "\r\n2⭐"); Regular(ContentRichBox, "Menu: Contains all the different modes of our application 1) Effects, 2) Filters, and 3) Camera.In the menu at the top you can find more about each specific mode.");
                Bold(ContentRichBox, "\r\n3⭐"); Regular(ContentRichBox, "Main Panel: This Panel will cointain the actual workspace of the application.");
        }

    }
}
