namespace evidence_clip_about_public_transport.Win_forms_user_interface.for_lines
{
    partial class Generate_sequence
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
            from_label = new Label();
            to_label = new Label();
            distance_label = new Label();
            from_ = new NumericUpDown();
            to = new NumericUpDown();
            distance = new NumericUpDown();
            generate = new Button();
            check = new Button();
            ((System.ComponentModel.ISupportInitialize)from_).BeginInit();
            ((System.ComponentModel.ISupportInitialize)to).BeginInit();
            ((System.ComponentModel.ISupportInitialize)distance).BeginInit();
            SuspendLayout();
            // 
            // from_label
            // 
            from_label.AutoSize = true;
            from_label.Location = new Point(23, 9);
            from_label.Name = "from_label";
            from_label.Size = new Size(21, 15);
            from_label.TabIndex = 0;
            from_label.Text = "od";
            // 
            // to_label
            // 
            to_label.AutoSize = true;
            to_label.Location = new Point(23, 41);
            to_label.Name = "to_label";
            to_label.Size = new Size(21, 15);
            to_label.TabIndex = 1;
            to_label.Text = "do";
            // 
            // distance_label
            // 
            distance_label.AutoSize = true;
            distance_label.Location = new Point(13, 70);
            distance_label.Name = "distance_label";
            distance_label.Size = new Size(31, 15);
            distance_label.TabIndex = 2;
            distance_label.Text = "skok";
            // 
            // from_
            // 
            from_.Location = new Point(50, 7);
            from_.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            from_.Minimum = new decimal(new int[] { 999999, 0, 0, int.MinValue });
            from_.Name = "from_";
            from_.Size = new Size(120, 23);
            from_.TabIndex = 3;
            from_.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // to
            // 
            to.Location = new Point(50, 39);
            to.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            to.Minimum = new decimal(new int[] { 1000000, 0, 0, int.MinValue });
            to.Name = "to";
            to.Size = new Size(120, 23);
            to.TabIndex = 4;
            to.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // distance
            // 
            distance.Location = new Point(50, 68);
            distance.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            distance.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            distance.Name = "distance";
            distance.Size = new Size(120, 23);
            distance.TabIndex = 5;
            distance.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // generate
            // 
            generate.Location = new Point(113, 111);
            generate.Name = "generate";
            generate.Size = new Size(75, 23);
            generate.TabIndex = 7;
            generate.Text = "Vytvořit řadu";
            generate.UseVisualStyleBackColor = true;
            generate.Click += generate_Click;
            // 
            // check
            // 
            check.Location = new Point(13, 111);
            check.Name = "check";
            check.Size = new Size(94, 23);
            check.TabIndex = 6;
            check.Text = "Zkontrolovat";
            check.UseVisualStyleBackColor = true;
            check.Click += check_Click;
            // 
            // Generate_sequence
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(207, 140);
            Controls.Add(check);
            Controls.Add(generate);
            Controls.Add(distance);
            Controls.Add(to);
            Controls.Add(from_);
            Controls.Add(distance_label);
            Controls.Add(to_label);
            Controls.Add(from_label);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Generate_sequence";
            ShowIcon = false;
            Text = "Generovat řad";
            ((System.ComponentModel.ISupportInitialize)from_).EndInit();
            ((System.ComponentModel.ISupportInitialize)to).EndInit();
            ((System.ComponentModel.ISupportInitialize)distance).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label from_label;
        private Label to_label;
        private Label distance_label;
        private NumericUpDown from_;
        private NumericUpDown to;
        private NumericUpDown distance;
        private Button generate;
        private Button check;
    }
}