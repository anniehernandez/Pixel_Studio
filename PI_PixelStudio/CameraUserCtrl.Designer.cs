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
            panel2 = new Panel();
            SelectCamera = new ComboBox();
            OpenCloseCamera = new Button();
            CameraImagePanel = new Panel();
            CameraImage = new PictureBox();
            CameraSettings = new Panel();
            HexadecimalTextBox = new TextBox();
            bTextBox = new TextBox();
            aTextBox = new TextBox();
            LTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ColorDisplay = new PictureBox();
            CaptureButton = new Button();
            label4 = new Label();
            QTextBox = new TextBox();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            CameraImagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CameraImage).BeginInit();
            CameraSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ColorDisplay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 34, 52);
            panel2.Controls.Add(SelectCamera);
            panel2.Controls.Add(OpenCloseCamera);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.RightToLeft = RightToLeft.No;
            panel2.Size = new Size(718, 30);
            panel2.TabIndex = 0;
            // 
            // SelectCamera
            // 
            SelectCamera.BackColor = Color.FromArgb(36, 41, 62);
            SelectCamera.Dock = DockStyle.Left;
            SelectCamera.FlatStyle = FlatStyle.Flat;
            SelectCamera.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SelectCamera.ForeColor = Color.White;
            SelectCamera.FormattingEnabled = true;
            SelectCamera.Location = new Point(30, 0);
            SelectCamera.Name = "SelectCamera";
            SelectCamera.Size = new Size(298, 28);
            SelectCamera.TabIndex = 5;
            SelectCamera.Text = "Select Camera";
            // 
            // OpenCloseCamera
            // 
            OpenCloseCamera.Dock = DockStyle.Left;
            OpenCloseCamera.FlatAppearance.BorderSize = 0;
            OpenCloseCamera.FlatStyle = FlatStyle.Flat;
            OpenCloseCamera.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OpenCloseCamera.ForeColor = Color.White;
            OpenCloseCamera.Image = Properties.Resources.open_camera;
            OpenCloseCamera.ImageAlign = ContentAlignment.TopCenter;
            OpenCloseCamera.Location = new Point(0, 0);
            OpenCloseCamera.Name = "OpenCloseCamera";
            OpenCloseCamera.Size = new Size(30, 30);
            OpenCloseCamera.TabIndex = 4;
            OpenCloseCamera.UseVisualStyleBackColor = true;
            OpenCloseCamera.Click += OpenCamera_Click;
            // 
            // CameraImagePanel
            // 
            CameraImagePanel.Controls.Add(CameraImage);
            CameraImagePanel.Dock = DockStyle.Fill;
            CameraImagePanel.Location = new Point(0, 30);
            CameraImagePanel.Name = "CameraImagePanel";
            CameraImagePanel.Size = new Size(718, 508);
            CameraImagePanel.TabIndex = 1;
            // 
            // CameraImage
            // 
            CameraImage.Dock = DockStyle.Fill;
            CameraImage.Image = Properties.Resources.pic_example;
            CameraImage.Location = new Point(0, 0);
            CameraImage.Name = "CameraImage";
            CameraImage.Size = new Size(718, 508);
            CameraImage.SizeMode = PictureBoxSizeMode.Zoom;
            CameraImage.TabIndex = 0;
            CameraImage.TabStop = false;
            // 
            // CameraSettings
            // 
            CameraSettings.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CameraSettings.BackColor = Color.FromArgb(36, 41, 62);
            CameraSettings.Controls.Add(CameraImagePanel);
            CameraSettings.Controls.Add(panel2);
            CameraSettings.Location = new Point(35, 63);
            CameraSettings.Name = "CameraSettings";
            CameraSettings.Size = new Size(718, 538);
            CameraSettings.TabIndex = 0;
            // 
            // HexadecimalTextBox
            // 
            HexadecimalTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            HexadecimalTextBox.BackColor = Color.FromArgb(36, 41, 62);
            HexadecimalTextBox.BorderStyle = BorderStyle.None;
            HexadecimalTextBox.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Bold);
            HexadecimalTextBox.ForeColor = Color.White;
            HexadecimalTextBox.Location = new Point(786, 179);
            HexadecimalTextBox.Multiline = true;
            HexadecimalTextBox.Name = "HexadecimalTextBox";
            HexadecimalTextBox.ReadOnly = true;
            HexadecimalTextBox.Size = new Size(198, 27);
            HexadecimalTextBox.TabIndex = 0;
            HexadecimalTextBox.Text = "#000000";
            HexadecimalTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // bTextBox
            // 
            bTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bTextBox.BackColor = Color.FromArgb(36, 41, 62);
            bTextBox.BorderStyle = BorderStyle.None;
            bTextBox.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Bold);
            bTextBox.ForeColor = Color.White;
            bTextBox.Location = new Point(817, 278);
            bTextBox.Multiline = true;
            bTextBox.Name = "bTextBox";
            bTextBox.ReadOnly = true;
            bTextBox.Size = new Size(167, 27);
            bTextBox.TabIndex = 1;
            bTextBox.Text = "b";
            bTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // aTextBox
            // 
            aTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            aTextBox.BackColor = Color.FromArgb(36, 41, 62);
            aTextBox.BorderStyle = BorderStyle.None;
            aTextBox.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Bold);
            aTextBox.ForeColor = Color.White;
            aTextBox.Location = new Point(817, 245);
            aTextBox.Multiline = true;
            aTextBox.Name = "aTextBox";
            aTextBox.ReadOnly = true;
            aTextBox.Size = new Size(167, 27);
            aTextBox.TabIndex = 2;
            aTextBox.Text = "a";
            aTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // LTextBox
            // 
            LTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LTextBox.BackColor = Color.FromArgb(36, 41, 62);
            LTextBox.BorderStyle = BorderStyle.None;
            LTextBox.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Bold);
            LTextBox.ForeColor = Color.White;
            LTextBox.Location = new Point(817, 212);
            LTextBox.Multiline = true;
            LTextBox.Name = "LTextBox";
            LTextBox.ReadOnly = true;
            LTextBox.Size = new Size(167, 27);
            LTextBox.TabIndex = 3;
            LTextBox.Text = "L";
            LTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(784, 214);
            label1.Name = "label1";
            label1.Size = new Size(25, 25);
            label1.TabIndex = 4;
            label1.Text = "L:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(785, 247);
            label2.Name = "label2";
            label2.Size = new Size(26, 25);
            label2.TabIndex = 5;
            label2.Text = "a:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(784, 280);
            label3.Name = "label3";
            label3.Size = new Size(27, 25);
            label3.TabIndex = 6;
            label3.Text = "b:";
            // 
            // ColorDisplay
            // 
            ColorDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ColorDisplay.BackColor = Color.FromArgb(36, 41, 62);
            ColorDisplay.BackgroundImageLayout = ImageLayout.Zoom;
            ColorDisplay.Location = new Point(786, 63);
            ColorDisplay.Name = "ColorDisplay";
            ColorDisplay.Padding = new Padding(5);
            ColorDisplay.Size = new Size(200, 100);
            ColorDisplay.SizeMode = PictureBoxSizeMode.Zoom;
            ColorDisplay.TabIndex = 7;
            ColorDisplay.TabStop = false;
            // 
            // CaptureButton
            // 
            CaptureButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CaptureButton.BackColor = Color.FromArgb(30, 34, 52);
            CaptureButton.FlatAppearance.BorderSize = 0;
            CaptureButton.FlatStyle = FlatStyle.Flat;
            CaptureButton.Font = new Font("Yu Gothic UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CaptureButton.ForeColor = Color.White;
            CaptureButton.ImageAlign = ContentAlignment.MiddleRight;
            CaptureButton.Location = new Point(784, 570);
            CaptureButton.Name = "CaptureButton";
            CaptureButton.Size = new Size(200, 31);
            CaptureButton.TabIndex = 6;
            CaptureButton.Text = "Capture";
            CaptureButton.UseVisualStyleBackColor = false;
            CaptureButton.Click += CaptureButton_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(784, 313);
            label4.Name = "label4";
            label4.Size = new Size(30, 25);
            label4.TabIndex = 10;
            label4.Text = "Q:";
            // 
            // QTextBox
            // 
            QTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            QTextBox.BackColor = Color.FromArgb(36, 41, 62);
            QTextBox.BorderStyle = BorderStyle.None;
            QTextBox.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Bold);
            QTextBox.ForeColor = Color.White;
            QTextBox.Location = new Point(817, 311);
            QTextBox.Multiline = true;
            QTextBox.Name = "QTextBox";
            QTextBox.ReadOnly = true;
            QTextBox.Size = new Size(167, 27);
            QTextBox.TabIndex = 9;
            QTextBox.Text = "Quadrant";
            QTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackColor = Color.FromArgb(36, 41, 62);
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.ErrorImage = null;
            pictureBox1.Location = new Point(784, 354);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Padding = new Padding(5);
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // CameraUserCtrl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            Controls.Add(label4);
            Controls.Add(QTextBox);
            Controls.Add(pictureBox1);
            Controls.Add(ColorDisplay);
            Controls.Add(CaptureButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LTextBox);
            Controls.Add(aTextBox);
            Controls.Add(bTextBox);
            Controls.Add(HexadecimalTextBox);
            Controls.Add(CameraSettings);
            Name = "CameraUserCtrl";
            Size = new Size(1020, 664);
            panel2.ResumeLayout(false);
            CameraImagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CameraImage).EndInit();
            CameraSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ColorDisplay).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private ComboBox SelectCamera;
        private Button OpenCloseCamera;
        private Panel CameraImagePanel;
        private PictureBox CameraImage;
        private Panel CameraSettings;
        private TextBox HexadecimalTextBox;
        private TextBox bTextBox;
        private TextBox aTextBox;
        private TextBox LTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox ColorDisplay;
        private Button CaptureButton;
        private Label label4;
        private TextBox QTextBox;
        private PictureBox pictureBox1;
    }
}
