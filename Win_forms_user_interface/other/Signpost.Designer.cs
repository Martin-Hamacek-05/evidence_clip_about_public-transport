namespace evidence_clip_about_public_transport.Win_forms_user_interface.other
{
    partial class Signpost
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signpost));
            treeView1 = new TreeView();
            menu_trip_on_top = new MenuStrip();
            database_manager_button_on_top_menu_trip = new ToolStripMenuItem();
            importdata_button_on_top_menu_trip = new ToolStripMenuItem();
            exportdata_button_on_top_menu_trip = new ToolStripMenuItem();
            accounts_ToolStripMenuItem = new ToolStripMenuItem();
            about_software_ToolStripMenuItem = new ToolStripMenuItem();
            toolstrip_for_work_with_table = new ToolStrip();
            user_button = new ToolStripButton();
            splitContainer1 = new SplitContainer();
            menu_trip_on_top.SuspendLayout();
            toolstrip_for_work_with_table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Dock = DockStyle.Fill;
            treeView1.Location = new Point(0, 0);
            treeView1.Margin = new Padding(4, 5, 4, 5);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(294, 681);
            treeView1.TabIndex = 0;
            treeView1.NodeMouseDoubleClick += treeView1_NodeMouseDoubleClick;
            treeView1.DoubleClick += treeView1_DoubleClick;
            // 
            // menu_trip_on_top
            // 
            menu_trip_on_top.ImageScalingSize = new Size(24, 24);
            menu_trip_on_top.Items.AddRange(new ToolStripItem[] { database_manager_button_on_top_menu_trip, about_software_ToolStripMenuItem });
            menu_trip_on_top.Location = new Point(0, 0);
            menu_trip_on_top.Name = "menu_trip_on_top";
            menu_trip_on_top.Padding = new Padding(9, 3, 0, 3);
            menu_trip_on_top.Size = new Size(1143, 35);
            menu_trip_on_top.TabIndex = 1;
            menu_trip_on_top.Text = "menuStrip1";
            // 
            // database_manager_button_on_top_menu_trip
            // 
            database_manager_button_on_top_menu_trip.DropDownItems.AddRange(new ToolStripItem[] { importdata_button_on_top_menu_trip, exportdata_button_on_top_menu_trip, accounts_ToolStripMenuItem });
            database_manager_button_on_top_menu_trip.Name = "database_manager_button_on_top_menu_trip";
            database_manager_button_on_top_menu_trip.Size = new Size(159, 29);
            database_manager_button_on_top_menu_trip.Text = "Správa databaze";
            // 
            // importdata_button_on_top_menu_trip
            // 
            importdata_button_on_top_menu_trip.Enabled = false;
            importdata_button_on_top_menu_trip.Name = "importdata_button_on_top_menu_trip";
            importdata_button_on_top_menu_trip.Size = new Size(239, 34);
            importdata_button_on_top_menu_trip.Text = "Import dat";
            importdata_button_on_top_menu_trip.Click += importdata_button_on_top_menu_trip_Click;
            // 
            // exportdata_button_on_top_menu_trip
            // 
            exportdata_button_on_top_menu_trip.Enabled = false;
            exportdata_button_on_top_menu_trip.Name = "exportdata_button_on_top_menu_trip";
            exportdata_button_on_top_menu_trip.Size = new Size(239, 34);
            exportdata_button_on_top_menu_trip.Text = "Export dat";
            exportdata_button_on_top_menu_trip.Click += exportdata_button_on_top_menu_trip_Click;
            // 
            // accounts_ToolStripMenuItem
            // 
            accounts_ToolStripMenuItem.Enabled = false;
            accounts_ToolStripMenuItem.Name = "accounts_ToolStripMenuItem";
            accounts_ToolStripMenuItem.Size = new Size(239, 34);
            accounts_ToolStripMenuItem.Text = "Správa přístupů";
            accounts_ToolStripMenuItem.Click += accounts_ToolStripMenuItem_Click;
            // 
            // about_software_ToolStripMenuItem
            // 
            about_software_ToolStripMenuItem.Name = "about_software_ToolStripMenuItem";
            about_software_ToolStripMenuItem.Size = new Size(126, 29);
            about_software_ToolStripMenuItem.Text = "O Programu";
            about_software_ToolStripMenuItem.Click += about_software_ToolStripMenuItem_Click;
            // 
            // toolstrip_for_work_with_table
            // 
            toolstrip_for_work_with_table.ImageScalingSize = new Size(24, 24);
            toolstrip_for_work_with_table.Items.AddRange(new ToolStripItem[] { user_button });
            toolstrip_for_work_with_table.Location = new Point(0, 35);
            toolstrip_for_work_with_table.Name = "toolstrip_for_work_with_table";
            toolstrip_for_work_with_table.Padding = new Padding(0, 0, 3, 0);
            toolstrip_for_work_with_table.Size = new Size(1143, 34);
            toolstrip_for_work_with_table.TabIndex = 2;
            toolstrip_for_work_with_table.Text = "toolStrip1";
            // 
            // user_button
            // 
            user_button.DisplayStyle = ToolStripItemDisplayStyle.Text;
            user_button.Image = (Image)resources.GetObject("user_button.Image");
            user_button.ImageTransparentColor = Color.Magenta;
            user_button.Name = "user_button";
            user_button.Size = new Size(147, 29);
            user_button.Text = "toolStripButton1";
            user_button.Click += user_button_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 69);
            splitContainer1.Margin = new Padding(4, 5, 4, 5);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(treeView1);
            splitContainer1.Size = new Size(1143, 681);
            splitContainer1.SplitterDistance = 294;
            splitContainer1.SplitterWidth = 6;
            splitContainer1.TabIndex = 3;
            // 
            // Signpost
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(splitContainer1);
            Controls.Add(toolstrip_for_work_with_table);
            Controls.Add(menu_trip_on_top);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menu_trip_on_top;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Signpost";
            Text = "Evidence záběrů - rozcestník";
            FormClosed += Signpost_FormClosed;
            menu_trip_on_top.ResumeLayout(false);
            menu_trip_on_top.PerformLayout();
            toolstrip_for_work_with_table.ResumeLayout(false);
            toolstrip_for_work_with_table.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeView1;
        private MenuStrip menu_trip_on_top;
        private ToolStripMenuItem database_manager_button_on_top_menu_trip;
        private ToolStripMenuItem importdata_button_on_top_menu_trip;
        private ToolStripMenuItem exportdata_button_on_top_menu_trip;
        private ToolStripMenuItem about_software_ToolStripMenuItem;
        private ToolStrip toolstrip_for_work_with_table;
        private ToolStripButton user_button;
        private SplitContainer splitContainer1;
        private ToolStripMenuItem accounts_ToolStripMenuItem;
    }
}