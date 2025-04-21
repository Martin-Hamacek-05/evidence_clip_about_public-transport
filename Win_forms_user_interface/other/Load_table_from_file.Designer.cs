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
            filter_to_label = new Label();
            from_ = new DateTimePicker();
            to_ = new DateTimePicker();
            loaded_files = new DataGridView();
            save = new Button();
            enable_filter = new CheckBox();
            panel1 = new Panel();
            splitContainer1 = new SplitContainer();
            load_with_filter = new Button();
            file_url = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)load_file).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loaded_files).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // select_file
            // 
            select_file.Location = new Point(319, 12);
            select_file.Name = "select_file";
            select_file.Size = new Size(145, 23);
            select_file.TabIndex = 1;
            select_file.Text = "Vybrat soubor s daty";
            select_file.UseVisualStyleBackColor = true;
            select_file.Click += select_file_Click;
            // 
            // select_source_of_file
            // 
            select_source_of_file.Location = new Point(12, 12);
            select_source_of_file.Name = "select_source_of_file";
            select_source_of_file.Size = new Size(145, 23);
            select_source_of_file.TabIndex = 0;
            select_source_of_file.Text = "Vybrat zdroj souborů";
            select_source_of_file.UseVisualStyleBackColor = true;
            select_source_of_file.Click += select_source_of_file_Click;
            // 
            // load_file
            // 
            load_file.AllowUserToAddRows = false;
            load_file.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            load_file.Dock = DockStyle.Fill;
            load_file.Location = new Point(0, 0);
            load_file.Name = "load_file";
            load_file.RowHeadersWidth = 62;
            load_file.Size = new Size(415, 272);
            load_file.TabIndex = 7;
            load_file.RowHeaderMouseClick += load_file_MouseDown;
            // 
            // filter_to_label
            // 
            filter_to_label.AutoSize = true;
            filter_to_label.Location = new Point(365, 48);
            filter_to_label.Name = "filter_to_label";
            filter_to_label.Size = new Size(21, 15);
            filter_to_label.TabIndex = 5;
            filter_to_label.Text = "do";
            // 
            // from_
            // 
            from_.Enabled = false;
            from_.Format = DateTimePickerFormat.Custom;
            from_.Location = new Point(104, 45);
            from_.Name = "from_";
            from_.Size = new Size(257, 23);
            from_.TabIndex = 3;
            // 
            // to_
            // 
            to_.Enabled = false;
            to_.Format = DateTimePickerFormat.Custom;
            to_.Location = new Point(395, 45);
            to_.Name = "to_";
            to_.Size = new Size(257, 23);
            to_.TabIndex = 4;
            // 
            // loaded_files
            // 
            loaded_files.AllowUserToAddRows = false;
            loaded_files.AllowUserToResizeColumns = false;
            loaded_files.AllowUserToResizeRows = false;
            loaded_files.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            loaded_files.Dock = DockStyle.Fill;
            loaded_files.Location = new Point(0, 0);
            loaded_files.Margin = new Padding(2);
            loaded_files.Name = "loaded_files";
            loaded_files.RowHeadersWidth = 62;
            loaded_files.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            loaded_files.Size = new Size(304, 272);
            loaded_files.TabIndex = 6;
            // 
            // save
            // 
            save.Location = new Point(656, 350);
            save.Name = "save";
            save.Size = new Size(75, 23);
            save.TabIndex = 8;
            save.Text = "Uložit";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // enable_filter
            // 
            enable_filter.AutoSize = true;
            enable_filter.Location = new Point(12, 47);
            enable_filter.Margin = new Padding(2);
            enable_filter.Name = "enable_filter";
            enable_filter.Size = new Size(84, 19);
            enable_filter.TabIndex = 2;
            enable_filter.Text = "filtrovat od";
            enable_filter.UseVisualStyleBackColor = true;
            enable_filter.CheckedChanged += enable_filter_CheckedChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(splitContainer1);
            panel1.Location = new Point(12, 73);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(722, 272);
            panel1.TabIndex = 11;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(2);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(loaded_files);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(load_file);
            splitContainer1.Size = new Size(722, 272);
            splitContainer1.SplitterDistance = 304;
            splitContainer1.SplitterWidth = 3;
            splitContainer1.TabIndex = 0;
            // 
            // load_with_filter
            // 
            load_with_filter.Location = new Point(657, 45);
            load_with_filter.Margin = new Padding(2);
            load_with_filter.Name = "load_with_filter";
            load_with_filter.Size = new Size(78, 24);
            load_with_filter.TabIndex = 5;
            load_with_filter.Text = "Vyfiltrovat";
            load_with_filter.UseVisualStyleBackColor = true;
            load_with_filter.Click += load_with_filter_Click;
            // 
            // file_url
            // 
            file_url.FormattingEnabled = true;
            file_url.Location = new Point(365, 350);
            file_url.Name = "file_url";
            file_url.Size = new Size(287, 23);
            file_url.TabIndex = 12;
            // 
            // Load_table_from_file
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(743, 381);
            Controls.Add(file_url);
            Controls.Add(load_with_filter);
            Controls.Add(panel1);
            Controls.Add(enable_filter);
            Controls.Add(save);
            Controls.Add(to_);
            Controls.Add(from_);
            Controls.Add(filter_to_label);
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
            panel1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button select_file;
        private Button select_source_of_file;
        private DataGridView load_file;
        private Label filter_to_label;
        private DateTimePicker from_;
        private DateTimePicker to_;
        private DataGridView loaded_files;
        private Button save;
        private CheckBox enable_filter;
        private Panel panel1;
        private SplitContainer splitContainer1;
        private Button load_with_filter;
        private ComboBox file_url;
    }
}