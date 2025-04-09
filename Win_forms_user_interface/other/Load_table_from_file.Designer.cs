namespace evidence_clip_about_public_transport.Win_forms_user_interface.other
{
    partial class Load_table_from_file
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
            select_file = new Button();
            select_source_of_file = new Button();
            load_file = new DataGridView();
            filer_from_label = new Label();
            filter_to_label = new Label();
            from_ = new DateTimePicker();
            to_ = new DateTimePicker();
            loaded_files = new DataGridView();
            save = new Button();
            ((System.ComponentModel.ISupportInitialize)load_file).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loaded_files).BeginInit();
            SuspendLayout();
            // 
            // select_file
            // 
            select_file.Location = new Point(268, 12);
            select_file.Name = "select_file";
            select_file.Size = new Size(145, 23);
            select_file.TabIndex = 2;
            select_file.Text = "Vybrat soubor s daty";
            select_file.UseVisualStyleBackColor = true;
            select_file.Click += select_file_Click;
            // 
            // select_source_of_file
            // 
            select_source_of_file.Location = new Point(12, 12);
            select_source_of_file.Name = "select_source_of_file";
            select_source_of_file.Size = new Size(145, 23);
            select_source_of_file.TabIndex = 1;
            select_source_of_file.Text = "Vybrat zdroj souborů";
            select_source_of_file.UseVisualStyleBackColor = true;
            select_source_of_file.Click += select_source_of_file_Click;
            // 
            // load_file
            // 
            load_file.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            load_file.Location = new Point(268, 70);
            load_file.Name = "load_file";
            load_file.RowHeadersWidth = 62;
            load_file.Size = new Size(421, 274);
            load_file.TabIndex = 3;
            load_file.RowHeaderMouseClick += load_file_MouseDown;
            // 
            // filer_from_label
            // 
            filer_from_label.AutoSize = true;
            filer_from_label.Location = new Point(12, 44);
            filer_from_label.Name = "filer_from_label";
            filer_from_label.Size = new Size(65, 15);
            filer_from_label.TabIndex = 4;
            filer_from_label.Text = "filtrovat od";
            // 
            // filter_to_label
            // 
            filter_to_label.AutoSize = true;
            filter_to_label.Location = new Point(286, 44);
            filter_to_label.Name = "filter_to_label";
            filter_to_label.Size = new Size(21, 15);
            filter_to_label.TabIndex = 5;
            filter_to_label.Text = "od";
            // 
            // from_
            // 
            from_.Location = new Point(83, 41);
            from_.Name = "from_";
            from_.Size = new Size(182, 23);
            from_.TabIndex = 6;
            // 
            // to_
            // 
            to_.Location = new Point(313, 41);
            to_.Name = "to_";
            to_.Size = new Size(200, 23);
            to_.TabIndex = 7;
            // 
            // loaded_files
            // 
            loaded_files.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            loaded_files.Location = new Point(11, 70);
            loaded_files.Margin = new Padding(2);
            loaded_files.Name = "loaded_files";
            loaded_files.RowHeadersWidth = 62;
            loaded_files.Size = new Size(254, 274);
            loaded_files.TabIndex = 8;
            // 
            // save
            // 
            save.Location = new Point(614, 350);
            save.Name = "save";
            save.Size = new Size(75, 23);
            save.TabIndex = 9;
            save.Text = "Uložit";
            save.UseVisualStyleBackColor = true;
            // 
            // Load_table_from_file
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 381);
            Controls.Add(save);
            Controls.Add(loaded_files);
            Controls.Add(to_);
            Controls.Add(from_);
            Controls.Add(filter_to_label);
            Controls.Add(filer_from_label);
            Controls.Add(load_file);
            Controls.Add(select_source_of_file);
            Controls.Add(select_file);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Load_table_from_file";
            ShowIcon = false;
            Text = "Přidat záznamy ze souboru";
            ((System.ComponentModel.ISupportInitialize)load_file).EndInit();
            ((System.ComponentModel.ISupportInitialize)loaded_files).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button select_file;
        private Button select_source_of_file;
        private DataGridView load_file;
        private Label filer_from_label;
        private Label filter_to_label;
        private DateTimePicker from_;
        private DateTimePicker to_;
        private DataGridView loaded_files;
        private Button save;
    }
}