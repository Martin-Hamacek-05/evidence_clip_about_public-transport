namespace evidence_clip_about_public_transport.Win_forms_user_interface.other
{
    partial class Backup_import
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
            load_file_line = new Button();
            select_file_label = new Label();
            path_for_line = new TextBox();
            select_file_line = new Button();
            table_name_combobox = new ComboBox();
            SuspendLayout();
            // 
            // load_file_line
            // 
            load_file_line.Location = new Point(578, 51);
            load_file_line.Name = "load_file_line";
            load_file_line.Size = new Size(111, 38);
            load_file_line.TabIndex = 1;
            load_file_line.Text = "načíst";
            load_file_line.UseVisualStyleBackColor = true;
            load_file_line.Click += load_file_line_Click;
            // 
            // select_file_label
            // 
            select_file_label.AutoSize = true;
            select_file_label.Location = new Point(9, 58);
            select_file_label.Name = "select_file_label";
            select_file_label.Size = new Size(133, 25);
            select_file_label.TabIndex = 4;
            select_file_label.Text = "vyberte soubor";
            // 
            // path_for_line
            // 
            path_for_line.Location = new Point(148, 55);
            path_for_line.Name = "path_for_line";
            path_for_line.Size = new Size(303, 31);
            path_for_line.TabIndex = 5;
            // 
            // select_file_line
            // 
            select_file_line.Location = new Point(461, 51);
            select_file_line.Name = "select_file_line";
            select_file_line.Size = new Size(111, 38);
            select_file_line.TabIndex = 6;
            select_file_line.Text = "vybrat";
            select_file_line.UseVisualStyleBackColor = true;
            select_file_line.Click += select_file_line_Click;
            // 
            // table_name_combobox
            // 
            table_name_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            table_name_combobox.FormattingEnabled = true;
            table_name_combobox.Items.AddRange(new object[] { "---vyberte tabulku---", "Autor", "Formáty", "Linka", "Dopravní prostředek", "Dopravce", "Nátěr", "Výrobce", "Zastávka", "Podtyp dopravního prostředku", "Vozidlo", "Nátěry na vozidle", "Záběr", "Vozidla na záběrů" });
            table_name_combobox.Location = new Point(148, 14);
            table_name_combobox.Margin = new Padding(4, 5, 4, 5);
            table_name_combobox.Name = "table_name_combobox";
            table_name_combobox.Size = new Size(303, 33);
            table_name_combobox.TabIndex = 7;
            // 
            // Backup_import
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 110);
            Controls.Add(table_name_combobox);
            Controls.Add(select_file_line);
            Controls.Add(path_for_line);
            Controls.Add(select_file_label);
            Controls.Add(load_file_line);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Backup_import";
            Text = "Import dat";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox select_table;
        private Button load_file_line;
        private RadioButton from_xml;
        private RadioButton from_CSV;
        private TextBox path_for_line;
        private Button select_file_line;
        private Label select_file_label;
        private ComboBox table_name_combobox;
    }
}