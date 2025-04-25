namespace PI_PixelStudio
{
    partial class VideoUserCtrl
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
            TitlePanel = new Panel();
            SectionLabel = new Label();
            FiltersFlowPanel = new FlowLayoutPanel();
            FilterPanel = new Panel();
            FIlterPicture = new PictureBox();
            FilterName = new Label();
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
            ButtonControl = new TableLayoutPanel();
            Forward = new Button();
            Play_Pause = new Button();
            Restart = new Button();
            Backward = new Button();
            ControlBar = new Panel();
            Save = new Button();
            Open = new Button();
            panel6 = new Panel();
            FilterManagerPanel = new Panel();
            FilterValueTextBox = new TextBox();
            Apply = new Button();
            ValueName = new Label();
            panel2.SuspendLayout();
            TitlePanel.SuspendLayout();
            FiltersFlowPanel.SuspendLayout();
            FilterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FIlterPicture).BeginInit();
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
            ButtonControl.SuspendLayout();
            ControlBar.SuspendLayout();
            FilterManagerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(TitlePanel);
            panel2.Controls.Add(FiltersFlowPanel);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 646);
            panel2.Name = "panel2";
            panel2.Size = new Size(1100, 184);
            panel2.TabIndex = 36;
            // 
            // TitlePanel
            // 
            TitlePanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            TitlePanel.BackColor = Color.FromArgb(30, 34, 52);
            TitlePanel.Controls.Add(SectionLabel);
            TitlePanel.Dock = DockStyle.Top;
            TitlePanel.Location = new Point(0, 0);
            TitlePanel.Name = "TitlePanel";
            TitlePanel.Size = new Size(1100, 30);
            TitlePanel.TabIndex = 0;
            // 
            // SectionLabel
            // 
            SectionLabel.AutoSize = true;
            SectionLabel.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SectionLabel.ForeColor = Color.White;
            SectionLabel.Location = new Point(4, 4);
            SectionLabel.Name = "SectionLabel";
            SectionLabel.Size = new Size(54, 21);
            SectionLabel.TabIndex = 0;
            SectionLabel.Text = "Filters";
            // 
            // FiltersFlowPanel
            // 
            FiltersFlowPanel.AutoScroll = true;
            FiltersFlowPanel.Controls.Add(FilterPanel);
            FiltersFlowPanel.Dock = DockStyle.Bottom;
            FiltersFlowPanel.Location = new Point(0, 28);
            FiltersFlowPanel.Name = "FiltersFlowPanel";
            FiltersFlowPanel.Size = new Size(1100, 156);
            FiltersFlowPanel.TabIndex = 7;
            // 
            // FilterPanel
            // 
            FilterPanel.BackColor = Color.FromArgb(36, 41, 62);
            FilterPanel.Controls.Add(FIlterPicture);
            FilterPanel.Controls.Add(FilterName);
            FilterPanel.Location = new Point(3, 3);
            FilterPanel.Name = "FilterPanel";
            FilterPanel.Size = new Size(140, 153);
            FilterPanel.TabIndex = 8;
            // 
            // FIlterPicture
            // 
            FIlterPicture.Image = Properties.Resources.Logo;
            FIlterPicture.Location = new Point(12, 12);
            FIlterPicture.Name = "FIlterPicture";
            FIlterPicture.Size = new Size(117, 109);
            FIlterPicture.SizeMode = PictureBoxSizeMode.Zoom;
            FIlterPicture.TabIndex = 2;
            FIlterPicture.TabStop = false;
            // 
            // FilterName
            // 
            FilterName.AutoSize = true;
            FilterName.Enabled = false;
            FilterName.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FilterName.ForeColor = Color.White;
            FilterName.Location = new Point(32, 124);
            FilterName.Margin = new Padding(3);
            FilterName.Name = "FilterName";
            FilterName.Size = new Size(75, 17);
            FilterName.TabIndex = 0;
            FilterName.Text = "Filter Name";
            FilterName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Hystogram4
            // 
            Hystogram4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Hystogram4.BackColor = Color.FromArgb(36, 41, 62);
            Hystogram4.Controls.Add(Hystogram_B);
            Hystogram4.Location = new Point(935, 171);
            Hystogram4.Name = "Hystogram4";
            Hystogram4.Size = new Size(131, 131);
            Hystogram4.TabIndex = 31;
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
            Hystogram3.Location = new Point(800, 171);
            Hystogram3.Name = "Hystogram3";
            Hystogram3.Size = new Size(131, 131);
            Hystogram3.TabIndex = 32;
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
            Hystogram2.Location = new Point(935, 35);
            Hystogram2.Name = "Hystogram2";
            Hystogram2.Size = new Size(131, 131);
            Hystogram2.TabIndex = 33;
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
            Hystogram1.Location = new Point(800, 35);
            Hystogram1.Name = "Hystogram1";
            Hystogram1.Size = new Size(131, 131);
            Hystogram1.TabIndex = 34;
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
            EditingSpace.Controls.Add(ButtonControl);
            EditingSpace.Controls.Add(ControlBar);
            EditingSpace.Location = new Point(35, 35);
            EditingSpace.Name = "EditingSpace";
            EditingSpace.Size = new Size(730, 581);
            EditingSpace.TabIndex = 35;
            // 
            // Display
            // 
            Display.Dock = DockStyle.Fill;
            Display.Image = Properties.Resources.pic_example;
            Display.Location = new Point(0, 30);
            Display.Name = "Display";
            Display.Size = new Size(730, 515);
            Display.SizeMode = PictureBoxSizeMode.Zoom;
            Display.TabIndex = 10;
            Display.TabStop = false;
            // 
            // ButtonControl
            // 
            ButtonControl.BackColor = Color.FromArgb(30, 34, 52);
            ButtonControl.ColumnCount = 6;
            ButtonControl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38F));
            ButtonControl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8F));
            ButtonControl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8F));
            ButtonControl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8F));
            ButtonControl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8F));
            ButtonControl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38F));
            ButtonControl.Controls.Add(Forward, 4, 0);
            ButtonControl.Controls.Add(Play_Pause, 3, 0);
            ButtonControl.Controls.Add(Restart, 2, 0);
            ButtonControl.Controls.Add(Backward, 1, 0);
            ButtonControl.Dock = DockStyle.Bottom;
            ButtonControl.Location = new Point(0, 545);
            ButtonControl.Name = "ButtonControl";
            ButtonControl.RowCount = 1;
            ButtonControl.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            ButtonControl.Size = new Size(730, 36);
            ButtonControl.TabIndex = 9;
            // 
            // Forward
            // 
            Forward.BackColor = Color.FromArgb(36, 41, 62);
            Forward.Dock = DockStyle.Fill;
            Forward.Enabled = false;
            Forward.FlatAppearance.BorderSize = 0;
            Forward.FlatStyle = FlatStyle.Flat;
            Forward.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Forward.ForeColor = Color.White;
            Forward.Image = Properties.Resources.forward;
            Forward.ImageAlign = ContentAlignment.TopCenter;
            Forward.Location = new Point(421, 3);
            Forward.Name = "Forward";
            Forward.Size = new Size(48, 30);
            Forward.TabIndex = 9;
            Forward.UseVisualStyleBackColor = false;
            Forward.Visible = false;
            Forward.Click += Forward_Click;
            // 
            // Play_Pause
            // 
            Play_Pause.BackColor = Color.FromArgb(36, 41, 62);
            Play_Pause.Dock = DockStyle.Fill;
            Play_Pause.Enabled = false;
            Play_Pause.FlatAppearance.BorderSize = 0;
            Play_Pause.FlatStyle = FlatStyle.Flat;
            Play_Pause.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Play_Pause.ForeColor = Color.White;
            Play_Pause.Image = Properties.Resources.play;
            Play_Pause.ImageAlign = ContentAlignment.TopCenter;
            Play_Pause.Location = new Point(367, 3);
            Play_Pause.Name = "Play_Pause";
            Play_Pause.Size = new Size(48, 30);
            Play_Pause.TabIndex = 8;
            Play_Pause.UseVisualStyleBackColor = false;
            Play_Pause.Click += Play_Pause_Click;
            // 
            // Restart
            // 
            Restart.BackColor = Color.FromArgb(36, 41, 62);
            Restart.Dock = DockStyle.Fill;
            Restart.Enabled = false;
            Restart.FlatAppearance.BorderSize = 0;
            Restart.FlatStyle = FlatStyle.Flat;
            Restart.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Restart.ForeColor = Color.White;
            Restart.Image = Properties.Resources.restart;
            Restart.ImageAlign = ContentAlignment.TopCenter;
            Restart.Location = new Point(313, 3);
            Restart.Name = "Restart";
            Restart.Size = new Size(48, 30);
            Restart.TabIndex = 5;
            Restart.UseVisualStyleBackColor = false;
            Restart.Click += Restart_Click;
            // 
            // Backward
            // 
            Backward.BackColor = Color.FromArgb(36, 41, 62);
            Backward.Dock = DockStyle.Fill;
            Backward.Enabled = false;
            Backward.FlatAppearance.BorderSize = 0;
            Backward.FlatStyle = FlatStyle.Flat;
            Backward.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Backward.ForeColor = Color.White;
            Backward.Image = Properties.Resources.backward;
            Backward.ImageAlign = ContentAlignment.TopCenter;
            Backward.Location = new Point(259, 3);
            Backward.Name = "Backward";
            Backward.Size = new Size(48, 30);
            Backward.TabIndex = 6;
            Backward.UseVisualStyleBackColor = false;
            Backward.Visible = false;
            Backward.Click += Backward_Click;
            // 
            // ControlBar
            // 
            ControlBar.BackColor = Color.FromArgb(30, 34, 52);
            ControlBar.Controls.Add(Save);
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
            Save.Location = new Point(30, 0);
            Save.Name = "Save";
            Save.Size = new Size(30, 30);
            Save.TabIndex = 7;
            Save.UseVisualStyleBackColor = true;
            Save.Visible = false;
            Save.Click += Save_Click;
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
            // FilterManagerPanel
            // 
            FilterManagerPanel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            FilterManagerPanel.Controls.Add(FilterValueTextBox);
            FilterManagerPanel.Controls.Add(Apply);
            FilterManagerPanel.Controls.Add(ValueName);
            FilterManagerPanel.Location = new Point(800, 318);
            FilterManagerPanel.Name = "FilterManagerPanel";
            FilterManagerPanel.Size = new Size(266, 61);
            FilterManagerPanel.TabIndex = 44;
            FilterManagerPanel.Visible = false;
            // 
            // FilterValueTextBox
            // 
            FilterValueTextBox.BackColor = Color.FromArgb(36, 41, 62);
            FilterValueTextBox.BorderStyle = BorderStyle.None;
            FilterValueTextBox.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FilterValueTextBox.ForeColor = Color.WhiteSmoke;
            FilterValueTextBox.Location = new Point(135, 0);
            FilterValueTextBox.Name = "FilterValueTextBox";
            FilterValueTextBox.PlaceholderText = "000";
            FilterValueTextBox.Size = new Size(131, 22);
            FilterValueTextBox.TabIndex = 41;
            FilterValueTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // Apply
            // 
            Apply.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Apply.BackColor = Color.FromArgb(30, 34, 52);
            Apply.FlatAppearance.BorderSize = 0;
            Apply.FlatStyle = FlatStyle.Flat;
            Apply.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Apply.ForeColor = Color.White;
            Apply.ImageAlign = ContentAlignment.MiddleRight;
            Apply.Location = new Point(0, 33);
            Apply.Name = "Apply";
            Apply.Size = new Size(266, 28);
            Apply.TabIndex = 42;
            Apply.Text = "Apply";
            Apply.UseVisualStyleBackColor = false;
            Apply.Click += Apply_Click;
            // 
            // ValueName
            // 
            ValueName.AutoSize = true;
            ValueName.Font = new Font("Yu Gothic UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ValueName.ForeColor = Color.White;
            ValueName.Location = new Point(0, 0);
            ValueName.Name = "ValueName";
            ValueName.Size = new Size(96, 20);
            ValueName.TabIndex = 40;
            ValueName.Text = "Value Name:";
            // 
            // VideoUserCtrl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            Controls.Add(FilterManagerPanel);
            Controls.Add(panel2);
            Controls.Add(Hystogram4);
            Controls.Add(Hystogram3);
            Controls.Add(Hystogram2);
            Controls.Add(Hystogram1);
            Controls.Add(EditingSpace);
            Name = "VideoUserCtrl";
            Size = new Size(1100, 830);
            panel2.ResumeLayout(false);
            TitlePanel.ResumeLayout(false);
            TitlePanel.PerformLayout();
            FiltersFlowPanel.ResumeLayout(false);
            FilterPanel.ResumeLayout(false);
            FilterPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)FIlterPicture).EndInit();
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
            ButtonControl.ResumeLayout(false);
            ControlBar.ResumeLayout(false);
            FilterManagerPanel.ResumeLayout(false);
            FilterManagerPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel TitlePanel;
        private Label SectionLabel;
        private FlowLayoutPanel FiltersFlowPanel;
        private Panel FilterPanel;
        private PictureBox FIlterPicture;
        private Label FilterName;
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
        private TableLayoutPanel ButtonControl;
        private Button Restart;
        private Button Backward;
        private Panel ControlBar;
        private Button Save;
        private Button Open;
        private Panel panel6;
        private Button Forward;
        private Button Play_Pause;
        private Panel FilterManagerPanel;
        private TextBox FilterValueTextBox;
        private Button Apply;
        private Label ValueName;
    }
}
