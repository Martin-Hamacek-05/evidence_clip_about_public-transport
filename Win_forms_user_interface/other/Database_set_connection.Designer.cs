namespace evidence_clip_about_public_transport.Win_forms_user_interface.other
{
    partial class Database_set_connection
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
            server_label = new Label();
            server = new TextBox();
            port_label = new Label();
            database = new TextBox();
            database_label = new Label();
            user_name = new TextBox();
            user_nme_label = new Label();
            password = new TextBox();
            password_label = new Label();
            port = new NumericUpDown();
            save = new Button();
            server_switch = new ComboBox();
            adress_label = new Label();
            other = new TextBox();
            other_label = new Label();
            ((System.ComponentModel.ISupportInitialize)port).BeginInit();
            SuspendLayout();
            // 
            // server_label
            // 
            server_label.AutoSize = true;
            server_label.Location = new Point(14, 22);
            server_label.Margin = new Padding(2, 0, 2, 0);
            server_label.Name = "server_label";
            server_label.Size = new Size(38, 15);
            server_label.TabIndex = 0;
            server_label.Text = "server";
            // 
            // server
            // 
            server.Location = new Point(125, 47);
            server.Margin = new Padding(2);
            server.Name = "server";
            server.Size = new Size(185, 23);
            server.TabIndex = 0;
            // 
            // port_label
            // 
            port_label.AutoSize = true;
            port_label.Location = new Point(14, 75);
            port_label.Margin = new Padding(2, 0, 2, 0);
            port_label.Name = "port_label";
            port_label.Size = new Size(29, 15);
            port_label.TabIndex = 2;
            port_label.Text = "port";
            // 
            // database
            // 
            database.Location = new Point(125, 101);
            database.Margin = new Padding(2);
            database.Name = "database";
            database.Size = new Size(185, 23);
            database.TabIndex = 2;
            // 
            // database_label
            // 
            database_label.AutoSize = true;
            database_label.Location = new Point(14, 103);
            database_label.Margin = new Padding(2, 0, 2, 0);
            database_label.Name = "database_label";
            database_label.Size = new Size(54, 15);
            database_label.TabIndex = 4;
            database_label.Text = "databáze";
            // 
            // user_name
            // 
            user_name.Location = new Point(125, 128);
            user_name.Margin = new Padding(2);
            user_name.Name = "user_name";
            user_name.Size = new Size(185, 23);
            user_name.TabIndex = 3;
            // 
            // user_nme_label
            // 
            user_nme_label.AutoSize = true;
            user_nme_label.Location = new Point(14, 130);
            user_nme_label.Margin = new Padding(2, 0, 2, 0);
            user_nme_label.Name = "user_nme_label";
            user_nme_label.Size = new Size(101, 15);
            user_nme_label.TabIndex = 6;
            user_nme_label.Text = "uživatelské jméno";
            // 
            // password
            // 
            password.Location = new Point(125, 155);
            password.Margin = new Padding(2);
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(185, 23);
            password.TabIndex = 4;
            // 
            // password_label
            // 
            password_label.AutoSize = true;
            password_label.Location = new Point(14, 157);
            password_label.Margin = new Padding(2, 0, 2, 0);
            password_label.Name = "password_label";
            password_label.Size = new Size(35, 15);
            password_label.TabIndex = 8;
            password_label.Text = "heslo";
            // 
            // port
            // 
            port.Location = new Point(125, 74);
            port.Margin = new Padding(2);
            port.Maximum = new decimal(new int[] { 65525, 0, 0, 0 });
            port.Name = "port";
            port.Size = new Size(184, 23);
            port.TabIndex = 1;
            // 
            // save
            // 
            save.Location = new Point(232, 209);
            save.Margin = new Padding(2);
            save.Name = "save";
            save.Size = new Size(78, 23);
            save.TabIndex = 6;
            save.Text = "uložit";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // server_switch
            // 
            server_switch.DropDownStyle = ComboBoxStyle.DropDownList;
            server_switch.FormattingEnabled = true;
            server_switch.Items.AddRange(new object[] { "MySQL databáze" });
            server_switch.Location = new Point(125, 19);
            server_switch.Name = "server_switch";
            server_switch.Size = new Size(185, 23);
            server_switch.TabIndex = 9;
            // 
            // adress_label
            // 
            adress_label.AutoSize = true;
            adress_label.Location = new Point(14, 50);
            adress_label.Margin = new Padding(2, 0, 2, 0);
            adress_label.Name = "adress_label";
            adress_label.Size = new Size(41, 15);
            adress_label.TabIndex = 10;
            adress_label.Text = "adresa";
            // 
            // other
            // 
            other.Location = new Point(125, 182);
            other.Margin = new Padding(2);
            other.Name = "other";
            other.Size = new Size(185, 23);
            other.TabIndex = 11;
            // 
            // other_label
            // 
            other_label.AutoSize = true;
            other_label.Location = new Point(14, 185);
            other_label.Margin = new Padding(2, 0, 2, 0);
            other_label.Name = "other_label";
            other_label.Size = new Size(43, 15);
            other_label.TabIndex = 12;
            other_label.Text = "ostatní";
            // 
            // Database_set_connection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 243);
            Controls.Add(other_label);
            Controls.Add(other);
            Controls.Add(adress_label);
            Controls.Add(server_switch);
            Controls.Add(save);
            Controls.Add(port);
            Controls.Add(password);
            Controls.Add(password_label);
            Controls.Add(user_name);
            Controls.Add(user_nme_label);
            Controls.Add(database);
            Controls.Add(database_label);
            Controls.Add(port_label);
            Controls.Add(server);
            Controls.Add(server_label);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Database_set_connection";
            Text = "Připojení do databáze";
            ((System.ComponentModel.ISupportInitialize)port).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label server_label;
        private TextBox server;
        private Label port_label;
        private TextBox database;
        private Label database_label;
        private TextBox user_name;
        private Label user_nme_label;
        private TextBox password;
        private Label password_label;
        private NumericUpDown port;
        private Button save;
        private ComboBox server_switch;
        private Label adress_label;
        private TextBox other;
        private Label other_label;
    }
}