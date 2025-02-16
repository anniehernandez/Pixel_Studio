namespace PI_PixelStudio
{
    partial class VideoEditing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoEditing));
            panel5 = new Panel();
            Save = new Button();
            Open = new Button();
            panel6 = new Panel();
            Play_Pause = new Button();
            VideoControl = new Panel();
            ButtonControl = new TableLayoutPanel();
            Forward = new Button();
            Backward = new Button();
            VideoDisplay = new AxWMPLib.AxWindowsMediaPlayer();
            panel5.SuspendLayout();
            VideoControl.SuspendLayout();
            ButtonControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)VideoDisplay).BeginInit();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(30, 34, 52);
            panel5.Controls.Add(Save);
            panel5.Controls.Add(Open);
            panel5.Controls.Add(panel6);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(730, 30);
            panel5.TabIndex = 5;
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
            Save.TabIndex = 5;
            Save.UseVisualStyleBackColor = true;
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
            // Play_Pause
            // 
            Play_Pause.BackColor = Color.FromArgb(36, 41, 62);
            Play_Pause.Dock = DockStyle.Fill;
            Play_Pause.FlatAppearance.BorderSize = 0;
            Play_Pause.FlatStyle = FlatStyle.Flat;
            Play_Pause.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Play_Pause.ForeColor = Color.White;
            Play_Pause.Image = Properties.Resources.play;
            Play_Pause.ImageAlign = ContentAlignment.TopCenter;
            Play_Pause.Location = new Point(337, 3);
            Play_Pause.Name = "Play_Pause";
            Play_Pause.Size = new Size(53, 30);
            Play_Pause.TabIndex = 5;
            Play_Pause.UseVisualStyleBackColor = false;
            Play_Pause.Click += Play_Pause_Click;
            // 
            // VideoControl
            // 
            VideoControl.BackColor = Color.FromArgb(30, 34, 52);
            VideoControl.Controls.Add(ButtonControl);
            VideoControl.Dock = DockStyle.Bottom;
            VideoControl.Location = new Point(0, 517);
            VideoControl.Name = "VideoControl";
            VideoControl.Size = new Size(730, 36);
            VideoControl.TabIndex = 7;
            // 
            // ButtonControl
            // 
            ButtonControl.BackColor = Color.FromArgb(30, 34, 52);
            ButtonControl.ColumnCount = 5;
            ButtonControl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37F));
            ButtonControl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8F));
            ButtonControl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8F));
            ButtonControl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8F));
            ButtonControl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37F));
            ButtonControl.Controls.Add(Forward, 3, 0);
            ButtonControl.Controls.Add(Play_Pause, 2, 0);
            ButtonControl.Controls.Add(Backward, 1, 0);
            ButtonControl.Dock = DockStyle.Fill;
            ButtonControl.Location = new Point(0, 0);
            ButtonControl.Name = "ButtonControl";
            ButtonControl.RowCount = 1;
            ButtonControl.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            ButtonControl.Size = new Size(730, 36);
            ButtonControl.TabIndex = 8;
            // 
            // Forward
            // 
            Forward.BackColor = Color.FromArgb(36, 41, 62);
            Forward.Dock = DockStyle.Fill;
            Forward.FlatAppearance.BorderSize = 0;
            Forward.FlatStyle = FlatStyle.Flat;
            Forward.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Forward.ForeColor = Color.White;
            Forward.Image = Properties.Resources.forward;
            Forward.ImageAlign = ContentAlignment.TopCenter;
            Forward.Location = new Point(396, 3);
            Forward.Name = "Forward";
            Forward.Size = new Size(53, 30);
            Forward.TabIndex = 7;
            Forward.UseVisualStyleBackColor = false;
            Forward.Click += Forward_Click;
            // 
            // Backward
            // 
            Backward.BackColor = Color.FromArgb(36, 41, 62);
            Backward.Dock = DockStyle.Fill;
            Backward.FlatAppearance.BorderSize = 0;
            Backward.FlatStyle = FlatStyle.Flat;
            Backward.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Backward.ForeColor = Color.White;
            Backward.Image = Properties.Resources.backward;
            Backward.ImageAlign = ContentAlignment.TopCenter;
            Backward.Location = new Point(278, 3);
            Backward.Name = "Backward";
            Backward.Size = new Size(53, 30);
            Backward.TabIndex = 6;
            Backward.UseVisualStyleBackColor = false;
            // 
            // VideoDisplay
            // 
            VideoDisplay.Dock = DockStyle.Fill;
            VideoDisplay.Enabled = true;
            VideoDisplay.Location = new Point(0, 30);
            VideoDisplay.Name = "VideoDisplay";
            VideoDisplay.OcxState = (AxHost.State)resources.GetObject("VideoDisplay.OcxState");
            VideoDisplay.Size = new Size(730, 487);
            VideoDisplay.TabIndex = 8;
            // 
            // VideoEditing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 41, 62);
            Controls.Add(VideoDisplay);
            Controls.Add(VideoControl);
            Controls.Add(panel5);
            Name = "VideoEditing";
            Size = new Size(730, 553);
            panel5.ResumeLayout(false);
            VideoControl.ResumeLayout(false);
            ButtonControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)VideoDisplay).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel5;
        private Button Save;
        private Button ZoomIn;
        private Button Open;
        private Panel panel6;
        private Button Play_Pause;
        private Panel VideoControl;
        private TableLayoutPanel ButtonControl;
        private Button Forward;
        private Button Backward;
        private AxWMPLib.AxWindowsMediaPlayer VideoDisplay;
    }
}
