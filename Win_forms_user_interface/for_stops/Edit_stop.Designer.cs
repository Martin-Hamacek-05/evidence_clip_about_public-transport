namespace evidence_clip_about_public_transport.Win_forms_user_interface.for_stops
{
    partial class Edit_stop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_stop));
            name_stop_label = new Label();
            name_stop = new TextBox();
            update_button = new Button();
            delete_button = new Button();
            create_button = new Button();
            cancel_button = new Button();
            id_label = new Label();
            number_of_stop_label = new Label();
            platform = new TextBox();
            platform_label = new Label();
            direction = new TextBox();
            direction_label = new Label();
            is_operation = new CheckBox();
            is_row_rise = new CheckBox();
            note = new RichTextBox();
            note_label = new Label();
            number_of_stop = new TextBox();
            SuspendLayout();
            // 
            // name_stop_label
            // 
            name_stop_label.AutoSize = true;
            name_stop_label.Location = new Point(92, 9);
            name_stop_label.Margin = new Padding(2, 0, 2, 0);
            name_stop_label.Name = "name_stop_label";
            name_stop_label.Size = new Size(84, 15);
            name_stop_label.TabIndex = 0;
            name_stop_label.Text = "název zastávky";
            // 
            // name_stop
            // 
            name_stop.Location = new Point(186, 7);
            name_stop.Margin = new Padding(2);
            name_stop.MaxLength = 100;
            name_stop.Name = "name_stop";
            name_stop.Size = new Size(370, 23);
            name_stop.TabIndex = 0;
            // 
            // update_button
            // 
            update_button.Location = new Point(312, 245);
            update_button.Margin = new Padding(2);
            update_button.Name = "update_button";
            update_button.Size = new Size(78, 23);
            update_button.TabIndex = 8;
            update_button.Text = "Upravit";
            update_button.UseVisualStyleBackColor = true;
            update_button.Click += update_button_Click;
            // 
            // delete_button
            // 
            delete_button.Location = new Point(229, 245);
            delete_button.Margin = new Padding(2);
            delete_button.Name = "delete_button";
            delete_button.Size = new Size(78, 23);
            delete_button.TabIndex = 7;
            delete_button.Text = "Smazat";
            delete_button.UseVisualStyleBackColor = true;
            delete_button.Click += delete_button_Click;
            // 
            // create_button
            // 
            create_button.Location = new Point(394, 245);
            create_button.Margin = new Padding(2);
            create_button.Name = "create_button";
            create_button.Size = new Size(78, 23);
            create_button.TabIndex = 9;
            create_button.Text = "Vytvořit";
            create_button.UseVisualStyleBackColor = true;
            create_button.Click += create_button_Click;
            // 
            // cancel_button
            // 
            cancel_button.Location = new Point(477, 245);
            cancel_button.Margin = new Padding(2);
            cancel_button.Name = "cancel_button";
            cancel_button.Size = new Size(78, 23);
            cancel_button.TabIndex = 10;
            cancel_button.Text = "Storno";
            cancel_button.UseVisualStyleBackColor = true;
            cancel_button.Click += cancel_button_Click;
            // 
            // id_label
            // 
            id_label.AutoSize = true;
            id_label.Location = new Point(491, 228);
            id_label.Margin = new Padding(2, 0, 2, 0);
            id_label.Name = "id_label";
            id_label.Size = new Size(61, 15);
            id_label.TabIndex = 28;
            id_label.Text = "undefined";
            id_label.Visible = false;
            // 
            // number_of_stop_label
            // 
            number_of_stop_label.AutoSize = true;
            number_of_stop_label.Location = new Point(99, 36);
            number_of_stop_label.Margin = new Padding(2, 0, 2, 0);
            number_of_stop_label.Name = "number_of_stop_label";
            number_of_stop_label.Size = new Size(78, 15);
            number_of_stop_label.TabIndex = 2;
            number_of_stop_label.Text = "číslo zastávky";
            // 
            // platform
            // 
            platform.Location = new Point(186, 61);
            platform.Margin = new Padding(2);
            platform.MaxLength = 20;
            platform.Name = "platform";
            platform.Size = new Size(370, 23);
            platform.TabIndex = 2;
            // 
            // platform_label
            // 
            platform_label.AutoSize = true;
            platform_label.Location = new Point(117, 62);
            platform_label.Margin = new Padding(2, 0, 2, 0);
            platform_label.Name = "platform_label";
            platform_label.Size = new Size(61, 15);
            platform_label.TabIndex = 29;
            platform_label.Text = "nástupiště";
            // 
            // direction
            // 
            direction.Location = new Point(186, 88);
            direction.Margin = new Padding(2);
            direction.MaxLength = 50;
            direction.Name = "direction";
            direction.Size = new Size(370, 23);
            direction.TabIndex = 3;
            // 
            // direction_label
            // 
            direction_label.AutoSize = true;
            direction_label.Location = new Point(146, 90);
            direction_label.Margin = new Padding(2, 0, 2, 0);
            direction_label.Name = "direction_label";
            direction_label.Size = new Size(33, 15);
            direction_label.TabIndex = 31;
            direction_label.Text = "směr";
            // 
            // is_operation
            // 
            is_operation.AutoSize = true;
            is_operation.Location = new Point(186, 116);
            is_operation.Margin = new Padding(2);
            is_operation.Name = "is_operation";
            is_operation.Size = new Size(90, 19);
            is_operation.TabIndex = 4;
            is_operation.Text = "je v provozu";
            is_operation.UseVisualStyleBackColor = true;
            // 
            // is_row_rise
            // 
            is_row_rise.AutoSize = true;
            is_row_rise.Location = new Point(286, 116);
            is_row_rise.Margin = new Padding(2);
            is_row_rise.Name = "is_row_rise";
            is_row_rise.Size = new Size(158, 19);
            is_row_rise.TabIndex = 5;
            is_row_rise.Text = "je bezbariérově přístupná";
            is_row_rise.UseVisualStyleBackColor = true;
            // 
            // note
            // 
            note.Location = new Point(186, 137);
            note.Margin = new Padding(2);
            note.Name = "note";
            note.Size = new Size(370, 88);
            note.TabIndex = 6;
            note.Text = "";
            // 
            // note_label
            // 
            note_label.AutoSize = true;
            note_label.Location = new Point(116, 139);
            note_label.Margin = new Padding(2, 0, 2, 0);
            note_label.Name = "note_label";
            note_label.Size = new Size(62, 15);
            note_label.TabIndex = 36;
            note_label.Text = "poznámky";
            // 
            // number_of_stop
            // 
            number_of_stop.Location = new Point(186, 34);
            number_of_stop.Margin = new Padding(2);
            number_of_stop.MaxLength = 20;
            number_of_stop.Name = "number_of_stop";
            number_of_stop.Size = new Size(370, 23);
            number_of_stop.TabIndex = 1;
            // 
            // Edit_stop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 279);
            Controls.Add(number_of_stop);
            Controls.Add(note_label);
            Controls.Add(note);
            Controls.Add(is_row_rise);
            Controls.Add(is_operation);
            Controls.Add(direction);
            Controls.Add(direction_label);
            Controls.Add(platform);
            Controls.Add(platform_label);
            Controls.Add(id_label);
            Controls.Add(cancel_button);
            Controls.Add(create_button);
            Controls.Add(delete_button);
            Controls.Add(update_button);
            Controls.Add(name_stop);
            Controls.Add(number_of_stop_label);
            Controls.Add(name_stop_label);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Edit_stop";
            Text = "Nová zastávka";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label name_stop_label;
        private TextBox name_stop;
        private Button update_button;
        private Button delete_button;
        private Button create_button;
        private Button cancel_button;
        private Label id_label;
        private Label number_of_stop_label;
        private TextBox platform;
        private Label platform_label;
        private TextBox direction;
        private Label direction_label;
        private CheckBox is_operation;
        private CheckBox is_row_rise;
        private RichTextBox note;
        private Label note_label;
        private TextBox number_of_stop;
    }
}
