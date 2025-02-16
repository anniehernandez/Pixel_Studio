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
    public partial class FiltersUserCrtl : UserControl
    {
        public FiltersUserCrtl()
        {
            InitializeComponent();
        }

        public void LoadUserCtrl(UserControl UserCtrl)
        {
            EditingSpace.Controls.Clear();

            UserCtrl.Dock = DockStyle.Fill;
            EditingSpace.Controls.Add(UserCtrl);
        }

        public void LoadSection(int Section)
        {
            if (Section == 1)
            {
                LoadEffects();
            }
            else
            {
                LoadFilters();
            }
        }
        private void LoadEffects()
        {
            SectionLabel.Text = "Effects";
            FilterName.Text = "Effect Name";
        }
        private void LoadFilters()
        {
            SectionLabel.Text = "Filters";
            FilterName.Text = "FilterName";
        }
        private void imageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadUserCtrl(new ImageEditing());
        }
        private void videoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadUserCtrl(new VideoEditing());
        }
    }
}
