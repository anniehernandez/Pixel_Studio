namespace PI_PixelStudio
{
    partial class UserManualUserCtrl
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
            UserManualMenu = new MenuStrip();
            MenuStrip = new ToolStripMenuItem();
            ImageStrip = new ToolStripMenuItem();
            VideoStrip = new ToolStripMenuItem();
            CameraStrip = new ToolStripMenuItem();
            MoreStrip = new ToolStripMenuItem();
            UserManualInfo = new Panel();
            DownloadDoc = new Button();
            SectionPicture = new PictureBox();
            ContentRichBox = new RichTextBox();
            SectionNameLabel = new Label();
            UserManualMenu.SuspendLayout();
            UserManualInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SectionPicture).BeginInit();
            SuspendLayout();
            // 
            // UserManualMenu
            // 
            UserManualMenu.BackColor = Color.FromArgb(36, 41, 62);
            UserManualMenu.Font = new Font("Yu Gothic UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserManualMenu.Items.AddRange(new ToolStripItem[] { MenuStrip, ImageStrip, VideoStrip, CameraStrip, MoreStrip });
            UserManualMenu.Location = new Point(0, 0);
            UserManualMenu.Name = "UserManualMenu";
            UserManualMenu.Size = new Size(1020, 28);
            UserManualMenu.TabIndex = 4;
            UserManualMenu.Text = "UserManualMenu";
            // 
            // MenuStrip
            // 
            MenuStrip.Checked = true;
            MenuStrip.CheckState = CheckState.Checked;
            MenuStrip.ForeColor = Color.White;
            MenuStrip.Name = "MenuStrip";
            MenuStrip.Size = new Size(61, 24);
            MenuStrip.Text = "Menu";
            MenuStrip.Click += MenuItem_Click;
            // 
            // ImageStrip
            // 
            ImageStrip.ForeColor = Color.White;
            ImageStrip.Name = "ImageStrip";
            ImageStrip.Size = new Size(63, 24);
            ImageStrip.Text = "Image";
            ImageStrip.Click += ImageStrip_Click;
            // 
            // VideoStrip
            // 
            VideoStrip.ForeColor = Color.White;
            VideoStrip.Name = "VideoStrip";
            VideoStrip.Size = new Size(61, 24);
            VideoStrip.Text = "Video";
            VideoStrip.Click += VideoStrip_Click;
            // 
            // CameraStrip
            // 
            CameraStrip.ForeColor = Color.White;
            CameraStrip.Name = "CameraStrip";
            CameraStrip.Size = new Size(73, 24);
            CameraStrip.Text = "Camera";
            CameraStrip.Click += CameraStrip_Click;
            // 
            // MoreStrip
            // 
            MoreStrip.ForeColor = Color.White;
            MoreStrip.Name = "MoreStrip";
            MoreStrip.Size = new Size(58, 24);
            MoreStrip.Text = "More";
            MoreStrip.Click += MoreStrip_Click;
            // 
            // UserManualInfo
            // 
            UserManualInfo.Controls.Add(DownloadDoc);
            UserManualInfo.Controls.Add(SectionPicture);
            UserManualInfo.Controls.Add(ContentRichBox);
            UserManualInfo.Controls.Add(SectionNameLabel);
            UserManualInfo.Dock = DockStyle.Fill;
            UserManualInfo.Location = new Point(0, 28);
            UserManualInfo.Name = "UserManualInfo";
            UserManualInfo.Size = new Size(1020, 792);
            UserManualInfo.TabIndex = 5;
            // 
            // DownloadDoc
            // 
            DownloadDoc.Anchor = AnchorStyles.Top;
            DownloadDoc.BackColor = Color.FromArgb(30, 34, 52);
            DownloadDoc.FlatAppearance.BorderSize = 0;
            DownloadDoc.FlatStyle = FlatStyle.Flat;
            DownloadDoc.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DownloadDoc.ForeColor = Color.White;
            DownloadDoc.ImageAlign = ContentAlignment.MiddleRight;
            DownloadDoc.Location = new Point(460, 140);
            DownloadDoc.Name = "DownloadDoc";
            DownloadDoc.Size = new Size(100, 28);
            DownloadDoc.TabIndex = 8;
            DownloadDoc.Text = "Open File";
            DownloadDoc.UseMnemonic = false;
            DownloadDoc.UseVisualStyleBackColor = false;
            DownloadDoc.Visible = false;
            DownloadDoc.Click += DownloadDoc_Click;
            // 
            // SectionPicture
            // 
            SectionPicture.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SectionPicture.Image = Properties.Resources._4;
            SectionPicture.Location = new Point(210, 357);
            SectionPicture.Name = "SectionPicture";
            SectionPicture.Size = new Size(600, 400);
            SectionPicture.SizeMode = PictureBoxSizeMode.Zoom;
            SectionPicture.TabIndex = 5;
            SectionPicture.TabStop = false;
            // 
            // ContentRichBox
            // 
            ContentRichBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ContentRichBox.BackColor = Color.FromArgb(46, 51, 73);
            ContentRichBox.BorderStyle = BorderStyle.None;
            ContentRichBox.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ContentRichBox.ForeColor = Color.White;
            ContentRichBox.Location = new Point(35, 58);
            ContentRichBox.Name = "ContentRichBox";
            ContentRichBox.ReadOnly = true;
            ContentRichBox.Size = new Size(950, 280);
            ContentRichBox.TabIndex = 3;
            ContentRichBox.Text = "";
            // 
            // SectionNameLabel
            // 
            SectionNameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SectionNameLabel.AutoSize = true;
            SectionNameLabel.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SectionNameLabel.ForeColor = Color.FromArgb(113, 109, 214);
            SectionNameLabel.Location = new Point(35, 30);
            SectionNameLabel.Name = "SectionNameLabel";
            SectionNameLabel.Size = new Size(132, 25);
            SectionNameLabel.TabIndex = 2;
            SectionNameLabel.Text = "Section Name";
            // 
            // UserManualUserCtrl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            Controls.Add(UserManualInfo);
            Controls.Add(UserManualMenu);
            Name = "UserManualUserCtrl";
            Size = new Size(1020, 820);
            UserManualMenu.ResumeLayout(false);
            UserManualMenu.PerformLayout();
            UserManualInfo.ResumeLayout(false);
            UserManualInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SectionPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip UserManualMenu;
        private ToolStripMenuItem MenuStrip;
        private ToolStripMenuItem ImageStrip;
        private ToolStripMenuItem VideoStrip;
        private ToolStripMenuItem CameraStrip;
        private Panel UserManualInfo;
        private Label SectionNameLabel;
        private RichTextBox ContentRichBox;
        private PictureBox SectionPicture;
        private ToolStripMenuItem MoreStrip;
        private Button DownloadDoc;
    }
}
