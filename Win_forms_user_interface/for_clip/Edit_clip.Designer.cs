namespace evidence_clip_about_public_transport.Win_forms_user_interface.for_clip
{
    partial class Edit_clip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_clip));
            name_of_clip_label = new Label();
            created_label = new Label();
            number_of_filming_day_label = new Label();
            arrive_or_depart = new CheckBox();
            order_on_the_line_label = new Label();
            file_url_label = new Label();
            lenght_of_clip_label = new Label();
            name_of_clip = new TextBox();
            order_on_the_line = new TextBox();
            created = new DateTimePicker();
            number_of_filming_day = new NumericUpDown();
            lenght_of_clip = new TextBox();
            update_button = new Button();
            delete_button = new Button();
            create_button = new Button();
            cancel_button = new Button();
            name_of_stop_label = new Label();
            format_label = new Label();
            name_of_line = new Label();
            stops_combobox = new ComboBox();
            lines_combobox = new ComboBox();
            formats_combobox = new ComboBox();
            id_of_clip_label = new Label();
            vehicles_on_clip = new DataGridView();
            remove_from_list = new Button();
            add_to_list = new Button();
            vehicle_combobox = new ComboBox();
            vehicle_label = new Label();
            vehicles_on_clip_label = new Label();
            file_url = new ComboBox();
            play_clip = new Button();
            ((System.ComponentModel.ISupportInitialize)number_of_filming_day).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vehicles_on_clip).BeginInit();
            SuspendLayout();
            // 
            // name_of_clip_label
            // 
            name_of_clip_label.AutoSize = true;
            name_of_clip_label.Location = new Point(160, 30);
            name_of_clip_label.Name = "name_of_clip_label";
            name_of_clip_label.Size = new Size(100, 25);
            name_of_clip_label.TabIndex = 0;
            name_of_clip_label.Text = "název klipu";
            // 
            // created_label
            // 
            created_label.AutoSize = true;
            created_label.Location = new Point(179, 72);
            created_label.Name = "created_label";
            created_label.Size = new Size(82, 25);
            created_label.TabIndex = 1;
            created_label.Text = "pořízeno";
            // 
            // number_of_filming_day_label
            // 
            number_of_filming_day_label.AutoSize = true;
            number_of_filming_day_label.Location = new Point(89, 117);
            number_of_filming_day_label.Name = "number_of_filming_day_label";
            number_of_filming_day_label.Size = new Size(171, 25);
            number_of_filming_day_label.TabIndex = 2;
            number_of_filming_day_label.Text = "číslo natáčecího dne";
            // 
            // arrive_or_depart
            // 
            arrive_or_depart.AutoSize = true;
            arrive_or_depart.Location = new Point(266, 162);
            arrive_or_depart.Name = "arrive_or_depart";
            arrive_or_depart.Size = new Size(200, 29);
            arrive_or_depart.TabIndex = 3;
            arrive_or_depart.Text = "příjezd, nebo odjezd";
            arrive_or_depart.UseVisualStyleBackColor = true;
            // 
            // order_on_the_line_label
            // 
            order_on_the_line_label.AutoSize = true;
            order_on_the_line_label.Location = new Point(36, 202);
            order_on_the_line_label.Name = "order_on_the_line_label";
            order_on_the_line_label.Size = new Size(228, 25);
            order_on_the_line_label.TabIndex = 4;
            order_on_the_line_label.Text = "pořadí na lince / číslo spoje";
            // 
            // file_url_label
            // 
            file_url_label.AutoSize = true;
            file_url_label.Location = new Point(123, 247);
            file_url_label.Name = "file_url_label";
            file_url_label.Size = new Size(138, 25);
            file_url_label.TabIndex = 5;
            file_url_label.Text = "cesta k souboru";
            // 
            // lenght_of_clip_label
            // 
            lenght_of_clip_label.AutoSize = true;
            lenght_of_clip_label.Location = new Point(161, 287);
            lenght_of_clip_label.Name = "lenght_of_clip_label";
            lenght_of_clip_label.Size = new Size(97, 25);
            lenght_of_clip_label.TabIndex = 6;
            lenght_of_clip_label.Text = "délka klipu";
            // 
            // name_of_clip
            // 
            name_of_clip.AllowDrop = true;
            name_of_clip.Location = new Point(266, 27);
            name_of_clip.MaxLength = 100;
            name_of_clip.Name = "name_of_clip";
            name_of_clip.Size = new Size(528, 31);
            name_of_clip.TabIndex = 0;
            // 
            // order_on_the_line
            // 
            order_on_the_line.Location = new Point(266, 197);
            order_on_the_line.MaxLength = 20;
            order_on_the_line.Name = "order_on_the_line";
            order_on_the_line.Size = new Size(527, 31);
            order_on_the_line.TabIndex = 4;
            // 
            // created
            // 
            created.Location = new Point(266, 72);
            created.Name = "created";
            created.Size = new Size(527, 31);
            created.TabIndex = 1;
            // 
            // number_of_filming_day
            // 
            number_of_filming_day.Location = new Point(266, 117);
            number_of_filming_day.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            number_of_filming_day.Minimum = new decimal(new int[] { int.MaxValue, 0, 0, int.MinValue });
            number_of_filming_day.Name = "number_of_filming_day";
            number_of_filming_day.Size = new Size(527, 31);
            number_of_filming_day.TabIndex = 2;
            // 
            // lenght_of_clip
            // 
            lenght_of_clip.Location = new Point(266, 287);
            lenght_of_clip.Name = "lenght_of_clip";
            lenght_of_clip.Size = new Size(527, 31);
            lenght_of_clip.TabIndex = 6;
            // 
            // update_button
            // 
            update_button.Location = new Point(447, 918);
            update_button.Name = "update_button";
            update_button.Size = new Size(111, 38);
            update_button.TabIndex = 12;
            update_button.Text = "Upravit";
            update_button.UseVisualStyleBackColor = true;
            update_button.Click += update_button_Click;
            // 
            // delete_button
            // 
            delete_button.Location = new Point(330, 918);
            delete_button.Name = "delete_button";
            delete_button.Size = new Size(111, 38);
            delete_button.TabIndex = 11;
            delete_button.Text = "Smazat";
            delete_button.UseVisualStyleBackColor = true;
            delete_button.Click += delete_button_Click;
            // 
            // create_button
            // 
            create_button.Location = new Point(564, 918);
            create_button.Name = "create_button";
            create_button.Size = new Size(111, 38);
            create_button.TabIndex = 13;
            create_button.Text = "Vytvořit";
            create_button.UseVisualStyleBackColor = true;
            create_button.Click += create_button_Click;
            // 
            // cancel_button
            // 
            cancel_button.Location = new Point(684, 918);
            cancel_button.Name = "cancel_button";
            cancel_button.Size = new Size(111, 38);
            cancel_button.TabIndex = 14;
            cancel_button.Text = "Storno";
            cancel_button.UseVisualStyleBackColor = true;
            cancel_button.Click += cancel_button_Click;
            // 
            // name_of_stop_label
            // 
            name_of_stop_label.AutoSize = true;
            name_of_stop_label.Location = new Point(130, 335);
            name_of_stop_label.Name = "name_of_stop_label";
            name_of_stop_label.Size = new Size(129, 25);
            name_of_stop_label.TabIndex = 17;
            name_of_stop_label.Text = "název zastávky";
            // 
            // format_label
            // 
            format_label.AutoSize = true;
            format_label.Location = new Point(119, 425);
            format_label.Name = "format_label";
            format_label.Size = new Size(141, 25);
            format_label.TabIndex = 18;
            format_label.Text = "formát záznamu";
            // 
            // name_of_line
            // 
            name_of_line.AutoSize = true;
            name_of_line.Location = new Point(211, 378);
            name_of_line.Name = "name_of_line";
            name_of_line.Size = new Size(48, 25);
            name_of_line.TabIndex = 19;
            name_of_line.Text = "linka";
            // 
            // stops_combobox
            // 
            stops_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            stops_combobox.FormattingEnabled = true;
            stops_combobox.Location = new Point(266, 332);
            stops_combobox.Name = "stops_combobox";
            stops_combobox.Size = new Size(527, 33);
            stops_combobox.TabIndex = 7;
            // 
            // lines_combobox
            // 
            lines_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            lines_combobox.FormattingEnabled = true;
            lines_combobox.Location = new Point(266, 377);
            lines_combobox.Name = "lines_combobox";
            lines_combobox.Size = new Size(527, 33);
            lines_combobox.TabIndex = 8;
            // 
            // formats_combobox
            // 
            formats_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            formats_combobox.FormattingEnabled = true;
            formats_combobox.Location = new Point(266, 422);
            formats_combobox.Name = "formats_combobox";
            formats_combobox.Size = new Size(527, 33);
            formats_combobox.TabIndex = 9;
            // 
            // id_of_clip_label
            // 
            id_of_clip_label.AutoSize = true;
            id_of_clip_label.Location = new Point(703, 468);
            id_of_clip_label.Name = "id_of_clip_label";
            id_of_clip_label.Size = new Size(92, 25);
            id_of_clip_label.TabIndex = 28;
            id_of_clip_label.Text = "undefined";
            id_of_clip_label.Visible = false;
            // 
            // vehicles_on_clip
            // 
            vehicles_on_clip.AllowUserToAddRows = false;
            vehicles_on_clip.AllowUserToDeleteRows = false;
            vehicles_on_clip.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            vehicles_on_clip.Location = new Point(143, 555);
            vehicles_on_clip.Name = "vehicles_on_clip";
            vehicles_on_clip.ReadOnly = true;
            vehicles_on_clip.RowHeadersWidth = 62;
            vehicles_on_clip.Size = new Size(653, 282);
            vehicles_on_clip.TabIndex = 32;
            vehicles_on_clip.CellClick += vehicles_on_clip_CellClick;
            // 
            // remove_from_list
            // 
            remove_from_list.Location = new Point(143, 843);
            remove_from_list.Name = "remove_from_list";
            remove_from_list.Size = new Size(210, 38);
            remove_from_list.TabIndex = 33;
            remove_from_list.Text = "Smazat ze seznamu";
            remove_from_list.UseVisualStyleBackColor = true;
            remove_from_list.Click += remove_from_list_Click;
            // 
            // add_to_list
            // 
            add_to_list.Location = new Point(584, 505);
            add_to_list.Name = "add_to_list";
            add_to_list.Size = new Size(211, 43);
            add_to_list.TabIndex = 31;
            add_to_list.Text = "přidat na seznam";
            add_to_list.UseVisualStyleBackColor = true;
            add_to_list.Click += add_to_list_Click;
            // 
            // vehicle_combobox
            // 
            vehicle_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            vehicle_combobox.FormattingEnabled = true;
            vehicle_combobox.Location = new Point(143, 507);
            vehicle_combobox.Name = "vehicle_combobox";
            vehicle_combobox.Size = new Size(435, 33);
            vehicle_combobox.TabIndex = 29;
            // 
            // vehicle_label
            // 
            vehicle_label.AutoSize = true;
            vehicle_label.Location = new Point(67, 510);
            vehicle_label.Name = "vehicle_label";
            vehicle_label.Size = new Size(70, 25);
            vehicle_label.TabIndex = 30;
            vehicle_label.Text = "vozidlo";
            // 
            // vehicles_on_clip_label
            // 
            vehicles_on_clip_label.AutoSize = true;
            vehicles_on_clip_label.Location = new Point(143, 468);
            vehicles_on_clip_label.Margin = new Padding(4, 0, 4, 0);
            vehicles_on_clip_label.Name = "vehicles_on_clip_label";
            vehicles_on_clip_label.Size = new Size(0, 25);
            vehicles_on_clip_label.TabIndex = 34;
            // 
            // file_url
            // 
            file_url.FormattingEnabled = true;
            file_url.Location = new Point(266, 242);
            file_url.Margin = new Padding(4, 5, 4, 5);
            file_url.Name = "file_url";
            file_url.Size = new Size(527, 33);
            file_url.TabIndex = 35;
            // 
            // play_clip
            // 
            play_clip.Enabled = false;
            play_clip.Location = new Point(630, 843);
            play_clip.Margin = new Padding(4, 5, 4, 5);
            play_clip.Name = "play_clip";
            play_clip.Size = new Size(166, 38);
            play_clip.TabIndex = 36;
            play_clip.Text = "Zobrazit záznam";
            play_clip.UseVisualStyleBackColor = true;
            play_clip.Click += play_clip_Click;
            // 
            // Edit_clip
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 975);
            Controls.Add(play_clip);
            Controls.Add(file_url);
            Controls.Add(vehicles_on_clip_label);
            Controls.Add(vehicles_on_clip);
            Controls.Add(remove_from_list);
            Controls.Add(add_to_list);
            Controls.Add(vehicle_combobox);
            Controls.Add(vehicle_label);
            Controls.Add(id_of_clip_label);
            Controls.Add(formats_combobox);
            Controls.Add(lines_combobox);
            Controls.Add(stops_combobox);
            Controls.Add(name_of_line);
            Controls.Add(format_label);
            Controls.Add(name_of_stop_label);
            Controls.Add(cancel_button);
            Controls.Add(create_button);
            Controls.Add(delete_button);
            Controls.Add(update_button);
            Controls.Add(lenght_of_clip);
            Controls.Add(number_of_filming_day);
            Controls.Add(created);
            Controls.Add(order_on_the_line);
            Controls.Add(name_of_clip);
            Controls.Add(lenght_of_clip_label);
            Controls.Add(file_url_label);
            Controls.Add(order_on_the_line_label);
            Controls.Add(arrive_or_depart);
            Controls.Add(number_of_filming_day_label);
            Controls.Add(created_label);
            Controls.Add(name_of_clip_label);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Edit_clip";
            Text = "Správa klipů";
            DragDrop += Edit_clip_DragDrop;
            DragEnter += Edit_clip_DragEnter_1;
            ((System.ComponentModel.ISupportInitialize)number_of_filming_day).EndInit();
            ((System.ComponentModel.ISupportInitialize)vehicles_on_clip).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label name_of_clip_label;
        private Label created_label;
        private Label number_of_filming_day_label;
        private CheckBox arrive_or_depart;
        private Label order_on_the_line_label;
        private Label file_url_label;
        private Label lenght_of_clip_label;
        private TextBox name_of_clip;
        private TextBox order_on_the_line;
        private DateTimePicker created;
        private NumericUpDown number_of_filming_day;
        private TextBox lenght_of_clip;
        private Button update_button;
        private Button delete_button;
        private Button create_button;
        private Button cancel_button;
        private Label name_of_stop_label;
        private Label format_label;
        private Label name_of_line;
        private ComboBox stops_combobox;
        private ComboBox lines_combobox;
        private ComboBox formats_combobox;
        private Label id_of_clip_label;
        private DataGridView vehicles_on_clip;
        private Button remove_from_list;
        private Button add_to_list;
        private ComboBox vehicle_combobox;
        private Label vehicle_label;
        private Label vehicles_on_clip_label;
        private ComboBox file_url;
        private Button play_clip;
    }
}