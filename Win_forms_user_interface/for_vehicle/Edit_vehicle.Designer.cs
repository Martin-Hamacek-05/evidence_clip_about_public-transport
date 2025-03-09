namespace evidence_clip_about_public_transport.Win_forms_user_interface.for_vehicle
{
    partial class Edit_vehicle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_vehicle));
            number_label = new Label();
            number = new TextBox();
            update_button = new Button();
            delete_button = new Button();
            create_button = new Button();
            cancel_button = new Button();
            id_label = new Label();
            vehicle_registration_plate = new TextBox();
            vehicle_registration_plate_label = new Label();
            year_of_made_label = new Label();
            year_of_made = new NumericUpDown();
            in_operation_from = new DateTimePicker();
            in_operation_from_label = new Label();
            in_operation_to = new DateTimePicker();
            is_low_rise = new CheckBox();
            have_air_conditioning = new CheckBox();
            producer_combobox = new ComboBox();
            producer_label = new Label();
            mean_of_transport_label = new Label();
            mean_of_transport_combobox = new ComboBox();
            subtype_mean_of_transport_combobox = new ComboBox();
            subtype_mean_of_transport_label = new Label();
            owner_label = new Label();
            owner_combobox = new ComboBox();
            predecessor_combobox = new ComboBox();
            pattern_label = new Label();
            edit_pattern_button = new Button();
            is_predecessor = new CheckBox();
            pattern_list = new ListBox();
            direction_of_vehicle = new ComboBox();
            direction_of_vehicle_label = new Label();
            ((System.ComponentModel.ISupportInitialize)year_of_made).BeginInit();
            SuspendLayout();
            // 
            // number_label
            // 
            number_label.AutoSize = true;
            number_label.Location = new Point(44, 9);
            number_label.Margin = new Padding(2, 0, 2, 0);
            number_label.Name = "number_label";
            number_label.Size = new Size(85, 15);
            number_label.TabIndex = 0;
            number_label.Text = "evidenční číslo";
            // 
            // number
            // 
            number.Location = new Point(136, 7);
            number.Margin = new Padding(2);
            number.MaxLength = 100;
            number.Name = "number";
            number.Size = new Size(409, 23);
            number.TabIndex = 0;
            // 
            // update_button
            // 
            update_button.Location = new Point(301, 368);
            update_button.Margin = new Padding(2);
            update_button.Name = "update_button";
            update_button.Size = new Size(78, 23);
            update_button.TabIndex = 16;
            update_button.Text = "Upravit";
            update_button.UseVisualStyleBackColor = true;
            update_button.Click += update_button_Click;
            // 
            // delete_button
            // 
            delete_button.Location = new Point(218, 368);
            delete_button.Margin = new Padding(2);
            delete_button.Name = "delete_button";
            delete_button.Size = new Size(78, 23);
            delete_button.TabIndex = 15;
            delete_button.Text = "Smazat";
            delete_button.UseVisualStyleBackColor = true;
            delete_button.Click += delete_button_Click;
            // 
            // create_button
            // 
            create_button.Location = new Point(384, 368);
            create_button.Margin = new Padding(2);
            create_button.Name = "create_button";
            create_button.Size = new Size(78, 23);
            create_button.TabIndex = 17;
            create_button.Text = "Vytvořit";
            create_button.UseVisualStyleBackColor = true;
            create_button.Click += create_button_Click;
            // 
            // cancel_button
            // 
            cancel_button.Location = new Point(466, 368);
            cancel_button.Margin = new Padding(2);
            cancel_button.Name = "cancel_button";
            cancel_button.Size = new Size(78, 23);
            cancel_button.TabIndex = 18;
            cancel_button.Text = "Storno";
            cancel_button.UseVisualStyleBackColor = true;
            cancel_button.Click += cancel_button_Click;
            // 
            // id_label
            // 
            id_label.AutoSize = true;
            id_label.Location = new Point(480, 351);
            id_label.Margin = new Padding(2, 0, 2, 0);
            id_label.Name = "id_label";
            id_label.Size = new Size(61, 15);
            id_label.TabIndex = 28;
            id_label.Text = "undefined";
            id_label.Visible = false;
            // 
            // vehicle_registration_plate
            // 
            vehicle_registration_plate.Location = new Point(136, 34);
            vehicle_registration_plate.Margin = new Padding(2);
            vehicle_registration_plate.MaxLength = 100;
            vehicle_registration_plate.Name = "vehicle_registration_plate";
            vehicle_registration_plate.Size = new Size(409, 23);
            vehicle_registration_plate.TabIndex = 1;
            // 
            // vehicle_registration_plate_label
            // 
            vehicle_registration_plate_label.AutoSize = true;
            vehicle_registration_plate_label.Location = new Point(103, 36);
            vehicle_registration_plate_label.Margin = new Padding(2, 0, 2, 0);
            vehicle_registration_plate_label.Name = "vehicle_registration_plate_label";
            vehicle_registration_plate_label.Size = new Size(27, 15);
            vehicle_registration_plate_label.TabIndex = 29;
            vehicle_registration_plate_label.Text = "SPZ";
            // 
            // year_of_made_label
            // 
            year_of_made_label.AutoSize = true;
            year_of_made_label.Location = new Point(64, 62);
            year_of_made_label.Margin = new Padding(2, 0, 2, 0);
            year_of_made_label.Name = "year_of_made_label";
            year_of_made_label.Size = new Size(63, 15);
            year_of_made_label.TabIndex = 31;
            year_of_made_label.Text = "rok výroby";
            // 
            // year_of_made
            // 
            year_of_made.Location = new Point(136, 61);
            year_of_made.Margin = new Padding(2);
            year_of_made.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            year_of_made.Minimum = new decimal(new int[] { int.MaxValue, 0, 0, int.MinValue });
            year_of_made.Name = "year_of_made";
            year_of_made.Size = new Size(407, 23);
            year_of_made.TabIndex = 2;
            // 
            // in_operation_from
            // 
            in_operation_from.Location = new Point(136, 88);
            in_operation_from.Margin = new Padding(2);
            in_operation_from.Name = "in_operation_from";
            in_operation_from.Size = new Size(189, 23);
            in_operation_from.TabIndex = 3;
            // 
            // in_operation_from_label
            // 
            in_operation_from_label.AutoSize = true;
            in_operation_from_label.Location = new Point(22, 91);
            in_operation_from_label.Margin = new Padding(2, 0, 2, 0);
            in_operation_from_label.Name = "in_operation_from_label";
            in_operation_from_label.Size = new Size(101, 15);
            in_operation_from_label.TabIndex = 34;
            in_operation_from_label.Text = "v provozu od - do";
            // 
            // in_operation_to
            // 
            in_operation_to.Location = new Point(356, 88);
            in_operation_to.Margin = new Padding(2);
            in_operation_to.Name = "in_operation_to";
            in_operation_to.Size = new Size(189, 23);
            in_operation_to.TabIndex = 4;
            // 
            // is_low_rise
            // 
            is_low_rise.AutoSize = true;
            is_low_rise.Location = new Point(136, 115);
            is_low_rise.Margin = new Padding(2);
            is_low_rise.Name = "is_low_rise";
            is_low_rise.Size = new Size(111, 19);
            is_low_rise.TabIndex = 5;
            is_low_rise.Text = "je nízkopodlažní";
            is_low_rise.UseVisualStyleBackColor = true;
            // 
            // have_air_conditioning
            // 
            have_air_conditioning.AutoSize = true;
            have_air_conditioning.Location = new Point(257, 115);
            have_air_conditioning.Margin = new Padding(2);
            have_air_conditioning.Name = "have_air_conditioning";
            have_air_conditioning.Size = new Size(102, 19);
            have_air_conditioning.TabIndex = 6;
            have_air_conditioning.Text = "má klimatizaci";
            have_air_conditioning.UseVisualStyleBackColor = true;
            // 
            // producer_combobox
            // 
            producer_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            producer_combobox.FormattingEnabled = true;
            producer_combobox.Location = new Point(136, 136);
            producer_combobox.Margin = new Padding(2);
            producer_combobox.Name = "producer_combobox";
            producer_combobox.Size = new Size(409, 23);
            producer_combobox.TabIndex = 7;
            // 
            // producer_label
            // 
            producer_label.AutoSize = true;
            producer_label.Location = new Point(80, 138);
            producer_label.Margin = new Padding(2, 0, 2, 0);
            producer_label.Name = "producer_label";
            producer_label.Size = new Size(49, 15);
            producer_label.TabIndex = 40;
            producer_label.Text = "výrobce";
            // 
            // mean_of_transport_label
            // 
            mean_of_transport_label.AutoSize = true;
            mean_of_transport_label.Location = new Point(10, 165);
            mean_of_transport_label.Margin = new Padding(2, 0, 2, 0);
            mean_of_transport_label.Name = "mean_of_transport_label";
            mean_of_transport_label.Size = new Size(113, 15);
            mean_of_transport_label.TabIndex = 41;
            mean_of_transport_label.Text = "dopravní prostředek";
            // 
            // mean_of_transport_combobox
            // 
            mean_of_transport_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            mean_of_transport_combobox.FormattingEnabled = true;
            mean_of_transport_combobox.Location = new Point(136, 163);
            mean_of_transport_combobox.Margin = new Padding(2);
            mean_of_transport_combobox.Name = "mean_of_transport_combobox";
            mean_of_transport_combobox.Size = new Size(409, 23);
            mean_of_transport_combobox.TabIndex = 8;
            // 
            // subtype_mean_of_transport_combobox
            // 
            subtype_mean_of_transport_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            subtype_mean_of_transport_combobox.FormattingEnabled = true;
            subtype_mean_of_transport_combobox.Location = new Point(136, 190);
            subtype_mean_of_transport_combobox.Margin = new Padding(2);
            subtype_mean_of_transport_combobox.Name = "subtype_mean_of_transport_combobox";
            subtype_mean_of_transport_combobox.Size = new Size(409, 23);
            subtype_mean_of_transport_combobox.TabIndex = 9;
            // 
            // subtype_mean_of_transport_label
            // 
            subtype_mean_of_transport_label.AutoSize = true;
            subtype_mean_of_transport_label.Location = new Point(80, 192);
            subtype_mean_of_transport_label.Margin = new Padding(2, 0, 2, 0);
            subtype_mean_of_transport_label.Name = "subtype_mean_of_transport_label";
            subtype_mean_of_transport_label.Size = new Size(45, 15);
            subtype_mean_of_transport_label.TabIndex = 43;
            subtype_mean_of_transport_label.Text = "podtyp";
            // 
            // owner_label
            // 
            owner_label.AutoSize = true;
            owner_label.Location = new Point(16, 219);
            owner_label.Margin = new Padding(2, 0, 2, 0);
            owner_label.Name = "owner_label";
            owner_label.Size = new Size(107, 15);
            owner_label.TabIndex = 45;
            owner_label.Text = "dopravce / vlastník";
            // 
            // owner_combobox
            // 
            owner_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            owner_combobox.FormattingEnabled = true;
            owner_combobox.Location = new Point(136, 217);
            owner_combobox.Margin = new Padding(2);
            owner_combobox.Name = "owner_combobox";
            owner_combobox.Size = new Size(409, 23);
            owner_combobox.TabIndex = 10;
            // 
            // predecessor_combobox
            // 
            predecessor_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            predecessor_combobox.Enabled = false;
            predecessor_combobox.FormattingEnabled = true;
            predecessor_combobox.Location = new Point(136, 273);
            predecessor_combobox.Margin = new Padding(2);
            predecessor_combobox.Name = "predecessor_combobox";
            predecessor_combobox.Size = new Size(409, 23);
            predecessor_combobox.TabIndex = 12;
            // 
            // pattern_label
            // 
            pattern_label.AutoSize = true;
            pattern_label.Location = new Point(41, 300);
            pattern_label.Margin = new Padding(2, 0, 2, 0);
            pattern_label.Name = "pattern_label";
            pattern_label.Size = new Size(84, 15);
            pattern_label.TabIndex = 49;
            pattern_label.Text = "seznam nátěrů";
            // 
            // edit_pattern_button
            // 
            edit_pattern_button.Enabled = false;
            edit_pattern_button.Location = new Point(20, 327);
            edit_pattern_button.Margin = new Padding(2);
            edit_pattern_button.Name = "edit_pattern_button";
            edit_pattern_button.Size = new Size(113, 23);
            edit_pattern_button.TabIndex = 13;
            edit_pattern_button.Text = "spravovat";
            edit_pattern_button.UseVisualStyleBackColor = true;
            edit_pattern_button.Click += edit_pattern_button_Click;
            // 
            // is_predecessor
            // 
            is_predecessor.AutoSize = true;
            is_predecessor.Location = new Point(20, 274);
            is_predecessor.Margin = new Padding(2);
            is_predecessor.Name = "is_predecessor";
            is_predecessor.Size = new Size(109, 19);
            is_predecessor.TabIndex = 11;
            is_predecessor.Text = "má předchůdce";
            is_predecessor.UseVisualStyleBackColor = true;
            is_predecessor.CheckedChanged += is_predecessor_CheckedChanged;
            // 
            // pattern_list
            // 
            pattern_list.FormattingEnabled = true;
            pattern_list.ItemHeight = 15;
            pattern_list.Location = new Point(136, 300);
            pattern_list.Margin = new Padding(2);
            pattern_list.Name = "pattern_list";
            pattern_list.Size = new Size(409, 49);
            pattern_list.TabIndex = 14;
            // 
            // direction_of_vehicle
            // 
            direction_of_vehicle.FormattingEnabled = true;
            direction_of_vehicle.Location = new Point(136, 245);
            direction_of_vehicle.Name = "direction_of_vehicle";
            direction_of_vehicle.Size = new Size(409, 23);
            direction_of_vehicle.TabIndex = 50;
            // 
            // direction_of_vehicle_label
            // 
            direction_of_vehicle_label.AutoSize = true;
            direction_of_vehicle_label.Location = new Point(56, 248);
            direction_of_vehicle_label.Margin = new Padding(2, 0, 2, 0);
            direction_of_vehicle_label.Name = "direction_of_vehicle_label";
            direction_of_vehicle_label.Size = new Size(73, 15);
            direction_of_vehicle_label.TabIndex = 51;
            direction_of_vehicle_label.Text = "směr vozidla";
            // 
            // Edit_vehicle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 403);
            Controls.Add(direction_of_vehicle_label);
            Controls.Add(direction_of_vehicle);
            Controls.Add(is_predecessor);
            Controls.Add(edit_pattern_button);
            Controls.Add(pattern_list);
            Controls.Add(pattern_label);
            Controls.Add(predecessor_combobox);
            Controls.Add(owner_combobox);
            Controls.Add(owner_label);
            Controls.Add(subtype_mean_of_transport_combobox);
            Controls.Add(subtype_mean_of_transport_label);
            Controls.Add(mean_of_transport_combobox);
            Controls.Add(mean_of_transport_label);
            Controls.Add(producer_label);
            Controls.Add(producer_combobox);
            Controls.Add(have_air_conditioning);
            Controls.Add(is_low_rise);
            Controls.Add(in_operation_to);
            Controls.Add(in_operation_from_label);
            Controls.Add(in_operation_from);
            Controls.Add(year_of_made);
            Controls.Add(year_of_made_label);
            Controls.Add(vehicle_registration_plate);
            Controls.Add(vehicle_registration_plate_label);
            Controls.Add(id_label);
            Controls.Add(cancel_button);
            Controls.Add(create_button);
            Controls.Add(delete_button);
            Controls.Add(update_button);
            Controls.Add(number);
            Controls.Add(number_label);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Edit_vehicle";
            Text = "Nové vozidlo";
            ((System.ComponentModel.ISupportInitialize)year_of_made).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label number_label;
        private TextBox number;
        private Button update_button;
        private Button delete_button;
        private Button create_button;
        private Button cancel_button;
        private Label id_label;
        private TextBox vehicle_registration_plate;
        private Label vehicle_registration_plate_label;
        private Label year_of_made_label;
        private NumericUpDown year_of_made;
        private DateTimePicker in_operation_from;
        private Label in_operation_from_label;
        private DateTimePicker in_operation_to;
        private CheckBox is_low_rise;
        private CheckBox have_air_conditioning;
        private ComboBox producer_combobox;
        private Label producer_label;
        private Label mean_of_transport_label;
        private ComboBox mean_of_transport_combobox;
        private ComboBox subtype_mean_of_transport_combobox;
        private Label subtype_mean_of_transport_label;
        private Label owner_label;
        private ComboBox owner_combobox;
        private ComboBox predecessor_combobox;
        private Label pattern_label;
        private Button edit_pattern_button;
        private CheckBox is_predecessor;
        private ListBox pattern_list;
        private ComboBox direction_of_vehicle;
        private Label direction_of_vehicle_label;
    }
}
