﻿namespace evidence_clip_about_public_transport.Win_forms_user_interface.other
{
    partial class Styles_for_html
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
            list_of_fonts = new ComboBox();
            differentiate_even_rows = new CheckBox();
            font_label = new Label();
            colour_of_text_label = new Label();
            set_colour = new Button();
            colour_of_text = new TextBox();
            size_of_font = new NumericUpDown();
            size_of_font_label = new Label();
            border_of_cell_label = new Label();
            border_of_cell = new NumericUpDown();
            colour_of_background = new TextBox();
            set_colour_for_background = new Button();
            colour_of_background_label = new Label();
            type_of_row = new ComboBox();
            type_of_row_label = new Label();
            colour_of_row = new TextBox();
            set_colour_of_row = new Button();
            colour_of_row_label = new Label();
            save = new Button();
            level_of_text_label = new Label();
            levels_of_text = new ComboBox();
            colour_of_border = new TextBox();
            colour_of_border_label = new Label();
            set_colour_for_border = new Button();
            width_label = new Label();
            height_label = new Label();
            width_page = new NumericUpDown();
            height_page = new NumericUpDown();
            units = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)size_of_font).BeginInit();
            ((System.ComponentModel.ISupportInitialize)border_of_cell).BeginInit();
            ((System.ComponentModel.ISupportInitialize)width_page).BeginInit();
            ((System.ComponentModel.ISupportInitialize)height_page).BeginInit();
            SuspendLayout();
            // 
            // list_of_fonts
            // 
            list_of_fonts.DropDownStyle = ComboBoxStyle.DropDownList;
            list_of_fonts.FormattingEnabled = true;
            list_of_fonts.Location = new Point(177, 31);
            list_of_fonts.Margin = new Padding(2);
            list_of_fonts.Name = "list_of_fonts";
            list_of_fonts.Size = new Size(129, 23);
            list_of_fonts.TabIndex = 1;
            list_of_fonts.SelectedIndexChanged += list_of_fonts_SelectedIndexChanged;
            // 
            // differentiate_even_rows
            // 
            differentiate_even_rows.AutoSize = true;
            differentiate_even_rows.Location = new Point(512, 175);
            differentiate_even_rows.Margin = new Padding(2);
            differentiate_even_rows.Name = "differentiate_even_rows";
            differentiate_even_rows.Size = new Size(173, 19);
            differentiate_even_rows.TabIndex = 11;
            differentiate_even_rows.Text = "rozlišovat liché a sudé řádky";
            differentiate_even_rows.UseVisualStyleBackColor = true;
            // 
            // font_label
            // 
            font_label.AutoSize = true;
            font_label.Location = new Point(99, 32);
            font_label.Margin = new Padding(2, 0, 2, 0);
            font_label.Name = "font_label";
            font_label.Size = new Size(69, 15);
            font_label.TabIndex = 4;
            font_label.Text = "název fontu";
            // 
            // colour_of_text_label
            // 
            colour_of_text_label.AutoSize = true;
            colour_of_text_label.Location = new Point(134, 59);
            colour_of_text_label.Margin = new Padding(2, 0, 2, 0);
            colour_of_text_label.Name = "colour_of_text_label";
            colour_of_text_label.Size = new Size(36, 15);
            colour_of_text_label.TabIndex = 5;
            colour_of_text_label.Text = "barva";
            // 
            // set_colour
            // 
            set_colour.Location = new Point(310, 58);
            set_colour.Margin = new Padding(2);
            set_colour.Name = "set_colour";
            set_colour.Size = new Size(78, 23);
            set_colour.TabIndex = 3;
            set_colour.Text = "Vybrat";
            set_colour.UseVisualStyleBackColor = true;
            set_colour.Click += set_colour_Click;
            // 
            // colour_of_text
            // 
            colour_of_text.Location = new Point(177, 58);
            colour_of_text.Margin = new Padding(2);
            colour_of_text.Name = "colour_of_text";
            colour_of_text.Size = new Size(129, 23);
            colour_of_text.TabIndex = 2;
            colour_of_text.TextChanged += colour_of_text_TextChanged;
            // 
            // size_of_font
            // 
            size_of_font.Location = new Point(177, 85);
            size_of_font.Margin = new Padding(2);
            size_of_font.Name = "size_of_font";
            size_of_font.Size = new Size(126, 23);
            size_of_font.TabIndex = 4;
            size_of_font.Value = new decimal(new int[] { 11, 0, 0, 0 });
            size_of_font.ValueChanged += size_of_font_ValueChanged;
            // 
            // size_of_font_label
            // 
            size_of_font_label.AutoSize = true;
            size_of_font_label.Location = new Point(89, 86);
            size_of_font_label.Margin = new Padding(2, 0, 2, 0);
            size_of_font_label.Name = "size_of_font_label";
            size_of_font_label.Size = new Size(79, 15);
            size_of_font_label.TabIndex = 9;
            size_of_font_label.Text = "velikost fontu";
            // 
            // border_of_cell_label
            // 
            border_of_cell_label.AutoSize = true;
            border_of_cell_label.Location = new Point(74, 128);
            border_of_cell_label.Margin = new Padding(2, 0, 2, 0);
            border_of_cell_label.Name = "border_of_cell_label";
            border_of_cell_label.Size = new Size(99, 15);
            border_of_cell_label.TabIndex = 10;
            border_of_cell_label.Text = "ohraničení buňky";
            // 
            // border_of_cell
            // 
            border_of_cell.Location = new Point(177, 126);
            border_of_cell.Margin = new Padding(2);
            border_of_cell.Name = "border_of_cell";
            border_of_cell.Size = new Size(127, 23);
            border_of_cell.TabIndex = 5;
            // 
            // colour_of_background
            // 
            colour_of_background.Location = new Point(177, 182);
            colour_of_background.Margin = new Padding(2);
            colour_of_background.Name = "colour_of_background";
            colour_of_background.Size = new Size(129, 23);
            colour_of_background.TabIndex = 6;
            // 
            // set_colour_for_background
            // 
            set_colour_for_background.Location = new Point(310, 180);
            set_colour_for_background.Margin = new Padding(2);
            set_colour_for_background.Name = "set_colour_for_background";
            set_colour_for_background.Size = new Size(78, 23);
            set_colour_for_background.TabIndex = 7;
            set_colour_for_background.Text = "Vybrat";
            set_colour_for_background.UseVisualStyleBackColor = true;
            set_colour_for_background.Click += set_colour_for_background_Click;
            // 
            // colour_of_background_label
            // 
            colour_of_background_label.AutoSize = true;
            colour_of_background_label.Location = new Point(31, 184);
            colour_of_background_label.Margin = new Padding(2, 0, 2, 0);
            colour_of_background_label.Name = "colour_of_background_label";
            colour_of_background_label.Size = new Size(139, 15);
            colour_of_background_label.TabIndex = 12;
            colour_of_background_label.Text = "barva pozadí dokumentu";
            // 
            // type_of_row
            // 
            type_of_row.DropDownStyle = ComboBoxStyle.DropDownList;
            type_of_row.FormattingEnabled = true;
            type_of_row.Items.AddRange(new object[] { "hlavička", "liché řádky", "sudé řádky" });
            type_of_row.Location = new Point(484, 4);
            type_of_row.Margin = new Padding(2);
            type_of_row.Name = "type_of_row";
            type_of_row.Size = new Size(129, 23);
            type_of_row.TabIndex = 8;
            type_of_row.SelectedIndexChanged += type_of_row_SelectedIndexChanged;
            // 
            // type_of_row_label
            // 
            type_of_row_label.AutoSize = true;
            type_of_row_label.Location = new Point(418, 7);
            type_of_row_label.Margin = new Padding(2, 0, 2, 0);
            type_of_row_label.Name = "type_of_row_label";
            type_of_row_label.Size = new Size(57, 15);
            type_of_row_label.TabIndex = 16;
            type_of_row_label.Text = "typ řádku";
            // 
            // colour_of_row
            // 
            colour_of_row.Location = new Point(484, 31);
            colour_of_row.Margin = new Padding(2);
            colour_of_row.Name = "colour_of_row";
            colour_of_row.Size = new Size(129, 23);
            colour_of_row.TabIndex = 9;
            colour_of_row.TextChanged += colour_of_row_TextChanged;
            // 
            // set_colour_of_row
            // 
            set_colour_of_row.Location = new Point(615, 30);
            set_colour_of_row.Margin = new Padding(2);
            set_colour_of_row.Name = "set_colour_of_row";
            set_colour_of_row.Size = new Size(78, 24);
            set_colour_of_row.TabIndex = 10;
            set_colour_of_row.Text = "Vybrat";
            set_colour_of_row.UseVisualStyleBackColor = true;
            set_colour_of_row.Click += set_colour_of_row_Click;
            // 
            // colour_of_row_label
            // 
            colour_of_row_label.AutoSize = true;
            colour_of_row_label.Location = new Point(407, 30);
            colour_of_row_label.Margin = new Padding(2, 0, 2, 0);
            colour_of_row_label.Name = "colour_of_row_label";
            colour_of_row_label.Size = new Size(69, 15);
            colour_of_row_label.TabIndex = 19;
            colour_of_row_label.Text = "barva řádku";
            // 
            // save
            // 
            save.Location = new Point(616, 203);
            save.Margin = new Padding(2);
            save.Name = "save";
            save.Size = new Size(78, 23);
            save.TabIndex = 12;
            save.Text = "uložit";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // level_of_text_label
            // 
            level_of_text_label.AutoSize = true;
            level_of_text_label.Location = new Point(95, 6);
            level_of_text_label.Margin = new Padding(2, 0, 2, 0);
            level_of_text_label.Name = "level_of_text_label";
            level_of_text_label.Size = new Size(74, 15);
            level_of_text_label.TabIndex = 1;
            level_of_text_label.Text = "úroveň textu";
            // 
            // levels_of_text
            // 
            levels_of_text.DropDownStyle = ComboBoxStyle.DropDownList;
            levels_of_text.FormattingEnabled = true;
            levels_of_text.Items.AddRange(new object[] { "běžný text", "nadpis", "líché řádky", "sudé řádky", "hlavička tabulky" });
            levels_of_text.Location = new Point(177, 4);
            levels_of_text.Margin = new Padding(2);
            levels_of_text.Name = "levels_of_text";
            levels_of_text.Size = new Size(129, 23);
            levels_of_text.TabIndex = 0;
            levels_of_text.SelectedIndexChanged += levels_of_text_SelectedIndexChanged;
            // 
            // colour_of_border
            // 
            colour_of_border.Location = new Point(177, 153);
            colour_of_border.Margin = new Padding(2);
            colour_of_border.Name = "colour_of_border";
            colour_of_border.Size = new Size(129, 23);
            colour_of_border.TabIndex = 20;
            // 
            // colour_of_border_label
            // 
            colour_of_border_label.AutoSize = true;
            colour_of_border_label.Location = new Point(75, 157);
            colour_of_border_label.Margin = new Padding(2, 0, 2, 0);
            colour_of_border_label.Name = "colour_of_border_label";
            colour_of_border_label.Size = new Size(95, 15);
            colour_of_border_label.TabIndex = 21;
            colour_of_border_label.Text = "barva ohraničení";
            // 
            // set_colour_for_border
            // 
            set_colour_for_border.Location = new Point(310, 153);
            set_colour_for_border.Margin = new Padding(2);
            set_colour_for_border.Name = "set_colour_for_border";
            set_colour_for_border.Size = new Size(78, 23);
            set_colour_for_border.TabIndex = 22;
            set_colour_for_border.Text = "Vybrat";
            set_colour_for_border.UseVisualStyleBackColor = true;
            set_colour_for_border.Click += set_colour_for_border_Click;
            // 
            // width_label
            // 
            width_label.AutoSize = true;
            width_label.Location = new Point(446, 61);
            width_label.Margin = new Padding(2, 0, 2, 0);
            width_label.Name = "width_label";
            width_label.Size = new Size(31, 15);
            width_label.TabIndex = 25;
            width_label.Text = "šířka";
            width_label.Visible = false;
            // 
            // height_label
            // 
            height_label.AutoSize = true;
            height_label.Location = new Point(440, 88);
            height_label.Margin = new Padding(2, 0, 2, 0);
            height_label.Name = "height_label";
            height_label.Size = new Size(36, 15);
            height_label.TabIndex = 26;
            height_label.Text = "výška";
            height_label.Visible = false;
            // 
            // width_page
            // 
            width_page.DecimalPlaces = 2;
            width_page.Location = new Point(484, 60);
            width_page.Margin = new Padding(2);
            width_page.Maximum = new decimal(new int[] { -1, -1, -1, 0 });
            width_page.Name = "width_page";
            width_page.Size = new Size(128, 23);
            width_page.TabIndex = 27;
            width_page.Visible = false;
            // 
            // height_page
            // 
            height_page.DecimalPlaces = 2;
            height_page.Location = new Point(484, 87);
            height_page.Margin = new Padding(2);
            height_page.Maximum = new decimal(new int[] { -1, -1, -1, 0 });
            height_page.Name = "height_page";
            height_page.Size = new Size(128, 23);
            height_page.TabIndex = 28;
            height_page.Visible = false;
            // 
            // units
            // 
            units.DropDownStyle = ComboBoxStyle.DropDownList;
            units.FormattingEnabled = true;
            units.Items.AddRange(new object[] { "cm", "mm", "in" });
            units.Location = new Point(616, 59);
            units.Margin = new Padding(2);
            units.Name = "units";
            units.Size = new Size(77, 23);
            units.TabIndex = 31;
            units.Visible = false;
            // 
            // Styles_for_html
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 233);
            Controls.Add(units);
            Controls.Add(height_page);
            Controls.Add(width_page);
            Controls.Add(height_label);
            Controls.Add(width_label);
            Controls.Add(set_colour_for_border);
            Controls.Add(colour_of_border_label);
            Controls.Add(colour_of_border);
            Controls.Add(save);
            Controls.Add(colour_of_row_label);
            Controls.Add(colour_of_row);
            Controls.Add(set_colour_of_row);
            Controls.Add(type_of_row_label);
            Controls.Add(type_of_row);
            Controls.Add(colour_of_background);
            Controls.Add(set_colour_for_background);
            Controls.Add(colour_of_background_label);
            Controls.Add(border_of_cell);
            Controls.Add(border_of_cell_label);
            Controls.Add(size_of_font_label);
            Controls.Add(size_of_font);
            Controls.Add(colour_of_text);
            Controls.Add(set_colour);
            Controls.Add(colour_of_text_label);
            Controls.Add(font_label);
            Controls.Add(differentiate_even_rows);
            Controls.Add(levels_of_text);
            Controls.Add(level_of_text_label);
            Controls.Add(list_of_fonts);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Styles_for_html";
            Text = "Stylopis pro HTML soubory";
            ((System.ComponentModel.ISupportInitialize)size_of_font).EndInit();
            ((System.ComponentModel.ISupportInitialize)border_of_cell).EndInit();
            ((System.ComponentModel.ISupportInitialize)width_page).EndInit();
            ((System.ComponentModel.ISupportInitialize)height_page).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox list_of_fonts;
        private CheckBox differentiate_even_rows;
        private Label font_label;
        private Label colour_of_text_label;
        private Button set_colour;
        private TextBox colour_of_text;
        private NumericUpDown size_of_font;
        private Label size_of_font_label;
        private Label border_of_cell_label;
        private NumericUpDown border_of_cell;
        private TextBox colour_of_background;
        private Button set_colour_for_background;
        private Label colour_of_background_label;
        private ComboBox type_of_row;
        private Label type_of_row_label;
        private TextBox colour_of_row;
        private Button set_colour_of_row;
        private Label colour_of_row_label;
        private Button save;
        private Label level_of_text_label;
        private ComboBox levels_of_text;
        private TextBox colour_of_border;
        private Label colour_of_border_label;
        private Button set_colour_for_border;
        private Label width_label;
        private Label height_label;
        private NumericUpDown width_page;
        private NumericUpDown height_page;
        private ComboBox units;
    }
}