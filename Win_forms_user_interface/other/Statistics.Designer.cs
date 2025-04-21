namespace evidence_clip_about_public_transport.Win_forms_user_interface.other
{
    partial class Statistics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statistics));
            menu_trip_on_top = new MenuStrip();
            file_button_on_top_menu_trip = new ToolStripMenuItem();
            save_as_button_on_top_menu_trip = new ToolStripMenuItem();
            toolstrip_for_work_with_table = new ToolStrip();
            type_chart_label = new ToolStripLabel();
            type_chart = new ToolStripComboBox();
            year_label = new ToolStripLabel();
            years_combobox = new ToolStripComboBox();
            load_button = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripTextBox1 = new ToolStripTextBox();
            status_strip = new StatusStrip();
            status_label = new ToolStripStatusLabel();
            data_from_select = new DataGridView();
            splitcontainer = new SplitContainer();
            chart_panel = new TableLayoutPanel();
            panel1 = new Panel();
            height = new NumericUpDown();
            height_label = new Label();
            export_chart_button = new Button();
            width_label = new Label();
            width = new NumericUpDown();
            chart = new Panel();
            menu_trip_on_top.SuspendLayout();
            toolstrip_for_work_with_table.SuspendLayout();
            status_strip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_from_select).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitcontainer).BeginInit();
            splitcontainer.Panel1.SuspendLayout();
            splitcontainer.Panel2.SuspendLayout();
            splitcontainer.SuspendLayout();
            chart_panel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)height).BeginInit();
            ((System.ComponentModel.ISupportInitialize)width).BeginInit();
            SuspendLayout();
            // 
            // menu_trip_on_top
            // 
            menu_trip_on_top.ImageScalingSize = new Size(24, 24);
            menu_trip_on_top.Items.AddRange(new ToolStripItem[] { file_button_on_top_menu_trip });
            menu_trip_on_top.Location = new Point(0, 0);
            menu_trip_on_top.Name = "menu_trip_on_top";
            menu_trip_on_top.Padding = new Padding(4, 1, 0, 1);
            menu_trip_on_top.Size = new Size(913, 24);
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
            save_as_button_on_top_menu_trip.Size = new Size(214, 22);
            save_as_button_on_top_menu_trip.Text = "Uložit jako (pouze tabulka)";
            save_as_button_on_top_menu_trip.Click += save_as_button_on_top_menu_trip_Click;
            // 
            // toolstrip_for_work_with_table
            // 
            toolstrip_for_work_with_table.ImageScalingSize = new Size(24, 24);
            toolstrip_for_work_with_table.Items.AddRange(new ToolStripItem[] { type_chart_label, type_chart, year_label, years_combobox, load_button, toolStripSeparator1, toolStripTextBox1 });
            toolstrip_for_work_with_table.Location = new Point(0, 24);
            toolstrip_for_work_with_table.Name = "toolstrip_for_work_with_table";
            toolstrip_for_work_with_table.Size = new Size(913, 25);
            toolstrip_for_work_with_table.TabIndex = 1;
            toolstrip_for_work_with_table.Text = "toolStrip1";
            // 
            // type_chart_label
            // 
            type_chart_label.Name = "type_chart_label";
            type_chart_label.Size = new Size(55, 22);
            type_chart_label.Text = "typ grafu";
            // 
            // type_chart
            // 
            type_chart.DropDownStyle = ComboBoxStyle.DropDownList;
            type_chart.Items.AddRange(new object[] { "bodový graf typ I.", "sloupcový graf typ I.", "sloupcový typ II.", "sloupcový typ III." });
            type_chart.Name = "type_chart";
            type_chart.Size = new Size(141, 25);
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
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(100, 25);
            // 
            // status_strip
            // 
            status_strip.ImageScalingSize = new Size(24, 24);
            status_strip.Items.AddRange(new ToolStripItem[] { status_label });
            status_strip.Location = new Point(0, 377);
            status_strip.Name = "status_strip";
            status_strip.Padding = new Padding(1, 0, 10, 0);
            status_strip.Size = new Size(913, 22);
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
            data_from_select.Location = new Point(0, 0);
            data_from_select.Margin = new Padding(2);
            data_from_select.Name = "data_from_select";
            data_from_select.RowHeadersWidth = 62;
            data_from_select.Size = new Size(418, 328);
            data_from_select.TabIndex = 3;
            data_from_select.CellClick += data_from_select_CellClick;
            data_from_select.ColumnHeaderMouseClick += data_from_select_ColumnHeaderMouseClick;
            // 
            // splitcontainer
            // 
            splitcontainer.Dock = DockStyle.Fill;
            splitcontainer.Location = new Point(0, 49);
            splitcontainer.Margin = new Padding(2);
            splitcontainer.Name = "splitcontainer";
            // 
            // splitcontainer.Panel1
            // 
            splitcontainer.Panel1.Controls.Add(data_from_select);
            // 
            // splitcontainer.Panel2
            // 
            splitcontainer.Panel2.Controls.Add(chart_panel);
            splitcontainer.Size = new Size(913, 328);
            splitcontainer.SplitterDistance = 418;
            splitcontainer.SplitterWidth = 3;
            splitcontainer.TabIndex = 4;
            // 
            // chart_panel
            // 
            chart_panel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            chart_panel.ColumnCount = 1;
            chart_panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            chart_panel.Controls.Add(panel1, 0, 1);
            chart_panel.Controls.Add(chart, 0, 0);
            chart_panel.Dock = DockStyle.Fill;
            chart_panel.Location = new Point(0, 0);
            chart_panel.Name = "chart_panel";
            chart_panel.RowCount = 2;
            chart_panel.RowStyles.Add(new RowStyle(SizeType.Percent, 99.99999F));
            chart_panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            chart_panel.Size = new Size(492, 328);
            chart_panel.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(height);
            panel1.Controls.Add(height_label);
            panel1.Controls.Add(export_chart_button);
            panel1.Controls.Add(width_label);
            panel1.Controls.Add(width);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 281);
            panel1.Name = "panel1";
            panel1.Size = new Size(486, 44);
            panel1.TabIndex = 5;
            // 
            // height
            // 
            height.Location = new Point(264, 14);
            height.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            height.Minimum = new decimal(new int[] { 400, 0, 0, 0 });
            height.Name = "height";
            height.Size = new Size(110, 23);
            height.TabIndex = 8;
            height.Value = new decimal(new int[] { 400, 0, 0, 0 });
            // 
            // height_label
            // 
            height_label.AutoSize = true;
            height_label.Location = new Point(189, 18);
            height_label.Name = "height_label";
            height_label.Size = new Size(69, 15);
            height_label.TabIndex = 7;
            height_label.Text = "výška (v Px)";
            // 
            // export_chart_button
            // 
            export_chart_button.Location = new Point(380, 14);
            export_chart_button.Name = "export_chart_button";
            export_chart_button.Size = new Size(97, 23);
            export_chart_button.TabIndex = 6;
            export_chart_button.Text = "Exportovat graf";
            export_chart_button.UseVisualStyleBackColor = true;
            export_chart_button.Click += export_chart_button_Click;
            // 
            // width_label
            // 
            width_label.AutoSize = true;
            width_label.Location = new Point(3, 18);
            width_label.Name = "width_label";
            width_label.Size = new Size(64, 15);
            width_label.TabIndex = 5;
            width_label.Text = "šířka (v Px)";
            // 
            // width
            // 
            width.Location = new Point(73, 14);
            width.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            width.Minimum = new decimal(new int[] { 400, 0, 0, 0 });
            width.Name = "width";
            width.Size = new Size(110, 23);
            width.TabIndex = 4;
            width.Value = new decimal(new int[] { 400, 0, 0, 0 });
            // 
            // chart
            // 
            chart.BackColor = SystemColors.HighlightText;
            chart.Dock = DockStyle.Fill;
            chart.Location = new Point(3, 3);
            chart.Name = "chart";
            chart.Size = new Size(486, 272);
            chart.TabIndex = 0;
            // 
            // Statistics
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 399);
            Controls.Add(splitcontainer);
            Controls.Add(status_strip);
            Controls.Add(toolstrip_for_work_with_table);
            Controls.Add(menu_trip_on_top);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menu_trip_on_top;
            Margin = new Padding(2);
            Name = "Statistics";
            Text = "Evidence záběrů - statistika";
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
            chart_panel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)height).EndInit();
            ((System.ComponentModel.ISupportInitialize)width).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menu_trip_on_top;
        private ToolStripMenuItem file_button_on_top_menu_trip;
        private ToolStripMenuItem save_as_button_on_top_menu_trip;
        private ToolStrip toolstrip_for_work_with_table;
        private ToolStripLabel year_label;
        private StatusStrip status_strip;
        private DataGridView data_from_select;
        private ToolStripStatusLabel status_label;
        private SplitContainer splitcontainer;
        private ToolStripComboBox years_combobox;
        private ToolStripButton load_button;
        private ToolStripComboBox type_chart;
        private ToolStripLabel type_chart_label;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripTextBox toolStripTextBox1;
        private Panel chart;
        private TableLayoutPanel chart_panel;
        private Panel panel1;
        private NumericUpDown width;
        private Label width_label;
        private Button export_chart_button;
        private Label height_label;
        private NumericUpDown height;
    }
}