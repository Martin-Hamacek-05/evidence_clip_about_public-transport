namespace evidence_clip_about_public_transport.Win_forms_user_interface.other
{
    partial class SQLQuerry
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
            menu_trip_on_top = new MenuStrip();
            file_button_on_top_menu_trip = new ToolStripMenuItem();
            save_as_button_on_top_menu_trip = new ToolStripMenuItem();
            querryToolStripMenuItem = new ToolStripMenuItem();
            header = new ToolStripTextBox();
            copy_filesToolStripMenuItem = new ToolStripMenuItem();
            show_clipToolStripMenuItem = new ToolStripMenuItem();
            data_from_select = new DataGridView();
            status_strip = new StatusStrip();
            status_label = new ToolStripStatusLabel();
            splitContainer1 = new SplitContainer();
            querry_input = new RichTextBox();
            menu_trip_on_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_from_select).BeginInit();
            status_strip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // menu_trip_on_top
            // 
            menu_trip_on_top.ImageScalingSize = new Size(24, 24);
            menu_trip_on_top.Items.AddRange(new ToolStripItem[] { file_button_on_top_menu_trip, querryToolStripMenuItem, header, copy_filesToolStripMenuItem, show_clipToolStripMenuItem });
            menu_trip_on_top.Location = new Point(0, 0);
            menu_trip_on_top.Name = "menu_trip_on_top";
            menu_trip_on_top.Padding = new Padding(4, 1, 0, 1);
            menu_trip_on_top.Size = new Size(800, 25);
            menu_trip_on_top.TabIndex = 1;
            menu_trip_on_top.Text = "menu_trip_on_top";
            // 
            // file_button_on_top_menu_trip
            // 
            file_button_on_top_menu_trip.DropDownItems.AddRange(new ToolStripItem[] { save_as_button_on_top_menu_trip });
            file_button_on_top_menu_trip.Name = "file_button_on_top_menu_trip";
            file_button_on_top_menu_trip.Size = new Size(57, 23);
            file_button_on_top_menu_trip.Text = "Soubor";
            // 
            // save_as_button_on_top_menu_trip
            // 
            save_as_button_on_top_menu_trip.Name = "save_as_button_on_top_menu_trip";
            save_as_button_on_top_menu_trip.Size = new Size(129, 22);
            save_as_button_on_top_menu_trip.Text = "Uložit jako";
            save_as_button_on_top_menu_trip.Click += save_as_button_on_top_menu_trip_Click;
            // 
            // querryToolStripMenuItem
            // 
            querryToolStripMenuItem.Name = "querryToolStripMenuItem";
            querryToolStripMenuItem.Size = new Size(90, 23);
            querryToolStripMenuItem.Text = "Provést dotaz";
            querryToolStripMenuItem.Click += querryToolStripMenuItem_Click;
            // 
            // header
            // 
            header.Name = "header";
            header.Size = new Size(100, 23);
            header.Text = "sem zadejte nadpis";
            // 
            // copy_filesToolStripMenuItem
            // 
            copy_filesToolStripMenuItem.Enabled = false;
            copy_filesToolStripMenuItem.Name = "copy_filesToolStripMenuItem";
            copy_filesToolStripMenuItem.Size = new Size(122, 23);
            copy_filesToolStripMenuItem.Text = "Zkopírovat soubory";
            copy_filesToolStripMenuItem.Click += copy_filesToolStripMenuItem_Click;
            // 
            // show_clipToolStripMenuItem
            // 
            show_clipToolStripMenuItem.Enabled = false;
            show_clipToolStripMenuItem.Name = "show_clipToolStripMenuItem";
            show_clipToolStripMenuItem.Size = new Size(93, 23);
            show_clipToolStripMenuItem.Text = "Zobrazit záběr";
            show_clipToolStripMenuItem.Click += show_clipToolStripMenuItem_Click;
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
            data_from_select.ReadOnly = true;
            data_from_select.RowHeadersWidth = 62;
            data_from_select.Size = new Size(800, 264);
            data_from_select.TabIndex = 5;
            data_from_select.CellClick += data_from_select_CellClick;
            // 
            // status_strip
            // 
            status_strip.ImageScalingSize = new Size(24, 24);
            status_strip.Items.AddRange(new ToolStripItem[] { status_label });
            status_strip.Location = new Point(0, 428);
            status_strip.Name = "status_strip";
            status_strip.Padding = new Padding(1, 0, 10, 0);
            status_strip.Size = new Size(800, 22);
            status_strip.TabIndex = 4;
            status_strip.Text = "statusStrip1";
            // 
            // status_label
            // 
            status_label.Name = "status_label";
            status_label.Size = new Size(0, 17);
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 25);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(querry_input);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(data_from_select);
            splitContainer1.Size = new Size(800, 403);
            splitContainer1.SplitterDistance = 135;
            splitContainer1.TabIndex = 6;
            // 
            // querry_input
            // 
            querry_input.DetectUrls = false;
            querry_input.Dock = DockStyle.Fill;
            querry_input.Location = new Point(0, 0);
            querry_input.Name = "querry_input";
            querry_input.Size = new Size(800, 135);
            querry_input.TabIndex = 0;
            querry_input.Text = "";
            // 
            // SQLQuerry
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Controls.Add(status_strip);
            Controls.Add(menu_trip_on_top);
            Name = "SQLQuerry";
            ShowIcon = false;
            Text = "SQL dotaz";
            menu_trip_on_top.ResumeLayout(false);
            menu_trip_on_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)data_from_select).EndInit();
            status_strip.ResumeLayout(false);
            status_strip.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menu_trip_on_top;
        private ToolStripMenuItem file_button_on_top_menu_trip;
        private ToolStripMenuItem save_as_button_on_top_menu_trip;
        private DataGridView data_from_select;
        private StatusStrip status_strip;
        private ToolStripStatusLabel status_label;
        private SplitContainer splitContainer1;
        private ToolStripMenuItem querryToolStripMenuItem;
        private RichTextBox querry_input;
        private ToolStripTextBox header;
        private ToolStripMenuItem copy_filesToolStripMenuItem;
        private ToolStripMenuItem show_clipToolStripMenuItem;
    }
}