namespace Pixels
{
    partial class Camera
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
            lbl_Video = new Label();
            lbl_Image = new Label();
            lbl_documentation = new Label();
            lbl_Camera = new Label();
            lbl_Home = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ltv_filters = new ListView();
            button1 = new Button();
            pnl_Documentation = new Panel();
            button2 = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            pnl_Documentation.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_Video
            // 
            lbl_Video.Cursor = Cursors.Hand;
            lbl_Video.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Video.Location = new Point(492, 724);
            lbl_Video.Name = "lbl_Video";
            lbl_Video.Size = new Size(126, 53);
            lbl_Video.TabIndex = 18;
            lbl_Video.Text = "Video";
            // 
            // lbl_Image
            // 
            lbl_Image.Cursor = Cursors.Hand;
            lbl_Image.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Image.Location = new Point(351, 724);
            lbl_Image.Name = "lbl_Image";
            lbl_Image.Size = new Size(153, 53);
            lbl_Image.TabIndex = 17;
            lbl_Image.Text = "Image";
            // 
            // lbl_documentation
            // 
            lbl_documentation.Cursor = Cursors.Hand;
            lbl_documentation.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_documentation.Location = new Point(614, 724);
            lbl_documentation.Name = "lbl_documentation";
            lbl_documentation.Size = new Size(286, 61);
            lbl_documentation.TabIndex = 16;
            lbl_documentation.Text = "Documentation";
            // 
            // lbl_Camera
            // 
            lbl_Camera.Cursor = Cursors.Hand;
            lbl_Camera.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Camera.Location = new Point(192, 724);
            lbl_Camera.Name = "lbl_Camera";
            lbl_Camera.Size = new Size(153, 53);
            lbl_Camera.TabIndex = 15;
            lbl_Camera.Text = "Camera";
            // 
            // lbl_Home
            // 
            lbl_Home.Cursor = Cursors.Hand;
            lbl_Home.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Home.Location = new Point(52, 724);
            lbl_Home.Name = "lbl_Home";
            lbl_Home.Size = new Size(153, 53);
            lbl_Home.TabIndex = 14;
            lbl_Home.Text = "Home";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(17, 22);
            label1.Name = "label1";
            label1.Size = new Size(108, 37);
            label1.TabIndex = 0;
            label1.Text = "Camera";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(35, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(776, 512);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(ltv_filters);
            panel1.Location = new Point(829, 62);
            panel1.Name = "panel1";
            panel1.Size = new Size(335, 512);
            panel1.TabIndex = 5;
            // 
            // ltv_filters
            // 
            ltv_filters.BackColor = SystemColors.ActiveCaption;
            ltv_filters.Location = new Point(13, 17);
            ltv_filters.Name = "ltv_filters";
            ltv_filters.Size = new Size(307, 475);
            ltv_filters.TabIndex = 8;
            ltv_filters.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(631, 607);
            button1.Margin = new Padding(3, 3, 5, 5);
            button1.Name = "button1";
            button1.Size = new Size(162, 29);
            button1.TabIndex = 10;
            button1.Text = "Open camera";
            button1.UseVisualStyleBackColor = false;
            // 
            // pnl_Documentation
            // 
            pnl_Documentation.BackColor = SystemColors.ActiveCaption;
            pnl_Documentation.Controls.Add(button2);
            pnl_Documentation.Controls.Add(button1);
            pnl_Documentation.Controls.Add(panel1);
            pnl_Documentation.Controls.Add(pictureBox1);
            pnl_Documentation.Controls.Add(label3);
            pnl_Documentation.Controls.Add(label1);
            pnl_Documentation.Location = new Point(35, 22);
            pnl_Documentation.Name = "pnl_Documentation";
            pnl_Documentation.Size = new Size(1180, 664);
            pnl_Documentation.TabIndex = 13;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveBorder;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(457, 607);
            button2.Margin = new Padding(3, 3, 5, 5);
            button2.Name = "button2";
            button2.Size = new Size(162, 29);
            button2.TabIndex = 11;
            button2.Text = "Take picture";
            button2.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(829, 22);
            label3.Name = "label3";
            label3.Size = new Size(87, 37);
            label3.TabIndex = 2;
            label3.Text = "Filters";
            // 
            // Camera
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1251, 806);
            Controls.Add(lbl_Video);
            Controls.Add(lbl_Image);
            Controls.Add(lbl_documentation);
            Controls.Add(lbl_Camera);
            Controls.Add(lbl_Home);
            Controls.Add(pnl_Documentation);
            Name = "Camera";
            Text = "Camera";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            pnl_Documentation.ResumeLayout(false);
            pnl_Documentation.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_Video;
        private Label lbl_Image;
        private Label lbl_documentation;
        private Label lbl_Camera;
        private Label lbl_Home;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private ListView ltv_filters;
        private Button button1;
        private Panel pnl_Documentation;
        private Button button2;
        private Label label3;
    }
}