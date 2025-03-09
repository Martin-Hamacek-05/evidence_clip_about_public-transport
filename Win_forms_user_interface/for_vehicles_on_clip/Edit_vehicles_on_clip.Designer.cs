namespace evidence_clip_about_public_transport.Win_forms_user_interface.for_vehicles_on_clip
{
    partial class Edit_vehicles_on_clip
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
            vehicle_label = new Label();
            vehicle_combobox = new ComboBox();
            add_to_list = new Button();
            remove_from_list = new Button();
            close_button = new Button();
            vehicles_on_clip = new DataGridView();
            id_of_selected_clip_label = new Label();
            ((System.ComponentModel.ISupportInitialize)vehicles_on_clip).BeginInit();
            SuspendLayout();
            // 
            // vehicle_label
            // 
            vehicle_label.AutoSize = true;
            vehicle_label.Location = new Point(15, 16);
            vehicle_label.Margin = new Padding(2, 0, 2, 0);
            vehicle_label.Name = "vehicle_label";
            vehicle_label.Size = new Size(45, 15);
            vehicle_label.TabIndex = 0;
            vehicle_label.Text = "vozidlo";
            // 
            // vehicle_combobox
            // 
            vehicle_combobox.FormattingEnabled = true;
            vehicle_combobox.Location = new Point(68, 14);
            vehicle_combobox.Margin = new Padding(2, 2, 2, 2);
            vehicle_combobox.Name = "vehicle_combobox";
            vehicle_combobox.Size = new Size(306, 23);
            vehicle_combobox.TabIndex = 0;
            // 
            // add_to_list
            // 
            add_to_list.Location = new Point(377, 13);
            add_to_list.Margin = new Padding(2, 2, 2, 2);
            add_to_list.Name = "add_to_list";
            add_to_list.Size = new Size(148, 23);
            add_to_list.TabIndex = 1;
            add_to_list.Text = "přidat na seznam";
            add_to_list.UseVisualStyleBackColor = true;
            add_to_list.Click += add_to_list_Click;
            // 
            // remove_from_list
            // 
            remove_from_list.Location = new Point(68, 216);
            remove_from_list.Margin = new Padding(2, 2, 2, 2);
            remove_from_list.Name = "remove_from_list";
            remove_from_list.Size = new Size(147, 23);
            remove_from_list.TabIndex = 3;
            remove_from_list.Text = "Smazat ze seznamu";
            remove_from_list.UseVisualStyleBackColor = true;
            remove_from_list.Click += remove_from_list_Click;
            // 
            // close_button
            // 
            close_button.Location = new Point(447, 216);
            close_button.Margin = new Padding(2, 2, 2, 2);
            close_button.Name = "close_button";
            close_button.Size = new Size(78, 23);
            close_button.TabIndex = 4;
            close_button.Text = "Zavřít";
            close_button.UseVisualStyleBackColor = true;
            close_button.Click += close_button_Click;
            // 
            // vehicles_on_clip
            // 
            vehicles_on_clip.AllowUserToAddRows = false;
            vehicles_on_clip.AllowUserToDeleteRows = false;
            vehicles_on_clip.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            vehicles_on_clip.Location = new Point(68, 43);
            vehicles_on_clip.Margin = new Padding(2, 2, 2, 2);
            vehicles_on_clip.Name = "vehicles_on_clip";
            vehicles_on_clip.RowHeadersWidth = 62;
            vehicles_on_clip.Size = new Size(457, 169);
            vehicles_on_clip.TabIndex = 2;
            vehicles_on_clip.CellClick += vehicles_on_clip_CellClick;
            // 
            // id_of_selected_clip_label
            // 
            id_of_selected_clip_label.AutoSize = true;
            id_of_selected_clip_label.Location = new Point(243, 221);
            id_of_selected_clip_label.Margin = new Padding(2, 0, 2, 0);
            id_of_selected_clip_label.Name = "id_of_selected_clip_label";
            id_of_selected_clip_label.Size = new Size(61, 15);
            id_of_selected_clip_label.TabIndex = 7;
            id_of_selected_clip_label.Text = "undefined";
            id_of_selected_clip_label.Visible = false;
            // 
            // Edit_vehicles_on_clip
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 244);
            Controls.Add(id_of_selected_clip_label);
            Controls.Add(vehicles_on_clip);
            Controls.Add(close_button);
            Controls.Add(remove_from_list);
            Controls.Add(add_to_list);
            Controls.Add(vehicle_combobox);
            Controls.Add(vehicle_label);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2, 2, 2, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Edit_vehicles_on_clip";
            Text = "Spravovat vozidla na klipu";
            ((System.ComponentModel.ISupportInitialize)vehicles_on_clip).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label vehicle_label;
        private ComboBox vehicle_combobox;
        private Button add_to_list;
        private Button remove_from_list;
        private Button close_button;
        private DataGridView vehicles_on_clip;
        private Label id_of_selected_clip_label;
    }
}