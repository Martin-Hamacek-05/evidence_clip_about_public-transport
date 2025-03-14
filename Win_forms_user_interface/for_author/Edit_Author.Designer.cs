namespace evidence_clip_about_public_transport.Win_forms_user_interface.Author
{
    partial class Edit_Author
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_Author));
            name_label = new Label();
            name_ = new TextBox();
            update_button = new Button();
            delete_button = new Button();
            create_button = new Button();
            cancel_button = new Button();
            id_label = new Label();
            password_label = new Label();
            password_ = new TextBox();
            is_admin = new CheckBox();
            count_of_access = new NumericUpDown();
            count_of_access_label = new Label();
            reset_count_of_access_button = new Button();
            email_label = new Label();
            email_ = new TextBox();
            date_created = new DateTimePicker();
            date_created_label = new Label();
            change_password_button = new Button();
            message_label = new Label();
            message = new TextBox();
            ((System.ComponentModel.ISupportInitialize)count_of_access).BeginInit();
            SuspendLayout();
            // 
            // name_label
            // 
            name_label.AutoSize = true;
            name_label.Location = new Point(76, 9);
            name_label.Margin = new Padding(2, 0, 2, 0);
            name_label.Name = "name_label";
            name_label.Size = new Size(101, 15);
            name_label.TabIndex = 0;
            name_label.Text = "uživatelské jméno";
            // 
            // name_
            // 
            name_.Location = new Point(186, 7);
            name_.Margin = new Padding(2);
            name_.MaxLength = 100;
            name_.Name = "name_";
            name_.Size = new Size(370, 23);
            name_.TabIndex = 7;
            // 
            // update_button
            // 
            update_button.Location = new Point(312, 277);
            update_button.Margin = new Padding(2);
            update_button.Name = "update_button";
            update_button.Size = new Size(78, 24);
            update_button.TabIndex = 13;
            update_button.Text = "Upravit";
            update_button.UseVisualStyleBackColor = true;
            update_button.Click += update_button_Click;
            // 
            // delete_button
            // 
            delete_button.Location = new Point(229, 277);
            delete_button.Margin = new Padding(2);
            delete_button.Name = "delete_button";
            delete_button.Size = new Size(78, 24);
            delete_button.TabIndex = 14;
            delete_button.Text = "Smazat";
            delete_button.UseVisualStyleBackColor = true;
            delete_button.Click += delete_button_Click;
            // 
            // create_button
            // 
            create_button.Location = new Point(394, 277);
            create_button.Margin = new Padding(2);
            create_button.Name = "create_button";
            create_button.Size = new Size(78, 24);
            create_button.TabIndex = 15;
            create_button.Text = "Vytvořit";
            create_button.UseVisualStyleBackColor = true;
            create_button.Click += create_button_Click;
            // 
            // cancel_button
            // 
            cancel_button.Location = new Point(477, 277);
            cancel_button.Margin = new Padding(2);
            cancel_button.Name = "cancel_button";
            cancel_button.Size = new Size(78, 24);
            cancel_button.TabIndex = 16;
            cancel_button.Text = "Storno";
            cancel_button.UseVisualStyleBackColor = true;
            cancel_button.Click += cancel_button_Click;
            // 
            // id_label
            // 
            id_label.AutoSize = true;
            id_label.Location = new Point(491, 260);
            id_label.Margin = new Padding(2, 0, 2, 0);
            id_label.Name = "id_label";
            id_label.Size = new Size(61, 15);
            id_label.TabIndex = 28;
            id_label.Text = "undefined";
            id_label.Visible = false;
            // 
            // password_label
            // 
            password_label.AutoSize = true;
            password_label.Location = new Point(144, 36);
            password_label.Margin = new Padding(2, 0, 2, 0);
            password_label.Name = "password_label";
            password_label.Size = new Size(35, 15);
            password_label.TabIndex = 2;
            password_label.Text = "heslo";
            // 
            // password_
            // 
            password_.Enabled = false;
            password_.Location = new Point(186, 34);
            password_.Margin = new Padding(2);
            password_.MaxLength = 10;
            password_.Name = "password_";
            password_.PasswordChar = '*';
            password_.Size = new Size(255, 23);
            password_.TabIndex = 37;
            password_.Text = "Default";
            // 
            // is_admin
            // 
            is_admin.AutoSize = true;
            is_admin.Location = new Point(186, 61);
            is_admin.Margin = new Padding(2);
            is_admin.Name = "is_admin";
            is_admin.Size = new Size(72, 19);
            is_admin.TabIndex = 38;
            is_admin.Text = "je admin";
            is_admin.UseVisualStyleBackColor = true;
            // 
            // count_of_access
            // 
            count_of_access.Enabled = false;
            count_of_access.Location = new Point(186, 84);
            count_of_access.Margin = new Padding(2);
            count_of_access.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            count_of_access.Name = "count_of_access";
            count_of_access.Size = new Size(286, 23);
            count_of_access.TabIndex = 39;
            // 
            // count_of_access_label
            // 
            count_of_access_label.AutoSize = true;
            count_of_access_label.Location = new Point(92, 86);
            count_of_access_label.Margin = new Padding(2, 0, 2, 0);
            count_of_access_label.Name = "count_of_access_label";
            count_of_access_label.Size = new Size(84, 15);
            count_of_access_label.TabIndex = 40;
            count_of_access_label.Text = "počet přístupů";
            // 
            // reset_count_of_access_button
            // 
            reset_count_of_access_button.Enabled = false;
            reset_count_of_access_button.Location = new Point(478, 83);
            reset_count_of_access_button.Margin = new Padding(2);
            reset_count_of_access_button.Name = "reset_count_of_access_button";
            reset_count_of_access_button.Size = new Size(78, 24);
            reset_count_of_access_button.TabIndex = 41;
            reset_count_of_access_button.Text = "resetovat";
            reset_count_of_access_button.UseVisualStyleBackColor = true;
            reset_count_of_access_button.Click += reset_count_of_access_button_Click;
            // 
            // email_label
            // 
            email_label.AutoSize = true;
            email_label.Location = new Point(144, 112);
            email_label.Margin = new Padding(2, 0, 2, 0);
            email_label.Name = "email_label";
            email_label.Size = new Size(36, 15);
            email_label.TabIndex = 42;
            email_label.Text = "email";
            // 
            // email_
            // 
            email_.Location = new Point(186, 111);
            email_.Margin = new Padding(2);
            email_.MaxLength = 128;
            email_.Name = "email_";
            email_.Size = new Size(370, 23);
            email_.TabIndex = 43;
            // 
            // date_created
            // 
            date_created.Enabled = false;
            date_created.Location = new Point(186, 138);
            date_created.Margin = new Padding(2);
            date_created.Name = "date_created";
            date_created.Size = new Size(370, 23);
            date_created.TabIndex = 44;
            // 
            // date_created_label
            // 
            date_created_label.AutoSize = true;
            date_created_label.Location = new Point(83, 141);
            date_created_label.Margin = new Padding(2, 0, 2, 0);
            date_created_label.Name = "date_created_label";
            date_created_label.Size = new Size(94, 15);
            date_created_label.TabIndex = 45;
            date_created_label.Text = "datum vytvoření";
            // 
            // change_password_button
            // 
            change_password_button.Location = new Point(444, 33);
            change_password_button.Margin = new Padding(2);
            change_password_button.Name = "change_password_button";
            change_password_button.Size = new Size(111, 24);
            change_password_button.TabIndex = 46;
            change_password_button.Text = "změnit heslo";
            change_password_button.UseVisualStyleBackColor = true;
            change_password_button.Click += change_password_button_Click;
            // 
            // message_label
            // 
            message_label.AutoSize = true;
            message_label.Location = new Point(104, 167);
            message_label.Margin = new Padding(2, 0, 2, 0);
            message_label.Name = "message_label";
            message_label.Size = new Size(72, 15);
            message_label.TabIndex = 47;
            message_label.Text = "podrobnosti";
            // 
            // message
            // 
            message.Location = new Point(186, 167);
            message.Multiline = true;
            message.Name = "message";
            message.Size = new Size(369, 84);
            message.TabIndex = 49;
            // 
            // Edit_Author
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 318);
            Controls.Add(message);
            Controls.Add(message_label);
            Controls.Add(change_password_button);
            Controls.Add(date_created_label);
            Controls.Add(date_created);
            Controls.Add(email_);
            Controls.Add(email_label);
            Controls.Add(reset_count_of_access_button);
            Controls.Add(count_of_access_label);
            Controls.Add(count_of_access);
            Controls.Add(is_admin);
            Controls.Add(password_);
            Controls.Add(id_label);
            Controls.Add(cancel_button);
            Controls.Add(create_button);
            Controls.Add(delete_button);
            Controls.Add(update_button);
            Controls.Add(name_);
            Controls.Add(password_label);
            Controls.Add(name_label);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Edit_Author";
            Text = "Nový uživatel";
            ((System.ComponentModel.ISupportInitialize)count_of_access).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label name_label;
        private TextBox name_;
        private Button update_button;
        private Button delete_button;
        private Button create_button;
        private Button cancel_button;
        private Label id_label;
        private Label password_label;
        private TextBox password_;
        private CheckBox is_admin;
        private NumericUpDown count_of_access;
        private Label count_of_access_label;
        private Button reset_count_of_access_button;
        private Label email_label;
        private TextBox email_;
        private DateTimePicker date_created;
        private Label date_created_label;
        private Button change_password_button;
        private Label message_label;
        private TextBox message;
    }
}