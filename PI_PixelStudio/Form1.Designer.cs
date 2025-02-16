using System.Drawing.Drawing2D;

namespace PI_PixelStudio
{
    partial class PixelStudio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ButtonActive = new FlowLayoutPanel();
            CameraButton = new Button();
            FiltersButton = new Button();
            EffectsButton = new Button();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            NavigationPanel = new Panel();
            panel8 = new Panel();
            label1 = new Label();
            pictureBox4 = new PictureBox();
            Questions = new Button();
            Minimize = new Button();
            Maximize = new Button();
            Exit = new Button();
            ContainerPanel = new Panel();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            NavigationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ContainerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new Point(65, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(36, 41, 62);
            panel1.Controls.Add(ButtonActive);
            panel1.Controls.Add(CameraButton);
            panel1.Controls.Add(FiltersButton);
            panel1.Controls.Add(EffectsButton);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 860);
            panel1.TabIndex = 0;
            // 
            // ButtonActive
            // 
            ButtonActive.BackColor = Color.FromArgb(113, 109, 214);
            ButtonActive.Location = new Point(0, 160);
            ButtonActive.Name = "ButtonActive";
            ButtonActive.Size = new Size(7, 107);
            ButtonActive.TabIndex = 1;
            ButtonActive.Visible = false;
            // 
            // CameraButton
            // 
            CameraButton.Dock = DockStyle.Top;
            CameraButton.FlatAppearance.BorderSize = 0;
            CameraButton.FlatStyle = FlatStyle.Flat;
            CameraButton.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CameraButton.ForeColor = Color.White;
            CameraButton.Image = Properties.Resources.mdi_camera;
            CameraButton.ImageAlign = ContentAlignment.TopRight;
            CameraButton.Location = new Point(0, 233);
            CameraButton.Name = "CameraButton";
            CameraButton.Padding = new Padding(0, 0, 10, 0);
            CameraButton.Size = new Size(200, 36);
            CameraButton.TabIndex = 3;
            CameraButton.Text = "Camera";
            CameraButton.UseVisualStyleBackColor = true;
            CameraButton.Click += CameraButton_Click;
            // 
            // FiltersButton
            // 
            FiltersButton.Dock = DockStyle.Top;
            FiltersButton.FlatAppearance.BorderSize = 0;
            FiltersButton.FlatStyle = FlatStyle.Flat;
            FiltersButton.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FiltersButton.ForeColor = Color.White;
            FiltersButton.Image = Properties.Resources.streamline_magic_wand_2_solid;
            FiltersButton.ImageAlign = ContentAlignment.TopRight;
            FiltersButton.Location = new Point(0, 197);
            FiltersButton.Name = "FiltersButton";
            FiltersButton.Padding = new Padding(0, 0, 10, 0);
            FiltersButton.Size = new Size(200, 36);
            FiltersButton.TabIndex = 2;
            FiltersButton.Text = "Filters";
            FiltersButton.UseVisualStyleBackColor = true;
            FiltersButton.Click += FiltersButton_Click;
            // 
            // EffectsButton
            // 
            EffectsButton.Dock = DockStyle.Top;
            EffectsButton.FlatAppearance.BorderSize = 0;
            EffectsButton.FlatStyle = FlatStyle.Flat;
            EffectsButton.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EffectsButton.ForeColor = Color.White;
            EffectsButton.Image = Properties.Resources.solar_star_fall_bold;
            EffectsButton.ImageAlign = ContentAlignment.TopRight;
            EffectsButton.Location = new Point(0, 161);
            EffectsButton.Name = "EffectsButton";
            EffectsButton.Padding = new Padding(0, 0, 10, 0);
            EffectsButton.Size = new Size(200, 36);
            EffectsButton.TabIndex = 1;
            EffectsButton.Text = "Effects";
            EffectsButton.UseVisualStyleBackColor = true;
            EffectsButton.Click += EffectsButton_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 161);
            panel2.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.PixelStudio;
            pictureBox2.Location = new Point(50, 106);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // NavigationPanel
            // 
            NavigationPanel.BackColor = Color.FromArgb(36, 41, 62);
            NavigationPanel.Controls.Add(panel8);
            NavigationPanel.Controls.Add(label1);
            NavigationPanel.Controls.Add(pictureBox4);
            NavigationPanel.Controls.Add(Questions);
            NavigationPanel.Controls.Add(Minimize);
            NavigationPanel.Controls.Add(Maximize);
            NavigationPanel.Controls.Add(Exit);
            NavigationPanel.Dock = DockStyle.Top;
            NavigationPanel.Location = new Point(200, 0);
            NavigationPanel.Name = "NavigationPanel";
            NavigationPanel.Padding = new Padding(5, 0, 0, 0);
            NavigationPanel.Size = new Size(1100, 30);
            NavigationPanel.TabIndex = 0;
            // 
            // panel8
            // 
            panel8.Location = new Point(0, 30);
            panel8.Name = "panel8";
            panel8.Size = new Size(1020, 820);
            panel8.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(27, 7);
            label1.Name = "label1";
            label1.Size = new Size(75, 17);
            label1.TabIndex = 0;
            label1.Text = "PixelStudio";
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
            // Questions
            // 
            Questions.Dock = DockStyle.Right;
            Questions.FlatAppearance.BorderSize = 0;
            Questions.FlatStyle = FlatStyle.Flat;
            Questions.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Questions.ForeColor = Color.White;
            Questions.Image = Properties.Resources.Question;
            Questions.ImageAlign = ContentAlignment.TopRight;
            Questions.Location = new Point(990, 0);
            Questions.Name = "Questions";
            Questions.Size = new Size(29, 30);
            Questions.TabIndex = 7;
            Questions.UseVisualStyleBackColor = true;
            Questions.Click += Questions_Click;
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
            Minimize.Location = new Point(1019, 0);
            Minimize.Name = "Minimize";
            Minimize.Size = new Size(27, 30);
            Minimize.TabIndex = 6;
            Minimize.UseVisualStyleBackColor = true;
            Minimize.Click += Minimize_Click;
            // 
            // Maximize
            // 
            Maximize.Dock = DockStyle.Right;
            Maximize.FlatAppearance.BorderSize = 0;
            Maximize.FlatStyle = FlatStyle.Flat;
            Maximize.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Maximize.ForeColor = Color.White;
            Maximize.Image = Properties.Resources.Max;
            Maximize.ImageAlign = ContentAlignment.TopRight;
            Maximize.Location = new Point(1046, 0);
            Maximize.Name = "Maximize";
            Maximize.Size = new Size(27, 30);
            Maximize.TabIndex = 5;
            Maximize.UseVisualStyleBackColor = true;
            Maximize.Click += Maximize_Click;
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
            Exit.Location = new Point(1073, 0);
            Exit.Name = "Exit";
            Exit.Size = new Size(27, 30);
            Exit.TabIndex = 4;
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // ContainerPanel
            // 
            ContainerPanel.Controls.Add(pictureBox3);
            ContainerPanel.Dock = DockStyle.Fill;
            ContainerPanel.Location = new Point(200, 30);
            ContainerPanel.Name = "ContainerPanel";
            ContainerPanel.Size = new Size(1100, 830);
            ContainerPanel.TabIndex = 1;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox3.Image = Properties.Resources.Logo2;
            pictureBox3.Location = new Point(410, 310);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(280, 210);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // PixelStudio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1300, 860);
            Controls.Add(ContainerPanel);
            Controls.Add(NavigationPanel);
            Controls.Add(panel1);
            Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(0, 50);
            Name = "PixelStudio";
            Text = "PixelStudio";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            NavigationPanel.ResumeLayout(false);
            NavigationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ContainerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Panel NavigationPanel;
        private Button EffectsButton;
        private Button CameraButton;
        private Button FiltersButton;
        private Button Minimize;
        private Button Maximize;
        private Button Exit;
        private Button Questions;
        private PictureBox pictureBox4;
        private Label label1;
        private Panel panel8;
        private FlowLayoutPanel ButtonActive;
        private Panel ContainerPanel;
        private PictureBox pictureBox3;
    }
}
