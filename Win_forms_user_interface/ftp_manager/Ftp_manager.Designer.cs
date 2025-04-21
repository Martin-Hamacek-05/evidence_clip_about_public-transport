namespace evidence_clip_about_public_transport.Win_forms_user_interface.ftp_manager
{
    partial class Ftp_manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ftp_manager));
            server = new TextBox();
            user_name = new TextBox();
            password = new TextBox();
            server_label = new Label();
            login_name_label = new Label();
            password_label = new Label();
            connect_button = new Button();
            list_of_directories = new TreeView();
            directory_name = new TextBox();
            create_directory = new Button();
            delete_selected_directory = new Button();
            file_source = new ComboBox();
            file_source_label = new Label();
            SuspendLayout();
            // 
            // server
            // 
            server.Location = new Point(53, 35);
            server.Name = "server";
            server.Size = new Size(100, 23);
            server.TabIndex = 1;
            server.Text = "ftp://127.0.0.1/server/";
            // 
            // user_name
            // 
            user_name.Location = new Point(266, 35);
            user_name.Name = "user_name";
            user_name.Size = new Size(100, 23);
            user_name.TabIndex = 2;
            user_name.Text = "pha-KT8D5";
            // 
            // password
            // 
            password.Location = new Point(413, 35);
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(100, 23);
            password.TabIndex = 3;
            // 
            // server_label
            // 
            server_label.AutoSize = true;
            server_label.Location = new Point(9, 38);
            server_label.Name = "server_label";
            server_label.Size = new Size(41, 15);
            server_label.TabIndex = 4;
            server_label.Text = "adresa";
            // 
            // login_name_label
            // 
            login_name_label.AutoSize = true;
            login_name_label.Location = new Point(159, 40);
            login_name_label.Name = "login_name_label";
            login_name_label.Size = new Size(101, 15);
            login_name_label.TabIndex = 5;
            login_name_label.Text = "uživatelské jméno";
            // 
            // password_label
            // 
            password_label.AutoSize = true;
            password_label.Location = new Point(372, 40);
            password_label.Name = "password_label";
            password_label.Size = new Size(35, 15);
            password_label.TabIndex = 6;
            password_label.Text = "heslo";
            // 
            // connect_button
            // 
            connect_button.Location = new Point(519, 35);
            connect_button.Name = "connect_button";
            connect_button.Size = new Size(75, 23);
            connect_button.TabIndex = 7;
            connect_button.Text = "nastavit";
            connect_button.UseVisualStyleBackColor = true;
            connect_button.Click += connect_button_Click;
            // 
            // list_of_directories
            // 
            list_of_directories.Location = new Point(9, 65);
            list_of_directories.Name = "list_of_directories";
            list_of_directories.Size = new Size(585, 363);
            list_of_directories.TabIndex = 8;
            list_of_directories.AfterSelect += list_of_directories_AfterSelect;
            // 
            // directory_name
            // 
            directory_name.Location = new Point(9, 434);
            directory_name.Name = "directory_name";
            directory_name.Size = new Size(227, 23);
            directory_name.TabIndex = 9;
            // 
            // create_directory
            // 
            create_directory.Location = new Point(242, 434);
            create_directory.Name = "create_directory";
            create_directory.Size = new Size(110, 23);
            create_directory.TabIndex = 10;
            create_directory.Text = "Vytvořit adresář";
            create_directory.UseVisualStyleBackColor = true;
            create_directory.Click += create_directory_Click;
            // 
            // delete_selected_directory
            // 
            delete_selected_directory.Enabled = false;
            delete_selected_directory.Location = new Point(358, 434);
            delete_selected_directory.Name = "delete_selected_directory";
            delete_selected_directory.Size = new Size(155, 23);
            delete_selected_directory.TabIndex = 11;
            delete_selected_directory.Text = "Smazat vybraný adresář";
            delete_selected_directory.UseVisualStyleBackColor = true;
            delete_selected_directory.Click += delete_selected_directory_Click;
            // 
            // file_source
            // 
            file_source.DropDownStyle = ComboBoxStyle.DropDownList;
            file_source.FormattingEnabled = true;
            file_source.Items.AddRange(new object[] { "Místní úložiště", "FTP" });
            file_source.Location = new Point(100, 8);
            file_source.Margin = new Padding(2, 2, 2, 2);
            file_source.Name = "file_source";
            file_source.Size = new Size(266, 23);
            file_source.TabIndex = 12;
            // 
            // file_source_label
            // 
            file_source_label.AutoSize = true;
            file_source_label.Location = new Point(9, 10);
            file_source_label.Margin = new Padding(2, 0, 2, 0);
            file_source_label.Name = "file_source_label";
            file_source_label.Size = new Size(80, 15);
            file_source_label.TabIndex = 13;
            file_source_label.Text = "zdroj souborů";
            // 
            // Ftp_manager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 461);
            Controls.Add(file_source_label);
            Controls.Add(file_source);
            Controls.Add(delete_selected_directory);
            Controls.Add(create_directory);
            Controls.Add(directory_name);
            Controls.Add(list_of_directories);
            Controls.Add(connect_button);
            Controls.Add(password_label);
            Controls.Add(login_name_label);
            Controls.Add(server_label);
            Controls.Add(password);
            Controls.Add(user_name);
            Controls.Add(server);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Ftp_manager";
            Text = "Správce úložiště";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox server;
        private TextBox user_name;
        private TextBox password;
        private Label server_label;
        private Label login_name_label;
        private Label password_label;
        private Button connect_button;
        private TreeView list_of_directories;
        private TextBox directory_name;
        private Button create_directory;
        private Button delete_selected_directory;
        private ComboBox file_source;
        private Label file_source_label;
    }
}