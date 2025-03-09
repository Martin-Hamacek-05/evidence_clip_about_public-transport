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
            server.Location = new Point(76, 59);
            server.Margin = new Padding(4, 5, 4, 5);
            server.Name = "server";
            server.Size = new Size(141, 31);
            server.TabIndex = 1;
            server.Text = "ftp://127.0.0.1/server/";
            // 
            // user_name
            // 
            user_name.Location = new Point(380, 59);
            user_name.Margin = new Padding(4, 5, 4, 5);
            user_name.Name = "user_name";
            user_name.Size = new Size(141, 31);
            user_name.TabIndex = 2;
            user_name.Text = "pha-KT8D5";
            // 
            // password
            // 
            password.Location = new Point(590, 59);
            password.Margin = new Padding(4, 5, 4, 5);
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(141, 31);
            password.TabIndex = 3;
            // 
            // server_label
            // 
            server_label.AutoSize = true;
            server_label.Location = new Point(13, 64);
            server_label.Margin = new Padding(4, 0, 4, 0);
            server_label.Name = "server_label";
            server_label.Size = new Size(64, 25);
            server_label.TabIndex = 4;
            server_label.Text = "adresa";
            // 
            // login_name_label
            // 
            login_name_label.AutoSize = true;
            login_name_label.Location = new Point(227, 66);
            login_name_label.Margin = new Padding(4, 0, 4, 0);
            login_name_label.Name = "login_name_label";
            login_name_label.Size = new Size(152, 25);
            login_name_label.TabIndex = 5;
            login_name_label.Text = "uživatelské jméno";
            // 
            // password_label
            // 
            password_label.AutoSize = true;
            password_label.Location = new Point(532, 66);
            password_label.Margin = new Padding(4, 0, 4, 0);
            password_label.Name = "password_label";
            password_label.Size = new Size(54, 25);
            password_label.TabIndex = 6;
            password_label.Text = "heslo";
            // 
            // connect_button
            // 
            connect_button.Location = new Point(742, 59);
            connect_button.Margin = new Padding(4, 5, 4, 5);
            connect_button.Name = "connect_button";
            connect_button.Size = new Size(107, 38);
            connect_button.TabIndex = 7;
            connect_button.Text = "připojit";
            connect_button.UseVisualStyleBackColor = true;
            connect_button.Click += connect_button_Click;
            // 
            // list_of_directories
            // 
            list_of_directories.Location = new Point(13, 108);
            list_of_directories.Margin = new Padding(4, 5, 4, 5);
            list_of_directories.Name = "list_of_directories";
            list_of_directories.Size = new Size(834, 602);
            list_of_directories.TabIndex = 8;
            list_of_directories.AfterSelect += list_of_directories_AfterSelect;
            // 
            // directory_name
            // 
            directory_name.Location = new Point(13, 723);
            directory_name.Margin = new Padding(4, 5, 4, 5);
            directory_name.Name = "directory_name";
            directory_name.Size = new Size(323, 31);
            directory_name.TabIndex = 9;
            // 
            // create_directory
            // 
            create_directory.Location = new Point(346, 723);
            create_directory.Margin = new Padding(4, 5, 4, 5);
            create_directory.Name = "create_directory";
            create_directory.Size = new Size(157, 38);
            create_directory.TabIndex = 10;
            create_directory.Text = "Vytvořit adresář";
            create_directory.UseVisualStyleBackColor = true;
            create_directory.Click += create_directory_Click;
            // 
            // delete_selected_directory
            // 
            delete_selected_directory.Enabled = false;
            delete_selected_directory.Location = new Point(512, 723);
            delete_selected_directory.Margin = new Padding(4, 5, 4, 5);
            delete_selected_directory.Name = "delete_selected_directory";
            delete_selected_directory.Size = new Size(221, 38);
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
            file_source.Location = new Point(143, 13);
            file_source.Name = "file_source";
            file_source.Size = new Size(378, 33);
            file_source.TabIndex = 12;
            // 
            // file_source_label
            // 
            file_source_label.AutoSize = true;
            file_source_label.Location = new Point(13, 16);
            file_source_label.Name = "file_source_label";
            file_source_label.Size = new Size(124, 25);
            file_source_label.TabIndex = 13;
            file_source_label.Text = "zdroj souborů";
            // 
            // Ftp_manager
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 768);
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
            Margin = new Padding(4, 5, 4, 5);
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