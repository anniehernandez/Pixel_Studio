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
    public partial class ProgressBarForm : Form
    {
        public ProgressBarForm()
        {
            InitializeComponent();
        }
        public void UpdateProgress(int percent)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<int>(UpdateProgress), percent);
            }   
            else
            {
                ProgressBar.Value = percent;
                ProgressLabel.Text = $"Saving... {percent}%";
                ProgressLabel.Refresh();
            }
        }
        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
