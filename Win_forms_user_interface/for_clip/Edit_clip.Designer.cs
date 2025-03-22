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
            arrive = new RadioButton();
            depart = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)number_of_filming_day).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vehicles_on_clip).BeginInit();
            SuspendLayout();
            // 
            // name_of_clip_label
            // 
            name_of_clip_label.AutoSize = true;
            name_of_clip_label.Location = new Point(112, 18);
            name_of_clip_label.Margin = new Padding(2, 0, 2, 0);
            name_of_clip_label.Name = "name_of_clip_label";
            name_of_clip_label.Size = new Size(66, 15);
            name_of_clip_label.TabIndex = 0;
            name_of_clip_label.Text = "název klipu";
            // 
            // created_label
            // 
            created_label.AutoSize = true;
            created_label.Location = new Point(125, 43);
            created_label.Margin = new Padding(2, 0, 2, 0);
            created_label.Name = "created_label";
            created_label.Size = new Size(53, 15);
            created_label.TabIndex = 1;
            created_label.Text = "pořízeno";
            // 
            // number_of_filming_day_label
            // 
            number_of_filming_day_label.AutoSize = true;
            number_of_filming_day_label.Location = new Point(62, 70);
            number_of_filming_day_label.Margin = new Padding(2, 0, 2, 0);
            number_of_filming_day_label.Name = "number_of_filming_day_label";
            number_of_filming_day_label.Size = new Size(115, 15);
            number_of_filming_day_label.TabIndex = 2;
            number_of_filming_day_label.Text = "číslo natáčecího dne";
            // 
            // order_on_the_line_label
            // 
            order_on_the_line_label.AutoSize = true;
            order_on_the_line_label.Location = new Point(25, 121);
            order_on_the_line_label.Margin = new Padding(2, 0, 2, 0);
            order_on_the_line_label.Name = "order_on_the_line_label";
            order_on_the_line_label.Size = new Size(151, 15);
            order_on_the_line_label.TabIndex = 4;
            order_on_the_line_label.Text = "pořadí na lince / číslo spoje";
            // 
            // file_url_label
            // 
            file_url_label.AutoSize = true;
            file_url_label.Location = new Point(86, 148);
            file_url_label.Margin = new Padding(2, 0, 2, 0);
            file_url_label.Name = "file_url_label";
            file_url_label.Size = new Size(90, 15);
            file_url_label.TabIndex = 5;
            file_url_label.Text = "cesta k souboru";
            // 
            // lenght_of_clip_label
            // 
            lenght_of_clip_label.AutoSize = true;
            lenght_of_clip_label.Location = new Point(113, 172);
            lenght_of_clip_label.Margin = new Padding(2, 0, 2, 0);
            lenght_of_clip_label.Name = "lenght_of_clip_label";
            lenght_of_clip_label.Size = new Size(64, 15);
            lenght_of_clip_label.TabIndex = 6;
            lenght_of_clip_label.Text = "délka klipu";
            // 
            // name_of_clip
            // 
            name_of_clip.AllowDrop = true;
            name_of_clip.Location = new Point(186, 16);
            name_of_clip.Margin = new Padding(2);
            name_of_clip.MaxLength = 100;
            name_of_clip.Name = "name_of_clip";
            name_of_clip.Size = new Size(371, 23);
            name_of_clip.TabIndex = 0;
            // 
            // order_on_the_line
            // 
            order_on_the_line.Location = new Point(186, 118);
            order_on_the_line.Margin = new Padding(2);
            order_on_the_line.MaxLength = 20;
            order_on_the_line.Name = "order_on_the_line";
            order_on_the_line.Size = new Size(370, 23);
            order_on_the_line.TabIndex = 4;
            // 
            // created
            // 
            created.Location = new Point(186, 43);
            created.Margin = new Padding(2);
            created.Name = "created";
            created.Size = new Size(370, 23);
            created.TabIndex = 1;
            // 
            // number_of_filming_day
            // 
            number_of_filming_day.Location = new Point(186, 70);
            number_of_filming_day.Margin = new Padding(2);
            number_of_filming_day.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            number_of_filming_day.Minimum = new decimal(new int[] { int.MaxValue, 0, 0, int.MinValue });
            number_of_filming_day.Name = "number_of_filming_day";
            number_of_filming_day.Size = new Size(369, 23);
            number_of_filming_day.TabIndex = 2;
            // 
            // lenght_of_clip
            // 
            lenght_of_clip.Location = new Point(186, 172);
            lenght_of_clip.Margin = new Padding(2);
            lenght_of_clip.Name = "lenght_of_clip";
            lenght_of_clip.Size = new Size(370, 23);
            lenght_of_clip.TabIndex = 6;
            // 
            // update_button
            // 
            update_button.Location = new Point(313, 551);
            update_button.Margin = new Padding(2);
            update_button.Name = "update_button";
            update_button.Size = new Size(78, 23);
            update_button.TabIndex = 12;
            update_button.Text = "Upravit";
            update_button.UseVisualStyleBackColor = true;
            update_button.Click += update_button_Click;
            // 
            // delete_button
            // 
            delete_button.Location = new Point(231, 551);
            delete_button.Margin = new Padding(2);
            delete_button.Name = "delete_button";
            delete_button.Size = new Size(78, 23);
            delete_button.TabIndex = 11;
            delete_button.Text = "Smazat";
            delete_button.UseVisualStyleBackColor = true;
            delete_button.Click += delete_button_Click;
            // 
            // create_button
            // 
            create_button.Location = new Point(395, 551);
            create_button.Margin = new Padding(2);
            create_button.Name = "create_button";
            create_button.Size = new Size(78, 23);
            create_button.TabIndex = 13;
            create_button.Text = "Vytvořit";
            create_button.UseVisualStyleBackColor = true;
            create_button.Click += create_button_Click;
            // 
            // cancel_button
            // 
            cancel_button.Location = new Point(479, 551);
            cancel_button.Margin = new Padding(2);
            cancel_button.Name = "cancel_button";
            cancel_button.Size = new Size(78, 23);
            cancel_button.TabIndex = 14;
            cancel_button.Text = "Storno";
            cancel_button.UseVisualStyleBackColor = true;
            cancel_button.Click += cancel_button_Click;
            // 
            // name_of_stop_label
            // 
            name_of_stop_label.AutoSize = true;
            name_of_stop_label.Location = new Point(91, 201);
            name_of_stop_label.Margin = new Padding(2, 0, 2, 0);
            name_of_stop_label.Name = "name_of_stop_label";
            name_of_stop_label.Size = new Size(84, 15);
            name_of_stop_label.TabIndex = 17;
            name_of_stop_label.Text = "název zastávky";
            // 
            // format_label
            // 
            format_label.AutoSize = true;
            format_label.Location = new Point(83, 255);
            format_label.Margin = new Padding(2, 0, 2, 0);
            format_label.Name = "format_label";
            format_label.Size = new Size(93, 15);
            format_label.TabIndex = 18;
            format_label.Text = "formát záznamu";
            // 
            // name_of_line
            // 
            name_of_line.AutoSize = true;
            name_of_line.Location = new Point(148, 227);
            name_of_line.Margin = new Padding(2, 0, 2, 0);
            name_of_line.Name = "name_of_line";
            name_of_line.Size = new Size(32, 15);
            name_of_line.TabIndex = 19;
            name_of_line.Text = "linka";
            // 
            // stops_combobox
            // 
            stops_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            stops_combobox.FormattingEnabled = true;
            stops_combobox.Location = new Point(186, 199);
            stops_combobox.Margin = new Padding(2);
            stops_combobox.Name = "stops_combobox";
            stops_combobox.Size = new Size(370, 23);
            stops_combobox.TabIndex = 7;
            // 
            // lines_combobox
            // 
            lines_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            lines_combobox.FormattingEnabled = true;
            lines_combobox.Location = new Point(186, 226);
            lines_combobox.Margin = new Padding(2);
            lines_combobox.Name = "lines_combobox";
            lines_combobox.Size = new Size(370, 23);
            lines_combobox.TabIndex = 8;
            // 
            // formats_combobox
            // 
            formats_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            formats_combobox.FormattingEnabled = true;
            formats_combobox.Location = new Point(186, 253);
            formats_combobox.Margin = new Padding(2);
            formats_combobox.Name = "formats_combobox";
            formats_combobox.Size = new Size(370, 23);
            formats_combobox.TabIndex = 9;
            // 
            // id_of_clip_label
            // 
            id_of_clip_label.AutoSize = true;
            id_of_clip_label.Location = new Point(492, 281);
            id_of_clip_label.Margin = new Padding(2, 0, 2, 0);
            id_of_clip_label.Name = "id_of_clip_label";
            id_of_clip_label.Size = new Size(61, 15);
            id_of_clip_label.TabIndex = 28;
            id_of_clip_label.Text = "undefined";
            id_of_clip_label.Visible = false;
            // 
            // vehicles_on_clip
            // 
            vehicles_on_clip.AllowUserToAddRows = false;
            vehicles_on_clip.AllowUserToDeleteRows = false;
            vehicles_on_clip.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            vehicles_on_clip.Location = new Point(100, 333);
            vehicles_on_clip.Margin = new Padding(2);
            vehicles_on_clip.Name = "vehicles_on_clip";
            vehicles_on_clip.ReadOnly = true;
            vehicles_on_clip.RowHeadersWidth = 62;
            vehicles_on_clip.Size = new Size(457, 169);
            vehicles_on_clip.TabIndex = 32;
            vehicles_on_clip.CellClick += vehicles_on_clip_CellClick;
            // 
            // remove_from_list
            // 
            remove_from_list.Location = new Point(100, 506);
            remove_from_list.Margin = new Padding(2);
            remove_from_list.Name = "remove_from_list";
            remove_from_list.Size = new Size(147, 23);
            remove_from_list.TabIndex = 33;
            remove_from_list.Text = "Smazat ze seznamu";
            remove_from_list.UseVisualStyleBackColor = true;
            remove_from_list.Click += remove_from_list_Click;
            // 
            // add_to_list
            // 
            add_to_list.Location = new Point(409, 303);
            add_to_list.Margin = new Padding(2);
            add_to_list.Name = "add_to_list";
            add_to_list.Size = new Size(148, 26);
            add_to_list.TabIndex = 31;
            add_to_list.Text = "přidat na seznam";
            add_to_list.UseVisualStyleBackColor = true;
            add_to_list.Click += add_to_list_Click;
            // 
            // vehicle_combobox
            // 
            vehicle_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            vehicle_combobox.FormattingEnabled = true;
            vehicle_combobox.Location = new Point(100, 304);
            vehicle_combobox.Margin = new Padding(2);
            vehicle_combobox.Name = "vehicle_combobox";
            vehicle_combobox.Size = new Size(306, 23);
            vehicle_combobox.TabIndex = 29;
            // 
            // vehicle_label
            // 
            vehicle_label.AutoSize = true;
            vehicle_label.Location = new Point(47, 306);
            vehicle_label.Margin = new Padding(2, 0, 2, 0);
            vehicle_label.Name = "vehicle_label";
            vehicle_label.Size = new Size(45, 15);
            vehicle_label.TabIndex = 30;
            vehicle_label.Text = "vozidlo";
            // 
            // vehicles_on_clip_label
            // 
            vehicles_on_clip_label.AutoSize = true;
            vehicles_on_clip_label.Location = new Point(100, 281);
            vehicles_on_clip_label.Name = "vehicles_on_clip_label";
            vehicles_on_clip_label.Size = new Size(0, 15);
            vehicles_on_clip_label.TabIndex = 34;
            // 
            // file_url
            // 
            file_url.FormattingEnabled = true;
            file_url.Location = new Point(186, 145);
            file_url.Name = "file_url";
            file_url.Size = new Size(370, 23);
            file_url.TabIndex = 35;
            // 
            // play_clip
            // 
            play_clip.Enabled = false;
            play_clip.Location = new Point(441, 506);
            play_clip.Name = "play_clip";
            play_clip.Size = new Size(116, 23);
            play_clip.TabIndex = 36;
            play_clip.Text = "Zobrazit záznam";
            play_clip.UseVisualStyleBackColor = true;
            play_clip.Click += play_clip_Click;
            // 
            // arrive
            // 
            arrive.AutoSize = true;
            arrive.Location = new Point(186, 96);
            arrive.Name = "arrive";
            arrive.Size = new Size(60, 19);
            arrive.TabIndex = 37;
            arrive.TabStop = true;
            arrive.Text = "příjezd";
            arrive.UseVisualStyleBackColor = true;
            // 
            // depart
            // 
            depart.AutoSize = true;
            depart.Location = new Point(252, 96);
            depart.Name = "depart";
            depart.Size = new Size(60, 19);
            depart.TabIndex = 38;
            depart.TabStop = true;
            depart.Text = "odjezd";
            depart.UseVisualStyleBackColor = true;
            // 
            // Edit_clip
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 585);
            Controls.Add(depart);
            Controls.Add(arrive);
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
            Controls.Add(number_of_filming_day_label);
            Controls.Add(created_label);
            Controls.Add(name_of_clip_label);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
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
        private RadioButton arrive;
        private RadioButton depart;
    }
}