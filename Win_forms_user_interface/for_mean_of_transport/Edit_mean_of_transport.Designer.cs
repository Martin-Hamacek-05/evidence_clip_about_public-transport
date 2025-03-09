namespace evidence_clip_about_public_transport.Win_forms_user_interface.for_mean_of_transport
{
    partial class Edit_mean_of_transport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_mean_of_transport));
            name_label = new Label();
            name_ = new TextBox();
            update_button = new Button();
            delete_button = new Button();
            create_button = new Button();
            cancel_button = new Button();
            id_label = new Label();
            short_name_label = new Label();
            short_name = new TextBox();
            SuspendLayout();
            // 
            // name_label
            // 
            name_label.AutoSize = true;
            name_label.Location = new Point(10, 9);
            name_label.Margin = new Padding(2, 0, 2, 0);
            name_label.Name = "name_label";
            name_label.Size = new Size(161, 15);
            name_label.TabIndex = 0;
            name_label.Text = "název dopravního prostředku";
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
            update_button.Location = new Point(312, 76);
            update_button.Margin = new Padding(2);
            update_button.Name = "update_button";
            update_button.Size = new Size(78, 23);
            update_button.TabIndex = 3;
            update_button.Text = "Upravit";
            update_button.UseVisualStyleBackColor = true;
            update_button.Click += update_button_Click;
            // 
            // delete_button
            // 
            delete_button.Location = new Point(229, 76);
            delete_button.Margin = new Padding(2);
            delete_button.Name = "delete_button";
            delete_button.Size = new Size(78, 23);
            delete_button.TabIndex = 2;
            delete_button.Text = "Smazat";
            delete_button.UseVisualStyleBackColor = true;
            delete_button.Click += delete_button_Click;
            // 
            // create_button
            // 
            create_button.Location = new Point(394, 76);
            create_button.Margin = new Padding(2);
            create_button.Name = "create_button";
            create_button.Size = new Size(78, 23);
            create_button.TabIndex = 4;
            create_button.Text = "Vytvořit";
            create_button.UseVisualStyleBackColor = true;
            create_button.Click += create_button_Click;
            // 
            // cancel_button
            // 
            cancel_button.Location = new Point(477, 76);
            cancel_button.Margin = new Padding(2);
            cancel_button.Name = "cancel_button";
            cancel_button.Size = new Size(78, 23);
            cancel_button.TabIndex = 5;
            cancel_button.Text = "Storno";
            cancel_button.UseVisualStyleBackColor = true;
            cancel_button.Click += cancel_button_Click;
            // 
            // id_label
            // 
            id_label.AutoSize = true;
            id_label.Location = new Point(50, 65);
            id_label.Margin = new Padding(2, 0, 2, 0);
            id_label.Name = "id_label";
            id_label.Size = new Size(61, 15);
            id_label.TabIndex = 28;
            id_label.Text = "undefined";
            id_label.Visible = false;
            // 
            // short_name_label
            // 
            short_name_label.AutoSize = true;
            short_name_label.Location = new Point(91, 36);
            short_name_label.Margin = new Padding(2, 0, 2, 0);
            short_name_label.Name = "short_name_label";
            short_name_label.Size = new Size(86, 15);
            short_name_label.TabIndex = 2;
            short_name_label.Text = "zkrácený název";
            // 
            // short_name
            // 
            short_name.Location = new Point(186, 34);
            short_name.Margin = new Padding(2);
            short_name.MaxLength = 10;
            short_name.Name = "short_name";
            short_name.Size = new Size(370, 23);
            short_name.TabIndex = 1;
            // 
            // Edit_mean_of_transport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 107);
            Controls.Add(short_name);
            Controls.Add(id_label);
            Controls.Add(cancel_button);
            Controls.Add(create_button);
            Controls.Add(delete_button);
            Controls.Add(update_button);
            Controls.Add(name_);
            Controls.Add(short_name_label);
            Controls.Add(name_label);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Edit_mean_of_transport";
            Text = "Nový dopravní prostředek";
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
        private Label short_name_label;
        private TextBox short_name;
    
}
}