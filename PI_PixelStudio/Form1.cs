namespace PI_PixelStudio{
    public partial class PixelStudio : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragWindowPoint;
        public PixelStudio()
        {
            InitializeComponent();

            NavigationPanel.MouseDown += Window_MouseDown;
            NavigationPanel.MouseMove += Window_MouseMove;
            NavigationPanel.MouseUp += Window_MouseUp;

            ActiveBar.Visible = false;
        }
        //WINDOW DRAGGING
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
        //WINDOW BASIC BUTTONS
        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Maximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
        }
        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void Questions_Click(object sender, EventArgs e)
        {
            LoadUserCtrl(new UserManualUserCtrl());
        }

        //SECTION LOAD 
        private void LoadUserCtrl(UserControl UserCtrl)
        {
            ContainerPanel.Controls.Clear();//Clears the Previous UserCtrl

            UserCtrl.Dock = DockStyle.Fill;//Fills it in the Cointainer Panel
            ContainerPanel.Controls.Add(UserCtrl);//Adds the UserCtrl
        }

        //MENU BUTTONS
        private void ImageButton_Click(object sender, EventArgs e)
        {
            LoadUserCtrl(new ImageUserCrtl());//Load Respective Panel  

            ActiveBar.Visible = true;
            ActiveBar.Height = ImageButton.Height;
            ActiveBar.Top = ImageButton.Top;
            ActiveBar.Left = ImageButton.Left;
        }
        private void VideoButton_Click(object sender, EventArgs e)
        {
            LoadUserCtrl(new VideoUserCtrl());//Load Respective Panel  

            ActiveBar.Visible = true;
            ActiveBar.Height = VideoButton.Height;
            ActiveBar.Top = VideoButton.Top;
            ActiveBar.Left = VideoButton.Left;
        }

        private void CameraButton_Click(object sender, EventArgs e)
        {
            LoadUserCtrl(new CameraUserCtrl());//Load Respective Panel  

            ActiveBar.Visible = true;
            ActiveBar.Height = CameraButton.Height;
            ActiveBar.Top = CameraButton.Top;
            ActiveBar.Left = CameraButton.Left;
        }
    }
}
