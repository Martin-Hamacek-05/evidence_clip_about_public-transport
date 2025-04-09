namespace evidence_clip_about_public_transport.Win_forms_user_interface.for_pattern_on_vehicle
{
    partial class Edit_pattern_on_vehicle
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
            pattern_label = new Label();
            pattern_combobox = new ComboBox();
            add_to_list = new Button();
            remove_from_list = new Button();
            close_button = new Button();
            pattern_on_vehicle = new DataGridView();
            id_of_selected_vehicle_label = new Label();
            from_label = new Label();
            to_label = new Label();
            from_ = new DateTimePicker();
            to_ = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pattern_on_vehicle).BeginInit();
            SuspendLayout();
            // 
            // pattern_label
            // 
            pattern_label.AutoSize = true;
            pattern_label.Location = new Point(27, 16);
            pattern_label.Margin = new Padding(2, 0, 2, 0);
            pattern_label.Name = "pattern_label";
            pattern_label.Size = new Size(34, 15);
            pattern_label.TabIndex = 0;
            pattern_label.Text = "nátěr";
            // 
            // pattern_combobox
            // 
            pattern_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            pattern_combobox.FormattingEnabled = true;
            pattern_combobox.Location = new Point(68, 14);
            pattern_combobox.Margin = new Padding(2);
            pattern_combobox.Name = "pattern_combobox";
            pattern_combobox.Size = new Size(372, 23);
            pattern_combobox.TabIndex = 0;
            // 
            // add_to_list
            // 
            add_to_list.Location = new Point(67, 68);
            add_to_list.Margin = new Padding(2);
            add_to_list.Name = "add_to_list";
            add_to_list.Size = new Size(148, 23);
            add_to_list.TabIndex = 3;
            add_to_list.Text = "přidat na seznam";
            add_to_list.UseVisualStyleBackColor = true;
            add_to_list.Click += add_to_list_Click;
            // 
            // remove_from_list
            // 
            remove_from_list.Location = new Point(68, 179);
            remove_from_list.Margin = new Padding(2);
            remove_from_list.Name = "remove_from_list";
            remove_from_list.Size = new Size(147, 23);
            remove_from_list.TabIndex = 5;
            remove_from_list.Text = "Smazat ze seznamu";
            remove_from_list.UseVisualStyleBackColor = true;
            remove_from_list.Click += remove_from_list_Click;
            // 
            // close_button
            // 
            close_button.Location = new Point(360, 179);
            close_button.Margin = new Padding(2);
            close_button.Name = "close_button";
            close_button.Size = new Size(78, 23);
            close_button.TabIndex = 6;
            close_button.Text = "Zavřít";
            close_button.UseVisualStyleBackColor = true;
            close_button.Click += close_button_Click;
            // 
            // pattern_on_vehicle
            // 
            pattern_on_vehicle.AllowUserToAddRows = false;
            pattern_on_vehicle.AllowUserToDeleteRows = false;
            pattern_on_vehicle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pattern_on_vehicle.Location = new Point(68, 99);
            pattern_on_vehicle.Margin = new Padding(2);
            pattern_on_vehicle.Name = "pattern_on_vehicle";
            pattern_on_vehicle.RowHeadersWidth = 62;
            pattern_on_vehicle.Size = new Size(371, 71);
            pattern_on_vehicle.TabIndex = 4;
            pattern_on_vehicle.CellClick += pattern_on_vehicle_CellClick;
            // 
            // id_of_selected_vehicle_label
            // 
            id_of_selected_vehicle_label.AutoSize = true;
            id_of_selected_vehicle_label.Location = new Point(243, 185);
            id_of_selected_vehicle_label.Margin = new Padding(2, 0, 2, 0);
            id_of_selected_vehicle_label.Name = "id_of_selected_vehicle_label";
            id_of_selected_vehicle_label.Size = new Size(61, 15);
            id_of_selected_vehicle_label.TabIndex = 7;
            id_of_selected_vehicle_label.Text = "undefined";
            id_of_selected_vehicle_label.Visible = false;
            // 
            // from_label
            // 
            from_label.AutoSize = true;
            from_label.Location = new Point(40, 44);
            from_label.Margin = new Padding(2, 0, 2, 0);
            from_label.Name = "from_label";
            from_label.Size = new Size(21, 15);
            from_label.TabIndex = 8;
            from_label.Text = "od";
            // 
            // to_label
            // 
            to_label.AutoSize = true;
            to_label.Location = new Point(243, 44);
            to_label.Margin = new Padding(2, 0, 2, 0);
            to_label.Name = "to_label";
            to_label.Size = new Size(21, 15);
            to_label.TabIndex = 9;
            to_label.Text = "do";
            // 
            // from_
            // 
            from_.Location = new Point(68, 41);
            from_.Margin = new Padding(2);
            from_.Name = "from_";
            from_.Size = new Size(169, 23);
            from_.TabIndex = 1;
            // 
            // to_
            // 
            to_.Location = new Point(271, 41);
            to_.Margin = new Padding(2);
            to_.Name = "to_";
            to_.Size = new Size(169, 23);
            to_.TabIndex = 2;
            // 
            // Edit_pattern_on_vehicle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 211);
            Controls.Add(to_);
            Controls.Add(from_);
            Controls.Add(to_label);
            Controls.Add(from_label);
            Controls.Add(id_of_selected_vehicle_label);
            Controls.Add(pattern_on_vehicle);
            Controls.Add(close_button);
            Controls.Add(remove_from_list);
            Controls.Add(add_to_list);
            Controls.Add(pattern_combobox);
            Controls.Add(pattern_label);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Edit_pattern_on_vehicle";
            Text = "Spravovat nátěry na vozidle";
            ((System.ComponentModel.ISupportInitialize)pattern_on_vehicle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label pattern_label;
        private ComboBox pattern_combobox;
        private Button add_to_list;
        private Button remove_from_list;
        private Button close_button;
        private DataGridView pattern_on_vehicle;
        private Label id_of_selected_vehicle_label;
        private Label from_label;
        private Label to_label;
        private DateTimePicker from_;
        private DateTimePicker to_;
    }
}