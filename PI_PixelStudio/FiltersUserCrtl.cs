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
        public FiltersUserCrtl()
        {
            InitializeComponent();
            LoadFilters();
        }
        private void LoadFilters()
        {
            SectionLabel.Text = "Filters";
            FilterName.Text = "FilterName";
        }
        private void LoadUserCtrl(UserControl UserCrtl)
        {
            Workspace.Controls.Clear();
            UserCrtl.Dock = DockStyle.Fill;
            Workspace.Controls.Add(UserCrtl);

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
