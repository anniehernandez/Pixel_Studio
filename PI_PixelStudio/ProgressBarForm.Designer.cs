namespace PI_PixelStudio
{
    partial class ProgressBarForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ProgressBar = new ProgressBar();
            ProgressLabel = new Label();
            NavigationPanel = new Panel();
            label2 = new Label();
            pictureBox4 = new PictureBox();
            Minimize = new Button();
            Exit = new Button();
            NavigationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // ProgressBar
            // 
            ProgressBar.Location = new Point(35, 108);
            ProgressBar.Name = "ProgressBar";
            ProgressBar.Size = new Size(530, 25);
            ProgressBar.TabIndex = 0;
            // 
            // ProgressLabel
            // 
            ProgressLabel.AutoSize = true;
            ProgressLabel.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProgressLabel.ForeColor = Color.White;
            ProgressLabel.Location = new Point(37, 84);
            ProgressLabel.Name = "ProgressLabel";
            ProgressLabel.Size = new Size(70, 21);
            ProgressLabel.TabIndex = 1;
            ProgressLabel.Text = "Saving...";
            // 
            // NavigationPanel
            // 
            NavigationPanel.BackColor = Color.FromArgb(36, 41, 62);
            NavigationPanel.Controls.Add(label2);
            NavigationPanel.Controls.Add(pictureBox4);
            NavigationPanel.Controls.Add(Minimize);
            NavigationPanel.Controls.Add(Exit);
            NavigationPanel.Dock = DockStyle.Top;
            NavigationPanel.Location = new Point(0, 0);
            NavigationPanel.Name = "NavigationPanel";
            NavigationPanel.Padding = new Padding(5, 0, 0, 0);
            NavigationPanel.Size = new Size(600, 30);
            NavigationPanel.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(32, 7);
            label2.Name = "label2";
            label2.Size = new Size(75, 17);
            label2.TabIndex = 0;
            label2.Text = "PixelStudio";
            // 
            // pictureBox4
            // 
            pictureBox4.Dock = DockStyle.Left;
            pictureBox4.Image = Properties.Resources.Logo;
            pictureBox4.Location = new Point(5, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(20, 30);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // Minimize
            // 
            Minimize.Dock = DockStyle.Right;
            Minimize.FlatAppearance.BorderSize = 0;
            Minimize.FlatStyle = FlatStyle.Flat;
            Minimize.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Minimize.ForeColor = Color.White;
            Minimize.Image = Properties.Resources.Min;
            Minimize.ImageAlign = ContentAlignment.TopRight;
            Minimize.Location = new Point(546, 0);
            Minimize.Name = "Minimize";
            Minimize.Size = new Size(27, 30);
            Minimize.TabIndex = 6;
            Minimize.UseVisualStyleBackColor = true;
            Minimize.Click += Minimize_Click;
            // 
            // Exit
            // 
            Exit.Dock = DockStyle.Right;
            Exit.FlatAppearance.BorderSize = 0;
            Exit.FlatStyle = FlatStyle.Flat;
            Exit.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Exit.ForeColor = Color.White;
            Exit.Image = Properties.Resources.Close;
            Exit.ImageAlign = ContentAlignment.TopRight;
            Exit.Location = new Point(573, 0);
            Exit.Name = "Exit";
            Exit.Size = new Size(27, 30);
            Exit.TabIndex = 4;
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // ProgressBarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(600, 200);
            Controls.Add(ProgressLabel);
            Controls.Add(ProgressBar);
            Controls.Add(NavigationPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProgressBarForm";
            Text = "000";
            NavigationPanel.ResumeLayout(false);
            NavigationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ProgressBar ProgressBar;
        private Label ProgressLabel;
        private Panel NavigationPanel;
        private Label label2;
        private PictureBox pictureBox4;
        private Button Minimize;
        private Button Exit;
    }
}