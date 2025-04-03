namespace Pixels
{
    partial class WNDW
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
            lbl_Home = new Label();
            lbl_Camera = new Label();
            lbl_documentation = new Label();
            lbl_Image = new Label();
            lbl_Video = new Label();
            pnl_Documentation = new Panel();
            label1 = new Label();
            listView1 = new ListView();
            pnl_Documentation.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_Home
            // 
            lbl_Home.Cursor = Cursors.Hand;
            lbl_Home.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Home.Location = new Point(29, 714);
            lbl_Home.Name = "lbl_Home";
            lbl_Home.Size = new Size(153, 53);
            lbl_Home.TabIndex = 2;
            lbl_Home.Text = "Home";
            lbl_Home.Click += Home_Click;
            // 
            // lbl_Camera
            // 
            lbl_Camera.Cursor = Cursors.Hand;
            lbl_Camera.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Camera.Location = new Point(169, 714);
            lbl_Camera.Name = "lbl_Camera";
            lbl_Camera.Size = new Size(153, 53);
            lbl_Camera.TabIndex = 3;
            lbl_Camera.Text = "Camera";
            // 
            // lbl_documentation
            // 
            lbl_documentation.Cursor = Cursors.Hand;
            lbl_documentation.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_documentation.Location = new Point(591, 714);
            lbl_documentation.Name = "lbl_documentation";
            lbl_documentation.Size = new Size(286, 61);
            lbl_documentation.TabIndex = 4;
            lbl_documentation.Text = "Documentation";
            lbl_documentation.Click += lbl_documentation_Click;
            // 
            // lbl_Image
            // 
            lbl_Image.Cursor = Cursors.Hand;
            lbl_Image.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Image.Location = new Point(328, 714);
            lbl_Image.Name = "lbl_Image";
            lbl_Image.Size = new Size(153, 53);
            lbl_Image.TabIndex = 5;
            lbl_Image.Text = "Image";
            // 
            // lbl_Video
            // 
            lbl_Video.Cursor = Cursors.Hand;
            lbl_Video.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Video.Location = new Point(469, 714);
            lbl_Video.Name = "lbl_Video";
            lbl_Video.Size = new Size(126, 53);
            lbl_Video.TabIndex = 6;
            lbl_Video.Text = "Video";
            lbl_Video.Click += lbl_Video_Click;
            // 
            // pnl_Documentation
            // 
            pnl_Documentation.BackColor = SystemColors.ActiveCaption;
            pnl_Documentation.Controls.Add(label1);
            pnl_Documentation.Controls.Add(listView1);
            pnl_Documentation.Location = new Point(12, 12);
            pnl_Documentation.Name = "pnl_Documentation";
            pnl_Documentation.Size = new Size(1180, 664);
            pnl_Documentation.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(26, 23);
            label1.Name = "label1";
            label1.Size = new Size(89, 37);
            label1.TabIndex = 1;
            label1.Text = "Home";
            // 
            // listView1
            // 
            listView1.BackColor = SystemColors.ActiveCaption;
            listView1.Location = new Point(26, 63);
            listView1.Name = "listView1";
            listView1.Size = new Size(1128, 574);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // WNDW
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1251, 806);
            Controls.Add(lbl_Video);
            Controls.Add(lbl_Image);
            Controls.Add(lbl_documentation);
            Controls.Add(lbl_Camera);
            Controls.Add(lbl_Home);
            Controls.Add(pnl_Documentation);
            Name = "WNDW";
            Text = "Pixels";
            pnl_Documentation.ResumeLayout(false);
            pnl_Documentation.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lbl_Home;
        private Label lbl_Camera;
        private Label lbl_documentation;
        private Label lbl_Image;
        private Label lbl_Video;
        private Panel pnl_Documentation;
        private ListView listView1;
        private Label label1;
    }
}
