using DocumentFormat.OpenXml.Office2010.CustomUI;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using evidence_clip_about_public_transport.Other_classes.Import_clips;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace evidence_clip_about_public_transport.Win_forms_user_interface.other
{
    public partial class Load_table_from_file : Form
    {
        private static string filter =
            "sešit MS Excel 2007 a výše *.xlsx|*.xlsx|" +
            "textový soubor s oddělovači *.csv|*.csv";
        public Load_table_from_file()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void select_file_Click(object sender, EventArgs e)
        {
            OpenFileDialog saveFileDialog = new OpenFileDialog();
            saveFileDialog.Filter = filter;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Switch_import_clip switch_Import_Clip = new Switch_import_clip();
                load_file.DataSource = switch_Import_Clip.selected_clip(saveFileDialog.FilterIndex).load(Path.GetFullPath(saveFileDialog.FileName));
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void load_file_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void load_file_MouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void select_source_of_file_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowDialog();

            DataTable dt = new DataTable();

            DirectoryInfo d = new DirectoryInfo(folderBrowserDialog.SelectedPath);

            FileInfo[] Files = d.GetFiles("*.*");

            DataRow dr = dt.NewRow();
            dt.Columns.Add("výpis adresářů");

            loaded_files.DataSource = dt;

            var filtered = Files.Where(f => !f.Attributes.HasFlag(FileAttributes.Hidden));

            foreach (FileInfo file in filtered)
            {
                dt.Rows.Add(file.Name);
            }
        }
    }
}
