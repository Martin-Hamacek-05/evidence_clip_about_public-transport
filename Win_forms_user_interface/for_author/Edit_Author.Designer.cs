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
            message = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)count_of_access).BeginInit();
            SuspendLayout();
            // 
            // name_label
            // 
            name_label.AutoSize = true;
            name_label.Location = new Point(109, 15);
            name_label.Name = "name_label";
            name_label.Size = new Size(152, 25);
            name_label.TabIndex = 0;
            name_label.Text = "uživatelské jméno";
            // 
            // name_
            // 
            name_.Location = new Point(266, 12);
            name_.MaxLength = 100;
            name_.Name = "name_";
            name_.Size = new Size(527, 31);
            name_.TabIndex = 7;
            // 
            // update_button
            // 
            update_button.Location = new Point(446, 462);
            update_button.Name = "update_button";
            update_button.Size = new Size(111, 40);
            update_button.TabIndex = 13;
            update_button.Text = "Upravit";
            update_button.UseVisualStyleBackColor = true;
            update_button.Click += update_button_Click;
            // 
            // delete_button
            // 
            delete_button.Location = new Point(327, 462);
            delete_button.Name = "delete_button";
            delete_button.Size = new Size(111, 40);
            delete_button.TabIndex = 14;
            delete_button.Text = "Smazat";
            delete_button.UseVisualStyleBackColor = true;
            delete_button.Click += delete_button_Click;
            // 
            // create_button
            // 
            create_button.Location = new Point(563, 462);
            create_button.Name = "create_button";
            create_button.Size = new Size(111, 40);
            create_button.TabIndex = 15;
            create_button.Text = "Vytvořit";
            create_button.UseVisualStyleBackColor = true;
            create_button.Click += create_button_Click;
            // 
            // cancel_button
            // 
            cancel_button.Location = new Point(681, 462);
            cancel_button.Name = "cancel_button";
            cancel_button.Size = new Size(111, 40);
            cancel_button.TabIndex = 16;
            cancel_button.Text = "Storno";
            cancel_button.UseVisualStyleBackColor = true;
            cancel_button.Click += cancel_button_Click;
            // 
            // id_label
            // 
            id_label.AutoSize = true;
            id_label.Location = new Point(701, 433);
            id_label.Name = "id_label";
            id_label.Size = new Size(92, 25);
            id_label.TabIndex = 28;
            id_label.Text = "undefined";
            id_label.Visible = false;
            // 
            // password_label
            // 
            password_label.AutoSize = true;
            password_label.Location = new Point(206, 60);
            password_label.Name = "password_label";
            password_label.Size = new Size(54, 25);
            password_label.TabIndex = 2;
            password_label.Text = "heslo";
            // 
            // password_
            // 
            password_.Enabled = false;
            password_.Location = new Point(266, 57);
            password_.MaxLength = 10;
            password_.Name = "password_";
            password_.PasswordChar = '*';
            password_.Size = new Size(363, 31);
            password_.TabIndex = 37;
            password_.Text = "Default";
            // 
            // is_admin
            // 
            is_admin.AutoSize = true;
            is_admin.Location = new Point(266, 102);
            is_admin.Name = "is_admin";
            is_admin.Size = new Size(106, 29);
            is_admin.TabIndex = 38;
            is_admin.Text = "je admin";
            is_admin.UseVisualStyleBackColor = true;
            // 
            // count_of_access
            // 
            count_of_access.Enabled = false;
            count_of_access.Location = new Point(266, 140);
            count_of_access.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            count_of_access.Name = "count_of_access";
            count_of_access.Size = new Size(409, 31);
            count_of_access.TabIndex = 39;
            // 
            // count_of_access_label
            // 
            count_of_access_label.AutoSize = true;
            count_of_access_label.Location = new Point(131, 143);
            count_of_access_label.Name = "count_of_access_label";
            count_of_access_label.Size = new Size(128, 25);
            count_of_access_label.TabIndex = 40;
            count_of_access_label.Text = "počet přístupů";
            // 
            // reset_count_of_access_button
            // 
            reset_count_of_access_button.Enabled = false;
            reset_count_of_access_button.Location = new Point(683, 138);
            reset_count_of_access_button.Name = "reset_count_of_access_button";
            reset_count_of_access_button.Size = new Size(111, 40);
            reset_count_of_access_button.TabIndex = 41;
            reset_count_of_access_button.Text = "resetovat";
            reset_count_of_access_button.UseVisualStyleBackColor = true;
            reset_count_of_access_button.Click += reset_count_of_access_button_Click;
            // 
            // email_label
            // 
            email_label.AutoSize = true;
            email_label.Location = new Point(206, 187);
            email_label.Name = "email_label";
            email_label.Size = new Size(54, 25);
            email_label.TabIndex = 42;
            email_label.Text = "email";
            // 
            // email_
            // 
            email_.Location = new Point(266, 185);
            email_.MaxLength = 10;
            email_.Name = "email_";
            email_.Size = new Size(527, 31);
            email_.TabIndex = 43;
            // 
            // date_created
            // 
            date_created.Enabled = false;
            date_created.Location = new Point(266, 230);
            date_created.Name = "date_created";
            date_created.Size = new Size(527, 31);
            date_created.TabIndex = 44;
            // 
            // date_created_label
            // 
            date_created_label.AutoSize = true;
            date_created_label.Location = new Point(119, 235);
            date_created_label.Name = "date_created_label";
            date_created_label.Size = new Size(142, 25);
            date_created_label.TabIndex = 45;
            date_created_label.Text = "datum vytvoření";
            // 
            // change_password_button
            // 
            change_password_button.Location = new Point(634, 55);
            change_password_button.Name = "change_password_button";
            change_password_button.Size = new Size(159, 40);
            change_password_button.TabIndex = 46;
            change_password_button.Text = "změnit heslo";
            change_password_button.UseVisualStyleBackColor = true;
            change_password_button.Click += change_password_button_Click;
            // 
            // message_label
            // 
            message_label.AutoSize = true;
            message_label.Location = new Point(149, 278);
            message_label.Name = "message_label";
            message_label.Size = new Size(112, 25);
            message_label.TabIndex = 47;
            message_label.Text = "podrobnosti";
            // 
            // message
            // 
            message.Enabled = false;
            message.Location = new Point(266, 275);
            message.Name = "message";
            message.Size = new Size(527, 156);
            message.TabIndex = 48;
            message.Text = "";
            // 
            // Edit_Author
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 530);
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
        private RichTextBox message;
    }
}