namespace evidence_clip_about_public_transport.Win_forms_user_interface.for_lines
{
    partial class Edit_line
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_line));
            name_line_label = new Label();
            name_line = new TextBox();
            update_button = new Button();
            delete_button = new Button();
            create_button = new Button();
            cancel_button = new Button();
            id_label = new Label();
            number_of_line_label = new Label();
            number_line = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)number_line).BeginInit();
            SuspendLayout();
            // 
            // name_line_label
            // 
            name_line_label.AutoSize = true;
            name_line_label.Location = new Point(112, 18);
            name_line_label.Margin = new Padding(2, 0, 2, 0);
            name_line_label.Name = "name_line_label";
            name_line_label.Size = new Size(65, 15);
            name_line_label.TabIndex = 0;
            name_line_label.Text = "název linky";
            // 
            // name_line
            // 
            name_line.Location = new Point(186, 16);
            name_line.Margin = new Padding(2);
            name_line.MaxLength = 50;
            name_line.Name = "name_line";
            name_line.Size = new Size(370, 23);
            name_line.TabIndex = 0;
            // 
            // update_button
            // 
            update_button.Location = new Point(312, 81);
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
            delete_button.Location = new Point(229, 81);
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
            create_button.Location = new Point(394, 81);
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
            cancel_button.Location = new Point(477, 81);
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
            id_label.Location = new Point(86, 81);
            id_label.Margin = new Padding(2, 0, 2, 0);
            id_label.Name = "id_label";
            id_label.Size = new Size(61, 15);
            id_label.TabIndex = 28;
            id_label.Text = "undefined";
            id_label.Visible = false;
            // 
            // number_of_line_label
            // 
            number_of_line_label.AutoSize = true;
            number_of_line_label.Location = new Point(119, 47);
            number_of_line_label.Margin = new Padding(2, 0, 2, 0);
            number_of_line_label.Name = "number_of_line_label";
            number_of_line_label.Size = new Size(59, 15);
            number_of_line_label.TabIndex = 2;
            number_of_line_label.Text = "číslo linky";
            // 
            // number_line
            // 
            number_line.Location = new Point(186, 43);
            number_line.Margin = new Padding(2);
            number_line.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            number_line.Minimum = new decimal(new int[] { int.MaxValue, 0, 0, int.MinValue });
            number_line.Name = "number_line";
            number_line.Size = new Size(369, 23);
            number_line.TabIndex = 1;
            // 
            // Edit_line
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 114);
            Controls.Add(id_label);
            Controls.Add(cancel_button);
            Controls.Add(create_button);
            Controls.Add(delete_button);
            Controls.Add(update_button);
            Controls.Add(number_line);
            Controls.Add(name_line);
            Controls.Add(number_of_line_label);
            Controls.Add(name_line_label);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Edit_line";
            Text = "Nová linka";
            ((System.ComponentModel.ISupportInitialize)number_line).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label name_line_label;
        private TextBox name_line;
        private Button update_button;
        private Button delete_button;
        private Button create_button;
        private Button cancel_button;
        private Label id_label;
        private Label number_of_line_label;
        private NumericUpDown number_line;
    }
}