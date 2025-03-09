namespace evidence_clip_about_public_transport.Win_forms_user_interface.other
{
    partial class Login_popup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_popup));
            set_database_connection_button = new Button();
            name_label = new Label();
            password_label = new Label();
            password_ = new TextBox();
            login_to_system_button = new Button();
            login_name = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // set_database_connection_button
            // 
            set_database_connection_button.Location = new Point(143, 358);
            set_database_connection_button.Name = "set_database_connection_button";
            set_database_connection_button.Size = new Size(299, 40);
            set_database_connection_button.TabIndex = 3;
            set_database_connection_button.Text = "nastavit připojení do databáze";
            set_database_connection_button.UseVisualStyleBackColor = true;
            set_database_connection_button.Click += set_database_connection_button_Click;
            // 
            // name_label
            // 
            name_label.AutoSize = true;
            name_label.Location = new Point(19, 272);
            name_label.Name = "name_label";
            name_label.Size = new Size(62, 25);
            name_label.TabIndex = 1;
            name_label.Text = "jméno";
            // 
            // password_label
            // 
            password_label.AutoSize = true;
            password_label.Location = new Point(26, 312);
            password_label.Name = "password_label";
            password_label.Size = new Size(54, 25);
            password_label.TabIndex = 2;
            password_label.Text = "heslo";
            // 
            // password_
            // 
            password_.Location = new Point(86, 313);
            password_.MaxLength = int.MaxValue;
            password_.Name = "password_";
            password_.PasswordChar = '*';
            password_.Size = new Size(233, 31);
            password_.TabIndex = 1;
            // 
            // login_to_system_button
            // 
            login_to_system_button.Location = new Point(326, 312);
            login_to_system_button.Name = "login_to_system_button";
            login_to_system_button.Size = new Size(116, 40);
            login_to_system_button.TabIndex = 2;
            login_to_system_button.Text = "Přihlásit se";
            login_to_system_button.UseVisualStyleBackColor = true;
            login_to_system_button.Click += login_to_system_button_Click;
            // 
            // login_name
            // 
            login_name.Location = new Point(86, 268);
            login_name.MaxLength = 100;
            login_name.Name = "login_name";
            login_name.Size = new Size(233, 31);
            login_name.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(430, 250);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Login_popup
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 414);
            Controls.Add(pictureBox1);
            Controls.Add(login_name);
            Controls.Add(login_to_system_button);
            Controls.Add(password_);
            Controls.Add(password_label);
            Controls.Add(name_label);
            Controls.Add(set_database_connection_button);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login_popup";
            Text = "přihlášení do programu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button set_database_connection_button;
        private Label name_label;
        private Label password_label;
        private TextBox password_;
        private Button login_to_system_button;
        private TextBox login_name;
        private PictureBox pictureBox1;
    }
}