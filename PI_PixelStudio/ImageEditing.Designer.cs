namespace PI_PixelStudio
{
    partial class ImageEditing
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            EditingSpace = new Panel();
            Display = new PictureBox();
            ControlBar = new Panel();
            Save = new Button();
            ZoomOut = new Button();
            ZoomIn = new Button();
            Open = new Button();
            panel6 = new Panel();
            EditingSpace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Display).BeginInit();
            ControlBar.SuspendLayout();
            SuspendLayout();
            // 
            // EditingSpace
            // 
            EditingSpace.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EditingSpace.BackColor = Color.FromArgb(36, 41, 62);
            EditingSpace.Controls.Add(Display);
            EditingSpace.Controls.Add(ControlBar);
            EditingSpace.Location = new Point(0, 0);
            EditingSpace.Name = "EditingSpace";
            EditingSpace.Size = new Size(730, 553);
            EditingSpace.TabIndex = 30;
            // 
            // Display
            // 
            Display.Dock = DockStyle.Fill;
            Display.Image = Properties.Resources.pic_example;
            Display.Location = new Point(0, 30);
            Display.Name = "Display";
            Display.Size = new Size(730, 523);
            Display.SizeMode = PictureBoxSizeMode.Zoom;
            Display.TabIndex = 10;
            Display.TabStop = false;
            // 
            // ControlBar
            // 
            ControlBar.BackColor = Color.FromArgb(30, 34, 52);
            ControlBar.Controls.Add(Save);
            ControlBar.Controls.Add(ZoomOut);
            ControlBar.Controls.Add(ZoomIn);
            ControlBar.Controls.Add(Open);
            ControlBar.Controls.Add(panel6);
            ControlBar.Dock = DockStyle.Top;
            ControlBar.Location = new Point(0, 0);
            ControlBar.Name = "ControlBar";
            ControlBar.Size = new Size(730, 30);
            ControlBar.TabIndex = 5;
            // 
            // Save
            // 
            Save.Dock = DockStyle.Left;
            Save.FlatAppearance.BorderSize = 0;
            Save.FlatStyle = FlatStyle.Flat;
            Save.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Save.ForeColor = Color.White;
            Save.Image = Properties.Resources.save;
            Save.ImageAlign = ContentAlignment.TopCenter;
            Save.Location = new Point(90, 0);
            Save.Name = "Save";
            Save.Size = new Size(30, 30);
            Save.TabIndex = 7;
            Save.UseVisualStyleBackColor = true;
            // 
            // ZoomOut
            // 
            ZoomOut.Dock = DockStyle.Left;
            ZoomOut.FlatAppearance.BorderSize = 0;
            ZoomOut.FlatStyle = FlatStyle.Flat;
            ZoomOut.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ZoomOut.ForeColor = Color.White;
            ZoomOut.Image = Properties.Resources.eva_minimize_outline;
            ZoomOut.ImageAlign = ContentAlignment.TopCenter;
            ZoomOut.Location = new Point(60, 0);
            ZoomOut.Name = "ZoomOut";
            ZoomOut.Size = new Size(30, 30);
            ZoomOut.TabIndex = 6;
            ZoomOut.UseVisualStyleBackColor = true;
            // 
            // ZoomIn
            // 
            ZoomIn.Dock = DockStyle.Left;
            ZoomIn.FlatAppearance.BorderSize = 0;
            ZoomIn.FlatStyle = FlatStyle.Flat;
            ZoomIn.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ZoomIn.ForeColor = Color.White;
            ZoomIn.Image = Properties.Resources.eva_maximize_outline;
            ZoomIn.ImageAlign = ContentAlignment.TopCenter;
            ZoomIn.Location = new Point(30, 0);
            ZoomIn.Name = "ZoomIn";
            ZoomIn.Size = new Size(30, 30);
            ZoomIn.TabIndex = 5;
            ZoomIn.UseVisualStyleBackColor = true;
            // 
            // Open
            // 
            Open.Dock = DockStyle.Left;
            Open.FlatAppearance.BorderSize = 0;
            Open.FlatStyle = FlatStyle.Flat;
            Open.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Open.ForeColor = Color.White;
            Open.Image = Properties.Resources.open_file;
            Open.ImageAlign = ContentAlignment.TopCenter;
            Open.Location = new Point(0, 0);
            Open.Name = "Open";
            Open.Size = new Size(30, 30);
            Open.TabIndex = 4;
            Open.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.Location = new Point(46, 708);
            panel6.Name = "panel6";
            panel6.Size = new Size(200, 100);
            panel6.TabIndex = 3;
            // 
            // ImageEditing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            Controls.Add(EditingSpace);
            Name = "ImageEditing";
            Size = new Size(730, 553);
            EditingSpace.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Display).EndInit();
            ControlBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel EditingSpace;
        private PictureBox Display;
        private Panel ControlBar;
        private Button Save;
        private Button ZoomOut;
        private Button ZoomIn;
        private Button Open;
        private Panel panel6;
    }
}
