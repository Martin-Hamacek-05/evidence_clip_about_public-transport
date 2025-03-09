namespace evidence_clip_about_public_transport.Win_forms_user_interface.other
{
    partial class Filter
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Filter));
            menu_trip_on_top = new MenuStrip();
            file_button_on_top_menu_trip = new ToolStripMenuItem();
            save_as_button_on_top_menu_trip = new ToolStripMenuItem();
            toolstrip_for_work_with_table = new ToolStrip();
            load_button = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            search_with_label = new ToolStripLabel();
            search_textbox = new ToolStripTextBox();
            search_button = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            copy_file_button = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            header = new ToolStripTextBox();
            status_strip = new StatusStrip();
            status_label = new ToolStripStatusLabel();
            copy_of_files_label = new ToolStripStatusLabel();
            count_of_files_in_label = new ToolStripStatusLabel();
            data_from_select = new DataGridView();
            splitcontainer = new SplitContainer();
            tab_with_column_to_filter = new TabControl();
            date_page = new TabPage();
            to_ = new DateTimePicker();
            to_label = new Label();
            from_ = new DateTimePicker();
            from_label = new Label();
            menu_trip_on_top.SuspendLayout();
            toolstrip_for_work_with_table.SuspendLayout();
            status_strip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_from_select).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitcontainer).BeginInit();
            splitcontainer.Panel1.SuspendLayout();
            splitcontainer.Panel2.SuspendLayout();
            splitcontainer.SuspendLayout();
            tab_with_column_to_filter.SuspendLayout();
            date_page.SuspendLayout();
            SuspendLayout();
            // 
            // menu_trip_on_top
            // 
            menu_trip_on_top.ImageScalingSize = new Size(24, 24);
            menu_trip_on_top.Items.AddRange(new ToolStripItem[] { file_button_on_top_menu_trip });
            menu_trip_on_top.Location = new Point(0, 0);
            menu_trip_on_top.Name = "menu_trip_on_top";
            menu_trip_on_top.Padding = new Padding(4, 1, 0, 1);
            menu_trip_on_top.Size = new Size(660, 24);
            menu_trip_on_top.TabIndex = 0;
            menu_trip_on_top.Text = "menu_trip_on_top";
            // 
            // file_button_on_top_menu_trip
            // 
            file_button_on_top_menu_trip.DropDownItems.AddRange(new ToolStripItem[] { save_as_button_on_top_menu_trip });
            file_button_on_top_menu_trip.Name = "file_button_on_top_menu_trip";
            file_button_on_top_menu_trip.Size = new Size(57, 22);
            file_button_on_top_menu_trip.Text = "Soubor";
            // 
            // save_as_button_on_top_menu_trip
            // 
            save_as_button_on_top_menu_trip.Name = "save_as_button_on_top_menu_trip";
            save_as_button_on_top_menu_trip.Size = new Size(129, 22);
            save_as_button_on_top_menu_trip.Text = "Uložit jako";
            save_as_button_on_top_menu_trip.Click += save_as_button_on_top_menu_trip_Click;
            // 
            // toolstrip_for_work_with_table
            // 
            toolstrip_for_work_with_table.ImageScalingSize = new Size(24, 24);
            toolstrip_for_work_with_table.Items.AddRange(new ToolStripItem[] { load_button, toolStripSeparator2, search_with_label, search_textbox, search_button, toolStripSeparator1, copy_file_button, toolStripSeparator3, header });
            toolstrip_for_work_with_table.Location = new Point(0, 24);
            toolstrip_for_work_with_table.Name = "toolstrip_for_work_with_table";
            toolstrip_for_work_with_table.Size = new Size(660, 25);
            toolstrip_for_work_with_table.TabIndex = 1;
            toolstrip_for_work_with_table.Text = "toolStrip1";
            // 
            // load_button
            // 
            load_button.DisplayStyle = ToolStripItemDisplayStyle.Text;
            load_button.ImageTransparentColor = Color.Magenta;
            load_button.Name = "load_button";
            load_button.Size = new Size(44, 22);
            load_button.Text = "Načíst";
            load_button.Click += load_button_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // search_with_label
            // 
            search_with_label.Name = "search_with_label";
            search_with_label.Size = new Size(136, 22);
            search_with_label.Text = "Vyhledat podle označení";
            search_with_label.Click += search_with_label_Click;
            // 
            // search_textbox
            // 
            search_textbox.Name = "search_textbox";
            search_textbox.Size = new Size(71, 25);
            // 
            // search_button
            // 
            search_button.DisplayStyle = ToolStripItemDisplayStyle.Text;
            search_button.ImageTransparentColor = Color.Magenta;
            search_button.Name = "search_button";
            search_button.Size = new Size(57, 22);
            search_button.Text = "Vyhledat";
            search_button.Click += search_button_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // copy_file_button
            // 
            copy_file_button.DisplayStyle = ToolStripItemDisplayStyle.Text;
            copy_file_button.Image = (Image)resources.GetObject("copy_file_button.Image");
            copy_file_button.ImageTransparentColor = Color.Magenta;
            copy_file_button.Name = "copy_file_button";
            copy_file_button.Size = new Size(105, 22);
            copy_file_button.Text = "Zkopírovat záběry";
            copy_file_button.Click += copy_file_button_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 25);
            // 
            // header
            // 
            header.Name = "header";
            header.Size = new Size(71, 25);
            header.Text = "sem zadejte nadpis";
            // 
            // status_strip
            // 
            status_strip.ImageScalingSize = new Size(24, 24);
            status_strip.Items.AddRange(new ToolStripItem[] { status_label, copy_of_files_label, count_of_files_in_label });
            status_strip.Location = new Point(0, 248);
            status_strip.Name = "status_strip";
            status_strip.Padding = new Padding(1, 0, 10, 0);
            status_strip.Size = new Size(660, 22);
            status_strip.TabIndex = 2;
            status_strip.Text = "statusStrip1";
            // 
            // status_label
            // 
            status_label.Name = "status_label";
            status_label.Size = new Size(0, 17);
            // 
            // copy_of_files_label
            // 
            copy_of_files_label.Name = "copy_of_files_label";
            copy_of_files_label.Size = new Size(170, 17);
            copy_of_files_label.Text = "| počet zkopírovaných souborů";
            // 
            // count_of_files_in_label
            // 
            count_of_files_in_label.Name = "count_of_files_in_label";
            count_of_files_in_label.Size = new Size(13, 17);
            count_of_files_in_label.Text = "0";
            // 
            // data_from_select
            // 
            data_from_select.AllowUserToAddRows = false;
            data_from_select.AllowUserToDeleteRows = false;
            data_from_select.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_from_select.Dock = DockStyle.Fill;
            data_from_select.Location = new Point(0, 0);
            data_from_select.Margin = new Padding(2);
            data_from_select.Name = "data_from_select";
            data_from_select.RowHeadersWidth = 62;
            data_from_select.Size = new Size(660, 98);
            data_from_select.TabIndex = 3;
            data_from_select.CellClick += data_from_select_CellClick;
            // 
            // splitcontainer
            // 
            splitcontainer.Dock = DockStyle.Fill;
            splitcontainer.Location = new Point(0, 49);
            splitcontainer.Margin = new Padding(2);
            splitcontainer.Name = "splitcontainer";
            splitcontainer.Orientation = Orientation.Horizontal;
            // 
            // splitcontainer.Panel1
            // 
            splitcontainer.Panel1.Controls.Add(tab_with_column_to_filter);
            // 
            // splitcontainer.Panel2
            // 
            splitcontainer.Panel2.Controls.Add(data_from_select);
            splitcontainer.Size = new Size(660, 199);
            splitcontainer.SplitterDistance = 99;
            splitcontainer.SplitterWidth = 2;
            splitcontainer.TabIndex = 4;
            // 
            // tab_with_column_to_filter
            // 
            tab_with_column_to_filter.Controls.Add(date_page);
            tab_with_column_to_filter.Dock = DockStyle.Fill;
            tab_with_column_to_filter.Location = new Point(0, 0);
            tab_with_column_to_filter.Margin = new Padding(2);
            tab_with_column_to_filter.Name = "tab_with_column_to_filter";
            tab_with_column_to_filter.SelectedIndex = 0;
            tab_with_column_to_filter.Size = new Size(660, 99);
            tab_with_column_to_filter.TabIndex = 0;
            // 
            // date_page
            // 
            date_page.Controls.Add(to_);
            date_page.Controls.Add(to_label);
            date_page.Controls.Add(from_);
            date_page.Controls.Add(from_label);
            date_page.Location = new Point(4, 24);
            date_page.Margin = new Padding(2);
            date_page.Name = "date_page";
            date_page.Size = new Size(652, 71);
            date_page.TabIndex = 0;
            date_page.Text = "období";
            date_page.UseVisualStyleBackColor = true;
            // 
            // to_
            // 
            to_.Location = new Point(34, 35);
            to_.Margin = new Padding(2);
            to_.Name = "to_";
            to_.Size = new Size(211, 23);
            to_.TabIndex = 3;
            to_.Value = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            // 
            // to_label
            // 
            to_label.AutoSize = true;
            to_label.Location = new Point(6, 38);
            to_label.Margin = new Padding(2, 0, 2, 0);
            to_label.Name = "to_label";
            to_label.Size = new Size(21, 15);
            to_label.TabIndex = 2;
            to_label.Text = "do";
            // 
            // from_
            // 
            from_.Location = new Point(34, 5);
            from_.Margin = new Padding(2);
            from_.Name = "from_";
            from_.Size = new Size(211, 23);
            from_.TabIndex = 1;
            from_.Value = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            // 
            // from_label
            // 
            from_label.AutoSize = true;
            from_label.Location = new Point(6, 8);
            from_label.Margin = new Padding(2, 0, 2, 0);
            from_label.Name = "from_label";
            from_label.Size = new Size(21, 15);
            from_label.TabIndex = 0;
            from_label.Text = "od";
            // 
            // Filter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 270);
            Controls.Add(splitcontainer);
            Controls.Add(status_strip);
            Controls.Add(toolstrip_for_work_with_table);
            Controls.Add(menu_trip_on_top);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menu_trip_on_top;
            Margin = new Padding(2);
            Name = "Filter";
            Text = "Evidence záběrů - filtr";
            menu_trip_on_top.ResumeLayout(false);
            menu_trip_on_top.PerformLayout();
            toolstrip_for_work_with_table.ResumeLayout(false);
            toolstrip_for_work_with_table.PerformLayout();
            status_strip.ResumeLayout(false);
            status_strip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)data_from_select).EndInit();
            splitcontainer.Panel1.ResumeLayout(false);
            splitcontainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitcontainer).EndInit();
            splitcontainer.ResumeLayout(false);
            tab_with_column_to_filter.ResumeLayout(false);
            date_page.ResumeLayout(false);
            date_page.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menu_trip_on_top;
        private ToolStripMenuItem file_button_on_top_menu_trip;
        private ToolStripMenuItem save_as_button_on_top_menu_trip;
        private ToolStrip toolstrip_for_work_with_table;
        private ToolStripButton load_button;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripLabel search_with_label;
        private ToolStripTextBox search_textbox;
        private ToolStripButton search_button;
        private StatusStrip status_strip;
        private DataGridView data_from_select;
        private ToolStripStatusLabel status_label;
        private SplitContainer splitcontainer;
        private TabControl tab_with_column_to_filter;
        private TabPage date_page;
        private DateTimePicker from_;
        private Label from_label;
        private DateTimePicker to_;
        private Label to_label;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton copy_file_button;
        private ToolStripStatusLabel copy_of_files_label;
        private ToolStripStatusLabel count_of_files_in_label;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripTextBox header;
    }
}