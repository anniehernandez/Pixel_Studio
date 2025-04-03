namespace Pixels
{
    partial class Documentation
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
            pnl_Documentation = new Panel();
            label2 = new Label();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
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
            lbl_Video.TabIndex = 12;
            lbl_Video.Text = "Video";
            // 
            // lbl_Image
            // 
            lbl_Image.Cursor = Cursors.Hand;
            lbl_Image.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Image.Location = new Point(351, 724);
            lbl_Image.Name = "lbl_Image";
            lbl_Image.Size = new Size(153, 53);
            lbl_Image.TabIndex = 11;
            lbl_Image.Text = "Image";
            // 
            // lbl_documentation
            // 
            lbl_documentation.Cursor = Cursors.Hand;
            lbl_documentation.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_documentation.Location = new Point(614, 724);
            lbl_documentation.Name = "lbl_documentation";
            lbl_documentation.Size = new Size(286, 61);
            lbl_documentation.TabIndex = 10;
            lbl_documentation.Text = "Documentation";
            // 
            // lbl_Camera
            // 
            lbl_Camera.Cursor = Cursors.Hand;
            lbl_Camera.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Camera.Location = new Point(192, 724);
            lbl_Camera.Name = "lbl_Camera";
            lbl_Camera.Size = new Size(153, 53);
            lbl_Camera.TabIndex = 9;
            lbl_Camera.Text = "Camera";
            // 
            // lbl_Home
            // 
            lbl_Home.Cursor = Cursors.Hand;
            lbl_Home.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Home.Location = new Point(52, 724);
            lbl_Home.Name = "lbl_Home";
            lbl_Home.Size = new Size(153, 53);
            lbl_Home.TabIndex = 8;
            lbl_Home.Text = "Home";
            // 
            // pnl_Documentation
            // 
            pnl_Documentation.BackColor = SystemColors.ActiveCaption;
            pnl_Documentation.Controls.Add(linkLabel1);
            pnl_Documentation.Controls.Add(label2);
            pnl_Documentation.Controls.Add(label1);
            pnl_Documentation.Location = new Point(35, 22);
            pnl_Documentation.Name = "pnl_Documentation";
            pnl_Documentation.Size = new Size(1180, 664);
            pnl_Documentation.TabIndex = 7;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 58);
            label2.Name = "label2";
            label2.Size = new Size(507, 284);
            label2.TabIndex = 1;
            label2.Text = "Anything you need when you need it ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 22);
            label1.Name = "label1";
            label1.Size = new Size(166, 20);
            label1.TabIndex = 0;
            label1.Text = "Project Documentation ";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(40, 381);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(181, 20);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Documentación completa";
            // 
            // Documentation
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
            Name = "Documentation";
            Text = "Documentation";
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
        private Panel pnl_Documentation;
        private LinkLabel linkLabel1;
        private Label label2;
        private Label label1;
    }
}