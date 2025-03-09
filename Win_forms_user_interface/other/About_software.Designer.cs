namespace evidence_clip_about_public_transport.Win_forms_user_interface.other
{
    partial class About_software
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About_software));
            pictureBox1 = new PictureBox();
            about_software_label = new Label();
            close_button = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 0);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(139, 467);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // about_software_label
            // 
            about_software_label.AutoSize = true;
            about_software_label.Location = new Point(150, 15);
            about_software_label.Margin = new Padding(4, 0, 4, 0);
            about_software_label.Name = "about_software_label";
            about_software_label.Size = new Size(296, 100);
            about_software_label.TabIndex = 1;
            about_software_label.Text = "program na evidenci záběrů o MHD\r\nverze 2.0\r\nautor: Martin Hamacek\r\n2025";
            // 
            // close_button
            // 
            close_button.Location = new Point(481, 410);
            close_button.Margin = new Padding(4, 5, 4, 5);
            close_button.Name = "close_button";
            close_button.Size = new Size(107, 38);
            close_button.TabIndex = 2;
            close_button.Text = "zavřít";
            close_button.UseVisualStyleBackColor = true;
            close_button.Click += close_button_Click;
            // 
            // About_software
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 468);
            Controls.Add(close_button);
            Controls.Add(about_software_label);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "About_software";
            Text = "O programu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label about_software_label;
        private Button close_button;
    }
}