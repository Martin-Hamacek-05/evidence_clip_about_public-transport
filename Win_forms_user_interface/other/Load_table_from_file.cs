using DocumentFormat.OpenXml.Office2010.CustomUI;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using evidence_clip_about_public_transport.DAO;
using evidence_clip_about_public_transport.File_manager;
using evidence_clip_about_public_transport.Other_classes;
using evidence_clip_about_public_transport.Other_classes.Import_clips;
using ScottPlot.Palettes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace evidence_clip_about_public_transport.Win_forms_user_interface.other
{
    public partial class Load_table_from_file : Form
    {
        private File_manager_switch file_Manager = new File_manager_switch();

        private static string filter =
            "sešit MS Excel 2007 a výše *.xlsx|*.xlsx|" +
            "textový soubor s oddělovači *.csv|*.csv";

        private static bool enabled_filter = false;

        private static string path;

        public Load_table_from_file()
        {
            string date_time_picket_format = "dddd dd. MMMM yyyy HH:mm:ss";
            InitializeComponent();
            from_.CustomFormat = date_time_picket_format;
            to_.CustomFormat = date_time_picket_format;


            I_File_type i_File_Type = file_Manager.selected_type(Int32.Parse(Load_info_from_file.read_info_from()[0]));

            for (int i = 0; i < i_File_Type.list_of_directories(Load_info_from_file.read_info_from()[1]).Count; i++)
            {
                if (i_File_Type.list_of_directories(Load_info_from_file.read_info_from()[1])[i] != null)
                {
                    file_url.Items.Add(i_File_Type.list_of_directories(Load_info_from_file.read_info_from()[1])[i]);
                }
            }

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

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                path = folderBrowserDialog.SelectedPath;
                fill_list_of_file(loaded_files, path, false, new DateTime(), new DateTime());
            }
        }

        private void load_with_filter_Click(object sender, EventArgs e)
        {
            if (enable_filter.Checked) 
            {
                fill_list_of_file(loaded_files, path, true, from_.Value, to_.Value);

                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = load_file.DataSource;

                DateOnly from_date = DateOnly.FromDateTime(from_.Value);
                DateOnly to_date = DateOnly.FromDateTime(to_.Value);

                bindingSource.Filter = string.Format("datum >=#{0:yyyy-MM-dd}# and datum <= #{1:yyyy-MM-dd}#", from_date, to_date);

                load_file.DataSource = bindingSource;
                load_file.Update();
            }
        }


        private void enable_filter_CheckedChanged(object sender, EventArgs e)
        {
            if (enabled_filter == false)
            {
                from_.Enabled = true;
                to_.Enabled = true;
            }
            else
            {
                from_.Enabled = false;
                to_.Enabled = false;
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            I_DAO_Clip new_clip = Database_server_switch.dAO_Clips();

            List<Import_clip_object>to_upload = new List<Import_clip_object>();

            int count_of_column = 0;
            foreach (DataGridViewRow row in load_file.Rows)
            {
                Import_clip_object import_Clip_Object = new Import_clip_object();
                import_Clip_Object.File_path = file_url.Text;
                for (int i = 0; i < load_file.Columns.Count; i++)
                {
                    count_of_column++;  
                    if (count_of_column == 7)
                    {
                        string list_of_vehicles = row.Cells[i].Value?.ToString().Trim();
                        if (list_of_vehicles != null) 
                        {
                            string[] vehicles = list_of_vehicles.Split('+');
                            List<string> vehicls = new List<string>(vehicles);
                            import_Clip_Object.Vehicles = vehicls;
                        }
                    }
                    else 
                    {
                        Import_clip_object.set_propeties_to_object(import_Clip_Object, count_of_column, row.Cells[i].Value?.ToString());
                    }
                }
                to_upload.Add(import_Clip_Object);
                count_of_column = 0;
            }

            List<Import_clip_object> final_to_upload = new List<Import_clip_object>();
            int count_of_row = 0;
            foreach (DataGridViewRow row in loaded_files.Rows)
            {
                Import_clip_object import_Clip_Object = new Import_clip_object();
                int count_of_column_ = 0;
                for (int i = 0; i < loaded_files.Columns.Count; i++)
                {
                    if (count_of_column_ == 0) 
                    {
                        import_Clip_Object = to_upload[count_of_row];
                        import_Clip_Object.Name_of_clip = row.Cells[i].Value?.ToString();
                        
                    }
                    count_of_column_++;
                }
                final_to_upload.Add(import_Clip_Object);
                count_of_row++;
                import_Clip_Object = null;
            }
            to_upload.Clear();
            to_upload = null;

            /*for (int i = 0; i < final_to_upload.Count; i++) 
            {
                MessageBox.Show(final_to_upload[i].ToString());
            }*/

            MessageBox.Show(new_clip.load_record_from_file(final_to_upload));
            I_File_type i_File_Type = file_Manager.selected_type(Int32.Parse(Load_info_from_file.read_info_from()[0]));

            foreach (DataGridViewRow row in loaded_files.Rows)
            {
                MessageBox.Show(i_File_Type.record_file(row.Cells[0].Value?.ToString(), path, Load_info_from_file.read_info_from()[1] + "\\" + file_url.Text));

            }
        }

        private static void fill_list_of_file(DataGridView data, string path, bool enable_fiter, DateTime from, DateTime to)
        {
            DataTable dt = new DataTable();
            DirectoryInfo d = new DirectoryInfo(path);
            FileInfo[] Files = d.GetFiles("*.*");
            DataRow dr = dt.NewRow();

            dt.Columns.Add("soubory");
            dt.Columns.Add("datum");

            data.DataSource = dt;

            if (enable_fiter)
            {
                var filtered = Files.Where(f => !f.Attributes.HasFlag(FileAttributes.Hidden) && f.CreationTime.Date >= from.AddDays(-1) && f.CreationTime.Date <= to);

                foreach (FileInfo file in filtered)
                {
                    object[] list = { file.Name, file.CreationTime };
                    dt.Rows.Add(list);
                }
            }
            else
            {
                var filtered = Files.Where(f => !f.Attributes.HasFlag(FileAttributes.Hidden)/* && f.CreationTime.Date >= from_.Value && f.CreationTime.Date <= to_.Value*/);

                foreach (FileInfo file in filtered)
                {
                    object[] list = { file.Name, file.CreationTime };
                    dt.Rows.Add(list);
                }
            }
        }
    }
}
