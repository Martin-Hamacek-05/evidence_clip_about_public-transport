namespace evidence_clip_about_public_transport.Win_forms_user_interface.for_formats
{
    partial class Edit_format
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_format));
            name_label = new Label();
            height_label = new Label();
            name_ = new TextBox();
            height = new NumericUpDown();
            update_button = new Button();
            delete_button = new Button();
            create_button = new Button();
            cancel_button = new Button();
            type_frame = new Label();
            type_frames_combobox = new ComboBox();
            id_of_format_label = new Label();
            width_label = new Label();
            width = new NumericUpDown();
            fps = new NumericUpDown();
            fps_label = new Label();
            audio_counttrack = new NumericUpDown();
            audio_counttrack_label = new Label();
            added = new Label();
            ((System.ComponentModel.ISupportInitialize)height).BeginInit();
            ((System.ComponentModel.ISupportInitialize)width).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fps).BeginInit();
            ((System.ComponentModel.ISupportInitialize)audio_counttrack).BeginInit();
            SuspendLayout();
            // 
            // name_label
            // 
            name_label.AutoSize = true;
            name_label.Location = new Point(94, 18);
            name_label.Margin = new Padding(2, 0, 2, 0);
            name_label.Name = "name_label";
            name_label.Size = new Size(83, 15);
            name_label.TabIndex = 0;
            name_label.Text = "název formátu";
            // 
            // height_label
            // 
            height_label.AutoSize = true;
            height_label.Location = new Point(110, 45);
            height_label.Margin = new Padding(2, 0, 2, 0);
            height_label.Name = "height_label";
            height_label.Size = new Size(69, 15);
            height_label.TabIndex = 2;
            height_label.Text = "výška (v Px)";
            // 
            // name_
            // 
            name_.Location = new Point(186, 16);
            name_.Margin = new Padding(2);
            name_.MaxLength = 100;
            name_.Name = "name_";
            name_.Size = new Size(370, 23);
            name_.TabIndex = 0;
            // 
            // height
            // 
            height.Location = new Point(186, 43);
            height.Margin = new Padding(2);
            height.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            height.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            height.Name = "height";
            height.Size = new Size(369, 23);
            height.TabIndex = 1;
            height.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // update_button
            // 
            update_button.Location = new Point(310, 238);
            update_button.Margin = new Padding(2);
            update_button.Name = "update_button";
            update_button.Size = new Size(78, 23);
            update_button.TabIndex = 7;
            update_button.Text = "Upravit";
            update_button.UseVisualStyleBackColor = true;
            update_button.Click += update_button_Click;
            // 
            // delete_button
            // 
            delete_button.Location = new Point(227, 238);
            delete_button.Margin = new Padding(2);
            delete_button.Name = "delete_button";
            delete_button.Size = new Size(78, 23);
            delete_button.TabIndex = 6;
            delete_button.Text = "Smazat";
            delete_button.UseVisualStyleBackColor = true;
            delete_button.Click += delete_button_Click;
            // 
            // create_button
            // 
            create_button.Location = new Point(392, 238);
            create_button.Margin = new Padding(2);
            create_button.Name = "create_button";
            create_button.Size = new Size(78, 23);
            create_button.TabIndex = 8;
            create_button.Text = "Vytvořit";
            create_button.UseVisualStyleBackColor = true;
            create_button.Click += create_button_Click;
            // 
            // cancel_button
            // 
            cancel_button.Location = new Point(475, 238);
            cancel_button.Margin = new Padding(2);
            cancel_button.Name = "cancel_button";
            cancel_button.Size = new Size(78, 23);
            cancel_button.TabIndex = 9;
            cancel_button.Text = "Storno";
            cancel_button.UseVisualStyleBackColor = true;
            cancel_button.Click += cancel_button_Click;
            // 
            // type_frame
            // 
            type_frame.AutoSize = true;
            type_frame.Location = new Point(111, 156);
            type_frame.Margin = new Padding(2, 0, 2, 0);
            type_frame.Name = "type_frame";
            type_frame.Size = new Size(67, 15);
            type_frame.TabIndex = 17;
            type_frame.Text = "Typ snímku";
            // 
            // type_frames_combobox
            // 
            type_frames_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            type_frames_combobox.FormattingEnabled = true;
            type_frames_combobox.Location = new Point(186, 154);
            type_frames_combobox.Margin = new Padding(2);
            type_frames_combobox.Name = "type_frames_combobox";
            type_frames_combobox.Size = new Size(370, 23);
            type_frames_combobox.TabIndex = 5;
            // 
            // id_of_format_label
            // 
            id_of_format_label.AutoSize = true;
            id_of_format_label.Location = new Point(92, 238);
            id_of_format_label.Margin = new Padding(2, 0, 2, 0);
            id_of_format_label.Name = "id_of_format_label";
            id_of_format_label.Size = new Size(61, 15);
            id_of_format_label.TabIndex = 28;
            id_of_format_label.Text = "undefined";
            id_of_format_label.Visible = false;
            // 
            // width_label
            // 
            width_label.AutoSize = true;
            width_label.Location = new Point(116, 72);
            width_label.Margin = new Padding(2, 0, 2, 0);
            width_label.Name = "width_label";
            width_label.Size = new Size(64, 15);
            width_label.TabIndex = 29;
            width_label.Text = "šířka (v Px)";
            // 
            // width
            // 
            width.Location = new Point(186, 70);
            width.Margin = new Padding(2);
            width.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            width.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            width.Name = "width";
            width.Size = new Size(369, 23);
            width.TabIndex = 2;
            width.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // fps
            // 
            fps.Location = new Point(186, 97);
            fps.Margin = new Padding(2);
            fps.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            fps.Name = "fps";
            fps.Size = new Size(369, 23);
            fps.TabIndex = 3;
            // 
            // fps_label
            // 
            fps_label.AutoSize = true;
            fps_label.Location = new Point(52, 98);
            fps_label.Margin = new Padding(2, 0, 2, 0);
            fps_label.Name = "fps_label";
            fps_label.Size = new Size(123, 15);
            fps_label.TabIndex = 32;
            fps_label.Text = "obnovovací frekvence";
            // 
            // audio_counttrack
            // 
            audio_counttrack.Location = new Point(186, 124);
            audio_counttrack.Margin = new Padding(2);
            audio_counttrack.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            audio_counttrack.Name = "audio_counttrack";
            audio_counttrack.Size = new Size(369, 23);
            audio_counttrack.TabIndex = 4;
            // 
            // audio_counttrack_label
            // 
            audio_counttrack_label.AutoSize = true;
            audio_counttrack_label.Location = new Point(78, 125);
            audio_counttrack_label.Margin = new Padding(2, 0, 2, 0);
            audio_counttrack_label.Name = "audio_counttrack_label";
            audio_counttrack_label.Size = new Size(96, 15);
            audio_counttrack_label.TabIndex = 34;
            audio_counttrack_label.Text = "počet audio stop";
            // 
            // added
            // 
            added.AutoSize = true;
            added.Location = new Point(197, 199);
            added.Name = "added";
            added.Size = new Size(0, 15);
            added.TabIndex = 35;
            // 
            // Edit_format
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 272);
            Controls.Add(added);
            Controls.Add(audio_counttrack_label);
            Controls.Add(audio_counttrack);
            Controls.Add(fps_label);
            Controls.Add(fps);
            Controls.Add(width);
            Controls.Add(width_label);
            Controls.Add(id_of_format_label);
            Controls.Add(type_frames_combobox);
            Controls.Add(type_frame);
            Controls.Add(cancel_button);
            Controls.Add(create_button);
            Controls.Add(delete_button);
            Controls.Add(update_button);
            Controls.Add(height);
            Controls.Add(name_);
            Controls.Add(height_label);
            Controls.Add(name_label);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Edit_format";
            Text = "Nový formát";
            ((System.ComponentModel.ISupportInitialize)height).EndInit();
            ((System.ComponentModel.ISupportInitialize)width).EndInit();
            ((System.ComponentModel.ISupportInitialize)fps).EndInit();
            ((System.ComponentModel.ISupportInitialize)audio_counttrack).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label name_label;
        private Label height_label;
        private TextBox name_;
        private NumericUpDown height;
        private Button update_button;
        private Button delete_button;
        private Button create_button;
        private Button cancel_button;
        private Label type_frame;
        private ComboBox type_frames_combobox;
        private Label id_of_format_label;
        private Label width_label;
        private NumericUpDown width;
        private NumericUpDown fps;
        private Label fps_label;
        private NumericUpDown audio_counttrack;
        private Label audio_counttrack_label;
        private Label added;
    }
}