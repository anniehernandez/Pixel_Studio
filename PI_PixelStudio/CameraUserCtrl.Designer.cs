namespace PI_PixelStudio
{
    partial class CameraUserCtrl
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
            CameraSettings = new Panel();
            CameraImage = new Panel();
            panel2 = new Panel();
            button1 = new Button();
            SelectCamera = new ComboBox();
            Open = new Button();
            Hexadecimal = new TextBox();
            ColorName = new TextBox();
            CameraSettings.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // CameraSettings
            // 
            CameraSettings.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CameraSettings.BackColor = Color.FromArgb(36, 41, 62);
            CameraSettings.Controls.Add(CameraImage);
            CameraSettings.Controls.Add(panel2);
            CameraSettings.Location = new Point(100, 92);
            CameraSettings.Name = "CameraSettings";
            CameraSettings.Size = new Size(820, 474);
            CameraSettings.TabIndex = 0;
            // 
            // CameraImage
            // 
            CameraImage.Dock = DockStyle.Fill;
            CameraImage.Location = new Point(0, 30);
            CameraImage.Name = "CameraImage";
            CameraImage.Size = new Size(820, 444);
            CameraImage.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 34, 52);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(SelectCamera);
            panel2.Controls.Add(Open);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.RightToLeft = RightToLeft.No;
            panel2.Size = new Size(820, 30);
            panel2.TabIndex = 0;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Left;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = Properties.Resources.close_camera;
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(30, 0);
            button1.Name = "button1";
            button1.Size = new Size(30, 30);
            button1.TabIndex = 5;
            button1.UseVisualStyleBackColor = true;
            // 
            // SelectCamera
            // 
            SelectCamera.BackColor = Color.FromArgb(36, 41, 62);
            SelectCamera.FlatStyle = FlatStyle.Flat;
            SelectCamera.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SelectCamera.ForeColor = Color.White;
            SelectCamera.FormattingEnabled = true;
            SelectCamera.Location = new Point(62, 1);
            SelectCamera.Name = "SelectCamera";
            SelectCamera.Size = new Size(298, 28);
            SelectCamera.TabIndex = 6;
            SelectCamera.Text = "Select Camera";
            // 
            // Open
            // 
            Open.Dock = DockStyle.Left;
            Open.FlatAppearance.BorderSize = 0;
            Open.FlatStyle = FlatStyle.Flat;
            Open.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Open.ForeColor = Color.White;
            Open.Image = Properties.Resources.open_camera;
            Open.ImageAlign = ContentAlignment.TopCenter;
            Open.Location = new Point(0, 0);
            Open.Name = "Open";
            Open.Size = new Size(30, 30);
            Open.TabIndex = 4;
            Open.UseVisualStyleBackColor = true;
            Open.Click += Open_Click;
            // 
            // Hexadecimal
            // 
            Hexadecimal.BackColor = Color.FromArgb(36, 41, 62);
            Hexadecimal.BorderStyle = BorderStyle.None;
            Hexadecimal.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Bold);
            Hexadecimal.ForeColor = Color.White;
            Hexadecimal.Location = new Point(100, 59);
            Hexadecimal.Multiline = true;
            Hexadecimal.Name = "Hexadecimal";
            Hexadecimal.ReadOnly = true;
            Hexadecimal.Size = new Size(94, 27);
            Hexadecimal.TabIndex = 0;
            Hexadecimal.Text = "#000000";
            Hexadecimal.TextAlign = HorizontalAlignment.Center;
            // 
            // ColorName
            // 
            ColorName.BackColor = Color.FromArgb(36, 41, 62);
            ColorName.BorderStyle = BorderStyle.None;
            ColorName.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Bold);
            ColorName.ForeColor = Color.White;
            ColorName.Location = new Point(200, 59);
            ColorName.Multiline = true;
            ColorName.Name = "ColorName";
            ColorName.ReadOnly = true;
            ColorName.Size = new Size(198, 27);
            ColorName.TabIndex = 0;
            ColorName.Text = "Color";
            // 
            // CameraUserCtrl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            Controls.Add(ColorName);
            Controls.Add(Hexadecimal);
            Controls.Add(CameraSettings);
            Name = "CameraUserCtrl";
            Size = new Size(1020, 633);
            CameraSettings.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel CameraSettings;
        private Panel panel2;
        private Button Open;
        private TextBox Hexadecimal;
        private TextBox ColorName;
        private ComboBox SelectCamera;
        private Button button1;
        private Panel CameraImage;
    }
}
