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
            Hystogram4 = new Panel();
            Hystogram_B = new PictureBox();
            Hystogram3 = new Panel();
            Hystogram_G = new PictureBox();
            Hystogram2 = new Panel();
            Hystogram_R = new PictureBox();
            panel10 = new Panel();
            panel11 = new Panel();
            Hystogram1 = new Panel();
            Hystogram_RGB = new PictureBox();
            EditingSpace = new Panel();
            Display = new PictureBox();
            ControlBar = new Panel();
            Save = new Button();
            ZoomOut = new Button();
            ZoomIn = new Button();
            Open = new Button();
            panel6 = new Panel();
            Hystogram4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Hystogram_B).BeginInit();
            Hystogram3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Hystogram_G).BeginInit();
            Hystogram2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Hystogram_R).BeginInit();
            Hystogram1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Hystogram_RGB).BeginInit();
            EditingSpace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Display).BeginInit();
            ControlBar.SuspendLayout();
            SuspendLayout();
            // 
            // Hystogram4
            // 
            Hystogram4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Hystogram4.BackColor = Color.FromArgb(36, 41, 62);
            Hystogram4.Controls.Add(Hystogram_B);
            Hystogram4.Location = new Point(934, 169);
            Hystogram4.Name = "Hystogram4";
            Hystogram4.Size = new Size(131, 131);
            Hystogram4.TabIndex = 30;
            Hystogram4.Paint += Hystogram4_Paint;
            // 
            // Hystogram_B
            // 
            Hystogram_B.Location = new Point(5, 5);
            Hystogram_B.Name = "Hystogram_B";
            Hystogram_B.Size = new Size(121, 121);
            Hystogram_B.TabIndex = 34;
            Hystogram_B.TabStop = false;
            // 
            // Hystogram3
            // 
            Hystogram3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Hystogram3.BackColor = Color.FromArgb(36, 41, 62);
            Hystogram3.Controls.Add(Hystogram_G);
            Hystogram3.Location = new Point(799, 169);
            Hystogram3.Name = "Hystogram3";
            Hystogram3.Size = new Size(131, 131);
            Hystogram3.TabIndex = 31;
            Hystogram3.Paint += Hystogram3_Paint;
            // 
            // Hystogram_G
            // 
            Hystogram_G.Location = new Point(5, 5);
            Hystogram_G.Name = "Hystogram_G";
            Hystogram_G.Size = new Size(121, 121);
            Hystogram_G.TabIndex = 34;
            Hystogram_G.TabStop = false;
            // 
            // Hystogram2
            // 
            Hystogram2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Hystogram2.BackColor = Color.FromArgb(36, 41, 62);
            Hystogram2.Controls.Add(Hystogram_R);
            Hystogram2.Controls.Add(panel10);
            Hystogram2.Controls.Add(panel11);
            Hystogram2.Location = new Point(934, 33);
            Hystogram2.Name = "Hystogram2";
            Hystogram2.Size = new Size(131, 131);
            Hystogram2.TabIndex = 32;
            Hystogram2.Paint += Hystogram2_Paint;
            // 
            // Hystogram_R
            // 
            Hystogram_R.Location = new Point(5, 5);
            Hystogram_R.Name = "Hystogram_R";
            Hystogram_R.Size = new Size(121, 121);
            Hystogram_R.TabIndex = 33;
            Hystogram_R.TabStop = false;
            // 
            // panel10
            // 
            panel10.Location = new Point(5, 137);
            panel10.Name = "panel10";
            panel10.Size = new Size(131, 131);
            panel10.TabIndex = 7;
            // 
            // panel11
            // 
            panel11.Location = new Point(-130, 137);
            panel11.Name = "panel11";
            panel11.Size = new Size(131, 131);
            panel11.TabIndex = 6;
            // 
            // Hystogram1
            // 
            Hystogram1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Hystogram1.BackColor = Color.FromArgb(36, 41, 62);
            Hystogram1.Controls.Add(Hystogram_RGB);
            Hystogram1.Location = new Point(799, 33);
            Hystogram1.Name = "Hystogram1";
            Hystogram1.Size = new Size(131, 131);
            Hystogram1.TabIndex = 33;
            Hystogram1.Paint += Hystogram1_Paint;
            // 
            // Hystogram_RGB
            // 
            Hystogram_RGB.Location = new Point(5, 5);
            Hystogram_RGB.Name = "Hystogram_RGB";
            Hystogram_RGB.Size = new Size(121, 121);
            Hystogram_RGB.TabIndex = 32;
            Hystogram_RGB.TabStop = false;
            // 
            // EditingSpace
            // 
            EditingSpace.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EditingSpace.BackColor = Color.FromArgb(36, 41, 62);
            EditingSpace.Controls.Add(Display);
            EditingSpace.Controls.Add(ControlBar);
            EditingSpace.Location = new Point(35, 33);
            EditingSpace.Name = "EditingSpace";
            EditingSpace.Size = new Size(730, 553);
            EditingSpace.TabIndex = 34;
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
            Open.Click += Open_Click;
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
            Controls.Add(Hystogram4);
            Controls.Add(Hystogram3);
            Controls.Add(Hystogram2);
            Controls.Add(Hystogram1);
            Controls.Add(EditingSpace);
            Name = "ImageEditing";
            Size = new Size(1100, 618);
            Hystogram4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Hystogram_B).EndInit();
            Hystogram3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Hystogram_G).EndInit();
            Hystogram2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Hystogram_R).EndInit();
            Hystogram1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Hystogram_RGB).EndInit();
            EditingSpace.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Display).EndInit();
            ControlBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel Hystogram4;
        private PictureBox Hystogram_B;
        private Panel Hystogram3;
        private PictureBox Hystogram_G;
        private Panel Hystogram2;
        private PictureBox Hystogram_R;
        private Panel panel10;
        private Panel panel11;
        private Panel Hystogram1;
        private PictureBox Hystogram_RGB;
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
