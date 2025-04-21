using evidence_clip_about_public_transport.Database_connection;
using evidence_clip_about_public_transport.File_manager;
using evidence_clip_about_public_transport.Other_classes;
using MySql.Data.MySqlClient;
using ScottPlot.TickGenerators.TimeUnits;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace evidence_clip_about_public_transport.Win_forms_user_interface.other
{
    public partial class SQLQuerry : Form
    {

        private File_manager_switch file_Manager = new File_manager_switch();
        private int selected_index = 0;
        public SQLQuerry()
        {
            InitializeComponent();
        }

        private void querryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var regex = @"^.*drop .*$|^.*create .*$|^.*alter .*$|^.*DROP .*$|^.*CREATE .*$|^.*ALTER .*$";

                var regexII = @"^.*author .*$";

                var match = Regex.Match(querry_input.Text, regex);
                var matchII = Regex.Match(querry_input.Text, regexII);

                if (match.Success)
                {
                    throw new ArgumentException("SQL injection");
                }

                if (matchII.Success)
                {
                    throw new UnauthorizedAccessException("provádět dotazy nad tabulkou author je zakazáno. ");
                }

                MySqlDataAdapter adapter = new MySqlDataAdapter(querry_input.Text, Database_connect.myssql_connection());
                DataSet dataSet_of_clip = new DataSet();
                adapter.Fill(dataSet_of_clip);
                data_from_select.DataSource = dataSet_of_clip.Tables[0];
                data_from_select.Update();

                if ((data_from_select.Columns.Contains("file_url") == true) && (data_from_select.Columns.Contains("name_of_clip") == true))
                {
                    copy_filesToolStripMenuItem.Enabled = true;
                    show_clipToolStripMenuItem.Enabled = true;
                }
                else
                {
                    copy_filesToolStripMenuItem.Enabled = false;
                    show_clipToolStripMenuItem.Enabled = false;
                }

                status_label.Text = "OK | Počet nalezených záznamů: " + data_from_select.Rows.Count.ToString();
            }
            catch (IndexOutOfRangeException exc)
            {
                MessageBox.Show("byl proveden dotaz, který neobsahuje select");
                status_label.Text = "OK | Počet nalezených záznamů: 0";
            }

            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                status_label.Text = exc.Message;
            }
        }

        private void save_as_button_on_top_menu_trip_Click(object sender, EventArgs e)
        {
            evidence_clip_about_public_transport.Other_classes.File_manager.export_data_to_other_format(data_from_select, header.Text, string.Empty);
        }

        private void copy_filesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog where_file_is = new FolderBrowserDialog();
            where_file_is.ShowDialog();

            int count_of_file = 0;
            try
            {
                foreach (DataGridViewRow row in data_from_select.Rows)
                {
                    count_of_file++;
                    I_File_type i_File_Type = file_Manager.selected_type(Int32.Parse(Load_info_from_file.read_info_from()[0]));

                    i_File_Type.copy_file_from_one_location_to_another(Load_info_from_file.read_info_from()[1] + row.Cells["file_url"].Value.ToString() + "\\", row.Cells["name_of_clip"].Value.ToString(), where_file_is.SelectedPath, "_" + count_of_file.ToString());
                }
                MessageBox.Show("Hotovo");
            }
            catch (System.IO.FileFormatException file_not_fount)
            {
                MessageBox.Show("Soubor nenalezen", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            catch (System.IO.DriveNotFoundException file_not_fount)
            {
                MessageBox.Show("Zadaný disk není nalezen", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (System.IO.DirectoryNotFoundException file_not_fount)
            {
                MessageBox.Show("Zadaná cesta nebo adresář není k dispozici", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception exc)
            {
                MessageBox.Show("Došlo k neočekavané chybě:\n" + exc.ToString(), "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void show_clipToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (selected_index != -1)
            {

                DataGridViewRow selected_row = data_from_select.Rows[selected_index];

                I_File_type i_File_Type = file_Manager.selected_type(Int32.Parse(Load_info_from_file.read_info_from()[0]));
                MessageBox.Show(i_File_Type.load_file(selected_row.Cells["name_of_clip"].Value?.ToString(), Load_info_from_file.read_info_from()[1] + "\\" + selected_row.Cells["file_url"].Value?.ToString()));

            }


        }


        private void data_from_select_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selected_index = e.RowIndex;
        }
    }
}
