namespace evidence_clip_about_public_transport.Win_forms_user_interface.for_stops
{
    partial class Mass_rename_stop
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
            previours_name_label = new Label();
            new_name_label = new Label();
            previours_name = new TextBox();
            new_name = new TextBox();
            save_button = new Button();
            SuspendLayout();
            // 
            // previours_name_label
            // 
            previours_name_label.AutoSize = true;
            previours_name_label.Location = new Point(9, 15);
            previours_name_label.Margin = new Padding(2, 0, 2, 0);
            previours_name_label.Name = "previours_name_label";
            previours_name_label.Size = new Size(84, 15);
            previours_name_label.TabIndex = 0;
            previours_name_label.Text = "původní název";
            // 
            // new_name_label
            // 
            new_name_label.AutoSize = true;
            new_name_label.Location = new Point(27, 41);
            new_name_label.Margin = new Padding(2, 0, 2, 0);
            new_name_label.Name = "new_name_label";
            new_name_label.Size = new Size(66, 15);
            new_name_label.TabIndex = 1;
            new_name_label.Text = "nový název";
            // 
            // previours_name
            // 
            previours_name.Location = new Point(102, 12);
            previours_name.Margin = new Padding(2, 2, 2, 2);
            previours_name.MaxLength = 100;
            previours_name.Name = "previours_name";
            previours_name.Size = new Size(194, 23);
            previours_name.TabIndex = 0;
            // 
            // new_name
            // 
            new_name.Location = new Point(102, 39);
            new_name.Margin = new Padding(2, 2, 2, 2);
            new_name.MaxLength = 100;
            new_name.Name = "new_name";
            new_name.Size = new Size(194, 23);
            new_name.TabIndex = 1;
            // 
            // save_button
            // 
            save_button.Location = new Point(218, 66);
            save_button.Margin = new Padding(2, 2, 2, 2);
            save_button.Name = "save_button";
            save_button.Size = new Size(78, 23);
            save_button.TabIndex = 2;
            save_button.Text = "Uložit";
            save_button.UseVisualStyleBackColor = true;
            save_button.Click += save_button_Click;
            // 
            // Mass_rename_stop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 102);
            Controls.Add(save_button);
            Controls.Add(new_name);
            Controls.Add(previours_name);
            Controls.Add(new_name_label);
            Controls.Add(previours_name_label);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2, 2, 2, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Mass_rename_stop";
            Text = "Hromadné přejmenování";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label previours_name_label;
        private Label new_name_label;
        private TextBox previours_name;
        private TextBox new_name;
        private Button save_button;
    }
}