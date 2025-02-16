namespace PI_PixelStudio
{
    partial class FiltersUserCrtl
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            FilterName = new Label();
            Histograma4 = new Panel();
            Histograma3 = new Panel();
            Histograma2 = new Panel();
            panel10 = new Panel();
            panel11 = new Panel();
            Histograma1 = new Panel();
            EditingSpace = new Panel();
            menuStrip1 = new MenuStrip();
            imageToolStripMenuItem = new ToolStripMenuItem();
            videoToolStripMenuItem = new ToolStripMenuItem();
            panel2.SuspendLayout();
            TitlePanel.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Histograma2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(TitlePanel);
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 646);
            panel2.Name = "panel2";
            panel2.Size = new Size(1100, 184);
            panel2.TabIndex = 30;
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
            SectionLabel.Size = new Size(108, 21);
            SectionLabel.TabIndex = 0;
            SectionLabel.Text = "SectionName";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(0, 28);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1100, 156);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(36, 41, 62);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(FilterName);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(140, 153);
            panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(117, 109);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // FilterName
            // 
            FilterName.AutoSize = true;
            FilterName.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FilterName.ForeColor = Color.White;
            FilterName.Location = new Point(32, 124);
            FilterName.Name = "FilterName";
            FilterName.Size = new Size(75, 17);
            FilterName.TabIndex = 0;
            FilterName.Text = "Filter Name";
            // 
            // Histograma4
            // 
            Histograma4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Histograma4.BackColor = Color.FromArgb(36, 41, 62);
            Histograma4.Location = new Point(934, 199);
            Histograma4.Name = "Histograma4";
            Histograma4.Size = new Size(131, 131);
            Histograma4.TabIndex = 25;
            // 
            // Histograma3
            // 
            Histograma3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Histograma3.BackColor = Color.FromArgb(36, 41, 62);
            Histograma3.Location = new Point(799, 199);
            Histograma3.Name = "Histograma3";
            Histograma3.Size = new Size(131, 131);
            Histograma3.TabIndex = 26;
            // 
            // Histograma2
            // 
            Histograma2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Histograma2.BackColor = Color.FromArgb(36, 41, 62);
            Histograma2.Controls.Add(panel10);
            Histograma2.Controls.Add(panel11);
            Histograma2.Location = new Point(934, 63);
            Histograma2.Name = "Histograma2";
            Histograma2.Size = new Size(131, 131);
            Histograma2.TabIndex = 27;
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
            // Histograma1
            // 
            Histograma1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Histograma1.BackColor = Color.FromArgb(36, 41, 62);
            Histograma1.Location = new Point(799, 63);
            Histograma1.Name = "Histograma1";
            Histograma1.Size = new Size(131, 131);
            Histograma1.TabIndex = 28;
            // 
            // EditingSpace
            // 
            EditingSpace.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EditingSpace.BackColor = Color.FromArgb(36, 41, 62);
            EditingSpace.Location = new Point(35, 63);
            EditingSpace.Name = "EditingSpace";
            EditingSpace.Size = new Size(730, 553);
            EditingSpace.TabIndex = 29;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(36, 41, 62);
            menuStrip1.Font = new Font("Yu Gothic UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { imageToolStripMenuItem, videoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1100, 28);
            menuStrip1.TabIndex = 31;
            menuStrip1.Text = "Image_Video";
            // 
            // imageToolStripMenuItem
            // 
            imageToolStripMenuItem.ForeColor = Color.White;
            imageToolStripMenuItem.Image = Properties.Resources.image;
            imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            imageToolStripMenuItem.Size = new Size(79, 24);
            imageToolStripMenuItem.Text = "Image";
            imageToolStripMenuItem.Click += imageToolStripMenuItem_Click;
            // 
            // videoToolStripMenuItem
            // 
            videoToolStripMenuItem.ForeColor = Color.White;
            videoToolStripMenuItem.Image = Properties.Resources.video;
            videoToolStripMenuItem.Name = "videoToolStripMenuItem";
            videoToolStripMenuItem.Size = new Size(77, 24);
            videoToolStripMenuItem.Text = "Video";
            videoToolStripMenuItem.Click += videoToolStripMenuItem_Click;
            // 
            // FiltersUserCrtl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            Controls.Add(menuStrip1);
            Controls.Add(panel2);
            Controls.Add(Histograma4);
            Controls.Add(Histograma3);
            Controls.Add(Histograma2);
            Controls.Add(Histograma1);
            Controls.Add(EditingSpace);
            Name = "FiltersUserCrtl";
            Size = new Size(1100, 830);
            panel2.ResumeLayout(false);
            TitlePanel.ResumeLayout(false);
            TitlePanel.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Histograma2.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Panel TitlePanel;
        private Label SectionLabel;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label FilterName;
        private Panel Histograma4;
        private Panel Histograma3;
        private Panel Histograma2;
        private Panel panel10;
        private Panel panel11;
        private Panel Histograma1;
        private Panel EditingSpace;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem imageToolStripMenuItem;
        private ToolStripMenuItem videoToolStripMenuItem;
    }
}
