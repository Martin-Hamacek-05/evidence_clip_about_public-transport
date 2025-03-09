namespace evidence_clip_about_public_transport.Win_forms_user_interface.for_subtype_mean_of_transport
{
    partial class Show_subtype_mean_of_transport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Show_subtype_mean_of_transport));
            menu_trip_on_top = new MenuStrip();
            file_button_on_top_menu_trip = new ToolStripMenuItem();
            save_as_button_on_top_menu_trip = new ToolStripMenuItem();
            toolstrip_for_work_with_table = new ToolStrip();
            new_record = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            load_button = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            search_with_label = new ToolStripLabel();
            search_textbox = new ToolStripTextBox();
            search_button = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            header = new ToolStripTextBox();
            status_strip = new StatusStrip();
            status_label = new ToolStripStatusLabel();
            data_from_select = new DataGridView();
            menu_trip_on_top.SuspendLayout();
            toolstrip_for_work_with_table.SuspendLayout();
            status_strip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_from_select).BeginInit();
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
            toolstrip_for_work_with_table.Items.AddRange(new ToolStripItem[] { new_record, toolStripSeparator1, load_button, toolStripSeparator2, search_with_label, search_textbox, search_button, toolStripSeparator3, header });
            toolstrip_for_work_with_table.Location = new Point(0, 24);
            toolstrip_for_work_with_table.Name = "toolstrip_for_work_with_table";
            toolstrip_for_work_with_table.Size = new Size(660, 25);
            toolstrip_for_work_with_table.TabIndex = 1;
            toolstrip_for_work_with_table.Text = "toolStrip1";
            // 
            // new_record
            // 
            new_record.DisplayStyle = ToolStripItemDisplayStyle.Text;
            new_record.ImageTransparentColor = Color.Magenta;
            new_record.Name = "new_record";
            new_record.Size = new Size(85, 22);
            new_record.Text = "Přidat záznam";
            new_record.Click += new_record_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
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
            search_with_label.Size = new Size(120, 22);
            search_with_label.Text = "Vyhledat podle názvu";
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
            status_strip.Items.AddRange(new ToolStripItem[] { status_label });
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
            // data_from_select
            // 
            data_from_select.AllowUserToAddRows = false;
            data_from_select.AllowUserToDeleteRows = false;
            data_from_select.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_from_select.Dock = DockStyle.Fill;
            data_from_select.Location = new Point(0, 49);
            data_from_select.Margin = new Padding(2, 2, 2, 2);
            data_from_select.Name = "data_from_select";
            data_from_select.RowHeadersWidth = 62;
            data_from_select.Size = new Size(660, 199);
            data_from_select.TabIndex = 3;
            data_from_select.CellClick += data_from_select_CellClick;
            // 
            // Show_subtype_mean_of_transport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 270);
            Controls.Add(data_from_select);
            Controls.Add(status_strip);
            Controls.Add(toolstrip_for_work_with_table);
            Controls.Add(menu_trip_on_top);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menu_trip_on_top;
            Margin = new Padding(2, 2, 2, 2);
            Name = "Show_subtype_mean_of_transport";
            Text = "Evidence záběrů - výpis podtypů dopravních prostředků";
            menu_trip_on_top.ResumeLayout(false);
            menu_trip_on_top.PerformLayout();
            toolstrip_for_work_with_table.ResumeLayout(false);
            toolstrip_for_work_with_table.PerformLayout();
            status_strip.ResumeLayout(false);
            status_strip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)data_from_select).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menu_trip_on_top;
        private ToolStripMenuItem file_button_on_top_menu_trip;
        private ToolStripMenuItem save_as_button_on_top_menu_trip;
        private ToolStrip toolstrip_for_work_with_table;
        private ToolStripButton new_record;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton load_button;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripLabel search_with_label;
        private ToolStripTextBox search_textbox;
        private ToolStripButton search_button;
        private StatusStrip status_strip;
        private DataGridView data_from_select;
        private ToolStripStatusLabel status_label;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripTextBox header;
    }
}