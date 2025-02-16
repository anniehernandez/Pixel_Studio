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
            panel5 = new Panel();
            Save = new Button();
            ZoomOut = new Button();
            ZoomIn = new Button();
            Open = new Button();
            panel6 = new Panel();
            ImageDisplay = new PictureBox();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ImageDisplay).BeginInit();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(30, 34, 52);
            panel5.Controls.Add(Save);
            panel5.Controls.Add(ZoomOut);
            panel5.Controls.Add(ZoomIn);
            panel5.Controls.Add(Open);
            panel5.Controls.Add(panel6);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(730, 30);
            panel5.TabIndex = 3;
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
            // ImageDisplay
            // 
            ImageDisplay.BackColor = Color.FromArgb(36, 41, 62);
            ImageDisplay.Dock = DockStyle.Fill;
            ImageDisplay.Image = Properties.Resources.pic_example;
            ImageDisplay.Location = new Point(0, 30);
            ImageDisplay.Name = "ImageDisplay";
            ImageDisplay.Size = new Size(730, 523);
            ImageDisplay.SizeMode = PictureBoxSizeMode.Zoom;
            ImageDisplay.TabIndex = 4;
            ImageDisplay.TabStop = false;
            // 
            // ImageEditing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 41, 62);
            Controls.Add(ImageDisplay);
            Controls.Add(panel5);
            Name = "ImageEditing";
            Size = new Size(730, 553);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ImageDisplay).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel5;
        private Button ZoomOut;
        private Button ZoomIn;
        private Button Open;
        private Panel panel6;
        private PictureBox ImageDisplay;
        private Button Save;
    }
}
