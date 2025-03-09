namespace evidence_clip_about_public_transport.Win_forms_user_interface.for_owner
{
    partial class Edit_owner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_owner));
            name_label = new Label();
            name_ = new TextBox();
            update_button = new Button();
            delete_button = new Button();
            create_button = new Button();
            cancel_button = new Button();
            id_label = new Label();
            heardquarters_label = new Label();
            heardquarters = new TextBox();
            note_label = new Label();
            note = new RichTextBox();
            SuspendLayout();
            // 
            // name_label
            // 
            name_label.AutoSize = true;
            name_label.Location = new Point(96, 11);
            name_label.Margin = new Padding(2, 0, 2, 0);
            name_label.Name = "name_label";
            name_label.Size = new Size(82, 15);
            name_label.TabIndex = 0;
            name_label.Text = "název majitele";
            // 
            // name_
            // 
            name_.Location = new Point(186, 7);
            name_.Margin = new Padding(2);
            name_.MaxLength = 100;
            name_.Name = "name_";
            name_.Size = new Size(370, 23);
            name_.TabIndex = 0;
            // 
            // update_button
            // 
            update_button.Location = new Point(312, 129);
            update_button.Margin = new Padding(2);
            update_button.Name = "update_button";
            update_button.Size = new Size(78, 23);
            update_button.TabIndex = 4;
            update_button.Text = "Upravit";
            update_button.UseVisualStyleBackColor = true;
            update_button.Click += update_button_Click;
            // 
            // delete_button
            // 
            delete_button.Location = new Point(229, 129);
            delete_button.Margin = new Padding(2);
            delete_button.Name = "delete_button";
            delete_button.Size = new Size(78, 23);
            delete_button.TabIndex = 3;
            delete_button.Text = "Smazat";
            delete_button.UseVisualStyleBackColor = true;
            delete_button.Click += delete_button_Click;
            // 
            // create_button
            // 
            create_button.Location = new Point(394, 129);
            create_button.Margin = new Padding(2);
            create_button.Name = "create_button";
            create_button.Size = new Size(78, 23);
            create_button.TabIndex = 5;
            create_button.Text = "Vytvořit";
            create_button.UseVisualStyleBackColor = true;
            create_button.Click += create_button_Click;
            // 
            // cancel_button
            // 
            cancel_button.Location = new Point(477, 129);
            cancel_button.Margin = new Padding(2);
            cancel_button.Name = "cancel_button";
            cancel_button.Size = new Size(78, 23);
            cancel_button.TabIndex = 6;
            cancel_button.Text = "Storno";
            cancel_button.UseVisualStyleBackColor = true;
            cancel_button.Click += cancel_button_Click;
            // 
            // id_label
            // 
            id_label.AutoSize = true;
            id_label.Location = new Point(65, 97);
            id_label.Margin = new Padding(2, 0, 2, 0);
            id_label.Name = "id_label";
            id_label.Size = new Size(61, 15);
            id_label.TabIndex = 28;
            id_label.Text = "undefined";
            id_label.Visible = false;
            // 
            // heardquarters_label
            // 
            heardquarters_label.AutoSize = true;
            heardquarters_label.Location = new Point(147, 36);
            heardquarters_label.Margin = new Padding(2, 0, 2, 0);
            heardquarters_label.Name = "heardquarters_label";
            heardquarters_label.Size = new Size(32, 15);
            heardquarters_label.TabIndex = 2;
            heardquarters_label.Text = "sídlo";
            // 
            // heardquarters
            // 
            heardquarters.Location = new Point(186, 34);
            heardquarters.Margin = new Padding(2);
            heardquarters.MaxLength = 20;
            heardquarters.Name = "heardquarters";
            heardquarters.Size = new Size(370, 23);
            heardquarters.TabIndex = 1;
            // 
            // note_label
            // 
            note_label.AutoSize = true;
            note_label.Location = new Point(116, 63);
            note_label.Margin = new Padding(2, 0, 2, 0);
            note_label.Name = "note_label";
            note_label.Size = new Size(62, 15);
            note_label.TabIndex = 38;
            note_label.Text = "poznámky";
            // 
            // note
            // 
            note.Location = new Point(186, 61);
            note.Margin = new Padding(2);
            note.Name = "note";
            note.Size = new Size(370, 51);
            note.TabIndex = 2;
            note.Text = "";
            // 
            // Edit_owner
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 161);
            Controls.Add(note);
            Controls.Add(note_label);
            Controls.Add(heardquarters);
            Controls.Add(id_label);
            Controls.Add(cancel_button);
            Controls.Add(create_button);
            Controls.Add(delete_button);
            Controls.Add(update_button);
            Controls.Add(name_);
            Controls.Add(heardquarters_label);
            Controls.Add(name_label);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Edit_owner";
            Text = "Nový dopravce";
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
        private Label heardquarters_label;
        private TextBox heardquarters;
        private Label note_label;
        private RichTextBox note;
    }
}