namespace PI_PixelStudio
{
    partial class FilterParamForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilterParamForm));
            NavigationPanel = new Panel();
            label2 = new Label();
            pictureBox4 = new PictureBox();
            Minimize = new Button();
            Exit = new Button();
            ValueName = new Label();
            FilterValue = new TextBox();
            Apply = new Button();
            NavigationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
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
            NavigationPanel.Size = new Size(280, 30);
            NavigationPanel.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(37, 7);
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
            Minimize.Location = new Point(226, 0);
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
            Exit.Location = new Point(253, 0);
            Exit.Name = "Exit";
            Exit.Size = new Size(27, 30);
            Exit.TabIndex = 4;
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // ValueName
            // 
            ValueName.AutoSize = true;
            ValueName.Font = new Font("Yu Gothic UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ValueName.ForeColor = Color.White;
            ValueName.Location = new Point(42, 62);
            ValueName.Name = "ValueName";
            ValueName.Size = new Size(96, 20);
            ValueName.TabIndex = 4;
            ValueName.Text = "Value Name:";
            // 
            // FilterValue
            // 
            FilterValue.BackColor = Color.FromArgb(36, 41, 62);
            FilterValue.BorderStyle = BorderStyle.None;
            FilterValue.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FilterValue.ForeColor = Color.WhiteSmoke;
            FilterValue.Location = new Point(186, 62);
            FilterValue.Name = "FilterValue";
            FilterValue.PlaceholderText = "000";
            FilterValue.Size = new Size(58, 22);
            FilterValue.TabIndex = 5;
            FilterValue.TextAlign = HorizontalAlignment.Center;
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
            Apply.Location = new Point(90, 110);
            Apply.Name = "Apply";
            Apply.Size = new Size(100, 28);
            Apply.TabIndex = 7;
            Apply.Text = "Apply";
            Apply.UseVisualStyleBackColor = false;
            Apply.Click += Apply_Click;
            // 
            // FilterParamForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(280, 160);
            Controls.Add(Apply);
            Controls.Add(FilterValue);
            Controls.Add(ValueName);
            Controls.Add(NavigationPanel);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FilterParamForm";
            Text = "FIlterValueForm";
            NavigationPanel.ResumeLayout(false);
            NavigationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel NavigationPanel;
        private Label label2;
        private PictureBox pictureBox4;
        private Button Minimize;
        private Button Exit;
        private Label ValueName;
        private TextBox FilterValue;
        private Button Apply;
    }
}