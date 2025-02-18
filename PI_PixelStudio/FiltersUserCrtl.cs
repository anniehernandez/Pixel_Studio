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
            LoadUserCtrl(new ImageEditing());
            
            List<Filters> filters = new List<Filters>
            {
                new Filters("Filter 1", Properties.Resources.Picture, 0),
                new Filters("Filter 2", Properties.Resources.PixelStudio, 1),
                new Filters("Filter 3", Properties.Resources.Logo, 2)
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
                Size = new Size(140, 150),
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
                    break;
                case 1:
                    break;
            }
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
