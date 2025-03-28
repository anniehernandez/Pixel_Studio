using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;
using System.Windows.Forms;

namespace PI_PixelStudio
{
    public partial class FilterParamForm : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragWindowPoint;
        //private string filterValueText;
        public FilterParamForm()
        {
            InitializeComponent();

            NavigationPanel.MouseDown += Window_MouseDown;
            NavigationPanel.MouseMove += Window_MouseMove;
            NavigationPanel.MouseUp += Window_MouseUp;
        }
        public void SetWindow(string valueName, string valueDefault)
        {
            FilterValue.Text = valueDefault;
            ValueName.Text = valueName;
        }
        public int SetValueFilter()
        {
            string filterValue = FilterValue.Text;
            int value;

            if (int.TryParse(filterValue, out value))
            {
                return value;
            }
            else
            {
                return 0;
            }
        }

        private void Window_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                dragCursorPoint = Cursor.Position;
                dragWindowPoint = this.Location;
            }
        }
        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragWindowPoint, new Size(diff));
            }
        }
        private void Window_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        
        public event Action<int> OnApplyClicked; 
        private void Apply_Click(object sender, EventArgs e)
        {
            int value = SetValueFilter();
            OnApplyClicked?.Invoke(value); 
        }

    }
}
