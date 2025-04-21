namespace evidence_clip_about_public_transport.Win_forms_user_interface.other
{
    partial class Complete_overview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Complete_overview));
            menu_trip_on_top = new MenuStrip();
            file_button_on_top_menu_trip = new ToolStripMenuItem();
            save_as_button_on_top_menu_trip = new ToolStripMenuItem();
            toolstrip_for_work_with_table = new ToolStrip();
            year_label = new ToolStripLabel();
            years_combobox = new ToolStripComboBox();
            load_button = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            data = new DataGridView();
            menu_trip_on_top.SuspendLayout();
            toolstrip_for_work_with_table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data).BeginInit();
            SuspendLayout();
            // 
            // menu_trip_on_top
            // 
            menu_trip_on_top.ImageScalingSize = new Size(24, 24);
            menu_trip_on_top.Items.AddRange(new ToolStripItem[] { file_button_on_top_menu_trip });
            menu_trip_on_top.Location = new Point(0, 0);
            menu_trip_on_top.Name = "menu_trip_on_top";
            menu_trip_on_top.Padding = new Padding(4, 1, 0, 1);
            menu_trip_on_top.Size = new Size(750, 24);
            menu_trip_on_top.TabIndex = 1;
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
            toolstrip_for_work_with_table.Items.AddRange(new ToolStripItem[] { year_label, years_combobox, load_button, toolStripSeparator1 });
            toolstrip_for_work_with_table.Location = new Point(0, 24);
            toolstrip_for_work_with_table.Name = "toolstrip_for_work_with_table";
            toolstrip_for_work_with_table.Size = new Size(750, 25);
            toolstrip_for_work_with_table.TabIndex = 2;
            toolstrip_for_work_with_table.Text = "toolStrip1";
            // 
            // year_label
            // 
            year_label.Name = "year_label";
            year_label.Size = new Size(38, 22);
            year_label.Text = "za rok";
            // 
            // years_combobox
            // 
            years_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            years_combobox.Name = "years_combobox";
            years_combobox.Size = new Size(86, 25);
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
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // data
            // 
            data.AllowUserToAddRows = false;
            data.AllowUserToResizeRows = false;
            data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data.ColumnHeadersVisible = false;
            data.Dock = DockStyle.Fill;
            data.Location = new Point(0, 49);
            data.Name = "data";
            data.ReadOnly = true;
            data.Size = new Size(750, 387);
            data.TabIndex = 3;
            // 
            // Complete_overview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 436);
            Controls.Add(data);
            Controls.Add(toolstrip_for_work_with_table);
            Controls.Add(menu_trip_on_top);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Complete_overview";
            Text = "Statistiky - kompletní přehled";
            menu_trip_on_top.ResumeLayout(false);
            menu_trip_on_top.PerformLayout();
            toolstrip_for_work_with_table.ResumeLayout(false);
            toolstrip_for_work_with_table.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)data).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menu_trip_on_top;
        private ToolStripMenuItem file_button_on_top_menu_trip;
        private ToolStripMenuItem save_as_button_on_top_menu_trip;
        private ToolStrip toolstrip_for_work_with_table;
        private ToolStripLabel year_label;
        private ToolStripComboBox years_combobox;
        private ToolStripButton load_button;
        private ToolStripSeparator toolStripSeparator1;
        private DataGridView data;
    }
}