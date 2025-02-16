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
            menuToolStripMenuItem = new ToolStripMenuItem();
            effectsToolStripMenuItem = new ToolStripMenuItem();
            filtersToolStripMenuItem = new ToolStripMenuItem();
            cameraToolStripMenuItem = new ToolStripMenuItem();
            UserManualInfo = new Panel();
            SectionPicture = new PictureBox();
            Intro = new TextBox();
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
            UserManualMenu.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, effectsToolStripMenuItem, filtersToolStripMenuItem, cameraToolStripMenuItem });
            UserManualMenu.Location = new Point(0, 0);
            UserManualMenu.Name = "UserManualMenu";
            UserManualMenu.Size = new Size(1020, 28);
            UserManualMenu.TabIndex = 4;
            UserManualMenu.Text = "UserManualMenu";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.Checked = true;
            menuToolStripMenuItem.CheckState = CheckState.Checked;
            menuToolStripMenuItem.ForeColor = Color.White;
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(58, 24);
            menuToolStripMenuItem.Text = "Menu";
            menuToolStripMenuItem.Click += MenuItem_Click;
            // 
            // effectsToolStripMenuItem
            // 
            effectsToolStripMenuItem.ForeColor = Color.White;
            effectsToolStripMenuItem.Name = "effectsToolStripMenuItem";
            effectsToolStripMenuItem.Size = new Size(64, 24);
            effectsToolStripMenuItem.Text = "Effects";
            effectsToolStripMenuItem.Click += EffectsItem_Click;
            // 
            // filtersToolStripMenuItem
            // 
            filtersToolStripMenuItem.ForeColor = Color.White;
            filtersToolStripMenuItem.Name = "filtersToolStripMenuItem";
            filtersToolStripMenuItem.Size = new Size(60, 24);
            filtersToolStripMenuItem.Text = "Filters";
            filtersToolStripMenuItem.Click += FiltersItem_Click;
            // 
            // cameraToolStripMenuItem
            // 
            cameraToolStripMenuItem.ForeColor = Color.White;
            cameraToolStripMenuItem.Name = "cameraToolStripMenuItem";
            cameraToolStripMenuItem.Size = new Size(72, 24);
            cameraToolStripMenuItem.Text = "Camera";
            cameraToolStripMenuItem.Click += CameraItem_Click;
            // 
            // UserManualInfo
            // 
            UserManualInfo.Controls.Add(SectionPicture);
            UserManualInfo.Controls.Add(Intro);
            UserManualInfo.Controls.Add(ContentRichBox);
            UserManualInfo.Controls.Add(SectionNameLabel);
            UserManualInfo.Dock = DockStyle.Fill;
            UserManualInfo.Location = new Point(0, 28);
            UserManualInfo.Name = "UserManualInfo";
            UserManualInfo.Size = new Size(1020, 792);
            UserManualInfo.TabIndex = 5;
            // 
            // SectionPicture
            // 
            SectionPicture.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SectionPicture.Image = Properties.Resources.Logo2;
            SectionPicture.Location = new Point(196, 84);
            SectionPicture.Name = "SectionPicture";
            SectionPicture.Size = new Size(610, 400);
            SectionPicture.SizeMode = PictureBoxSizeMode.Zoom;
            SectionPicture.TabIndex = 5;
            SectionPicture.TabStop = false;
            // 
            // Intro
            // 
            Intro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Intro.BackColor = Color.FromArgb(46, 51, 73);
            Intro.BorderStyle = BorderStyle.None;
            Intro.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Intro.ForeColor = Color.White;
            Intro.Location = new Point(35, 58);
            Intro.Name = "Intro";
            Intro.Size = new Size(950, 20);
            Intro.TabIndex = 4;
            // 
            // ContentRichBox
            // 
            ContentRichBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ContentRichBox.BackColor = Color.FromArgb(46, 51, 73);
            ContentRichBox.BorderStyle = BorderStyle.None;
            ContentRichBox.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ContentRichBox.ForeColor = Color.White;
            ContentRichBox.Location = new Point(35, 490);
            ContentRichBox.Name = "ContentRichBox";
            ContentRichBox.ReadOnly = true;
            ContentRichBox.Size = new Size(950, 266);
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
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem effectsToolStripMenuItem;
        private ToolStripMenuItem filtersToolStripMenuItem;
        private ToolStripMenuItem cameraToolStripMenuItem;
        private Panel UserManualInfo;
        private Label SectionNameLabel;
        private RichTextBox ContentRichBox;
        private PictureBox SectionPicture;
        private TextBox Intro;
    }
}
