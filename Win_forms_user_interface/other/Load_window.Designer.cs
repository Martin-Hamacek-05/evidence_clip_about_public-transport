namespace evidence_clip_about_public_transport.Win_forms_user_interface.other
{
    partial class Load_window
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Load_window));
            load_popup = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)load_popup).BeginInit();
            SuspendLayout();
            // 
            // load_popup
            // 
            load_popup.Dock = DockStyle.Fill;
            load_popup.Image = (Image)resources.GetObject("load_popup.Image");
            load_popup.Location = new Point(0, 0);
            load_popup.Name = "load_popup";
            load_popup.Size = new Size(707, 437);
            load_popup.SizeMode = PictureBoxSizeMode.Zoom;
            load_popup.TabIndex = 0;
            load_popup.TabStop = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Load_window
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 437);
            Controls.Add(load_popup);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Load_window";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Load_window";
            ((System.ComponentModel.ISupportInitialize)load_popup).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox load_popup;
        private System.Windows.Forms.Timer timer1;
    }
}