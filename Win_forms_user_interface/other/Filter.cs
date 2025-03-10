using evidence_clip_about_public_transport.DAO;
using evidence_clip_about_public_transport.DAO.mysql.for_clip;
using evidence_clip_about_public_transport.DAO.mysql.other_features;
using evidence_clip_about_public_transport.File_manager;
using evidence_clip_about_public_transport.Other_classes;
using evidence_clip_about_public_transport.Win_forms_user_interface.for_lines;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
/* author Martin Hamacek, C4c, 2024/2025*/
namespace evidence_clip_about_public_transport.Win_forms_user_interface.other
{
    public partial class Filter : Form
    {

        private File_manager_switch file_Manager = new File_manager_switch();


        private static I_Other_database_features other_Database_Features = Database_server_switch.other_Database_Features();
        private List<CheckedListBox> all_parameters = other_Database_Features.parameters_for_filter();

        private string[] headers_in_czech = { "název klipu", "vytvořeno", "číslo natáčecího dne","", "příjezd / odjezd", "název linky", "název zastávky", "nástupiště", "směr", "evidenční čísla vozidel", "podtyp", "dopravní prostředek", "výrobce", "dopravce", "formát" };

        private bool search_by_number_ = false;
        public Filter()
        {
            InitializeComponent();

            string[] labels_on_tab = {"formáty", "linky", "dopravci", "zastávky", "podtypy dopravních prostředků" };
            for (int i = 0; i < all_parameters.Count; i++)
            {
                TabPage tabPage = new TabPage();
                tabPage.Text = labels_on_tab[i];

                tab_with_column_to_filter.Controls.Add(tabPage);
                tabPage.Controls.Add(all_parameters[i]);
            }

            data_from_select.ReadOnly = true;
            count_of_files_in_label.Visible = false;
            copy_of_files_label.Visible = false;
        }

        private void new_record_Click(object sender, EventArgs e)
        {
            Edit_line new_line = new Edit_line();
            new_line.Show();
        }
        private void load_button_Click(object sender, EventArgs e)
        {
            try
            {
                List<List<string>> for_filter = new List<List<string>>();
                string[] column_english = {"format_", "name_line", "owner_name", "name_of_stop", "subtype_mean_of_transport" };
                List<string> column_for_filter = new List<string>();

                for (int j = 0; j < column_english.Length; j++)
                {
                    List<string> author = new List<string>();

                    if (all_parameters[j].CheckedItems.Count > 0)
                    {
                        for (int i = 0; i < all_parameters[j].CheckedItems.Count; i++)
                        {
                            author.Add(all_parameters[j].CheckedItems[i].ToString());
                        }
                        column_for_filter.Add(column_english[j]);
                        for_filter.Add(author);

                    }
                }

                //MessageBox.Show(all_parameters[1].CheckedItems[0].ToString());
                I_DAO_Clip load = Database_server_switch.dAO_Clips();
                data_from_select.Visible = false;
                data_from_select.DataSource = load.get_all_clip_for_filter().Tables[0];
                data_from_select.Columns[0].Visible = false;
                data_from_select.Columns[4].Visible = false;

                data_from_select.Update();

                BindingSource bs = new BindingSource();
                bs.DataSource = data_from_select.DataSource;

                if (for_filter.Count() == 0)
                {
                    bs.Filter = string.Format("created >='{0:yyyy-MM-dd}' and created <= '{1:yyyy-MM-dd}'", from_.Value, to_.Value);
                }
                else
                {
                    bs.Filter = string.Format(Filter_function.filter_from_clip(for_filter, column_for_filter) + " and created >='{0:yyyy-MM-dd}' and created <= '{1:yyyy-MM-dd}'", from_.Value, to_.Value);
                }

                data_from_select.DataSource = bs;
                data_from_select.Update();
                for (int i = 0; i < headers_in_czech.Length; i++)
                {
                    data_from_select.Columns[i + 1].HeaderText = headers_in_czech[i];
                }

                data_from_select.Visible = true;
                status_label.Text = "OK | Počet nalezených záznamů: " + data_from_select.Rows.Count.ToString();
            }
            catch (FormatException exc)
            {
                MessageBox.Show("Datum, které bylo načteno není validní");
            }
            catch (Exception ex)
            {

            }
        }
        private void data_from_select_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*DAO_Line_implement load = new DAO_Line_implement();
            Edit_line edit = new Edit_line();

            int selected = e.RowIndex;
            if (selected != -1)
            {
                DataGridViewRow selected_row = data_from_select.Rows[selected];
                edit.set_line_for_edit(load.get_line(Convert.ToInt32(selected_row.Cells[0].Value)));
                edit.Show();
            }*/
            //MessageBox.Show(FindByTag(checkedListBox, "1").ToString());

        }
        private void save_as_button_on_top_menu_trip_Click(object sender, EventArgs e)
        {
            try
            {
                data_from_select.Columns[4].Visible = false;
                evidence_clip_about_public_transport.Other_classes.File_manager.export_data_to_other_format(data_from_select, header.Text,3);
            }
            catch (Exception exc) 
            { 
            
            }
        }
        private void search_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (search_by_number_ == false)
                {
                    data_from_select.Columns[1].HeaderText = "name_of_clip";

                    BindingSource bs = new BindingSource();
                    bs.DataSource = data_from_select.DataSource;
                    bs.Filter = data_from_select.Columns[1].HeaderText.ToString() + " LIKE '%" + search_textbox.Text + "%'";
                    //bs.Filter = string.Format("created >= '{0}' AND created <= '{1}' and name_line='12' or name_line='5'", "2024-01-02","2024-01-31");
                    data_from_select.DataSource = bs;

                    data_from_select.Columns[1].HeaderText = headers_in_czech[0];
                }
                else
                {
                    data_from_select.Columns[10].HeaderText = "number_of_vehicle"; 

                    BindingSource bs = new BindingSource();
                    bs.DataSource = data_from_select.DataSource;
                    bs.Filter = data_from_select.Columns[10].HeaderText.ToString() + " LIKE '%" + search_textbox.Text + "%'";
                    //bs.Filter = string.Format("created >= '{0}' AND created <= '{1}' and name_line='12' or name_line='5'", "2024-01-02","2024-01-31");
                    data_from_select.DataSource = bs;

                    data_from_select.Columns[10].HeaderText = headers_in_czech[10];
                }

                for (int i = 0; i < headers_in_czech.Length; i++)
                {
                    data_from_select.Columns[i + 1].HeaderText = headers_in_czech[i];
                }

                status_label.Text = "OK | Počet nalezených záznamů: " + data_from_select.Rows.Count.ToString();
                

            }
            catch (ArgumentException)
            {
                MessageBox.Show("Nelze nic vyhledat, protože nejsou načtená data");
            }
            catch (Exception exc)
            {
                MessageBox.Show("Došlo k neočekavané chybě: \n" + exc.Message);
            }
        }

        private void search_with_label_Click(object sender, EventArgs e)
        {
            if (search_by_number_ == false)
            {
                search_with_label.Text = "Vyhledat podle evidečního čísla";
                search_by_number_ = true;
            }
            else
            {
                search_with_label.Text = "Vyhledat podle označení";
                search_by_number_ = false;
            }
        }

        private void copy_file_button_Click(object sender, EventArgs e)
        {
            count_of_files_in_label.Visible = true;
            copy_of_files_label.Visible = true;

            FolderBrowserDialog where_file_is = new FolderBrowserDialog();
            where_file_is.ShowDialog();

            int count_of_file = 0;
            try
            {
                foreach (DataGridViewRow row in data_from_select.Rows)
                {
                    count_of_file++;
                    data_from_select.Columns[1].HeaderText = "name_of_clip";
                    data_from_select.Columns[4].HeaderText = "file_url";

                    count_of_files_in_label.Text = count_of_file.ToString();

                    I_File_type i_File_Type = file_Manager.selected_type(Int32.Parse(Load_info_from_file.read_info_from()[0]));


                    MessageBox.Show(i_File_Type.copy_file_from_one_location_to_another(Load_info_from_file.read_info_from()[1] + row.Cells[4].Value.ToString() + "\\", row.Cells[1].Value.ToString(), where_file_is.SelectedPath, "_" + count_of_file.ToString()));


                    data_from_select.Columns[1].HeaderText = headers_in_czech[0];

                    count_of_files_in_label.Visible = false;

                    copy_of_files_label.Text = "Hotovo";

                }
            }
            catch (System.IO.FileFormatException file_not_fount)
            {

                count_of_files_in_label.Visible = false;
                MessageBox.Show("Soubor nenalezen", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                copy_of_files_label.Text = "nic";
            }

            catch (System.IO.DriveNotFoundException file_not_fount)
            {

                count_of_files_in_label.Visible = false;
                MessageBox.Show("Zadaný disk není nalezen", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                copy_of_files_label.Text = "nic";
            }
            catch (System.IO.DirectoryNotFoundException file_not_fount)
            {

                count_of_files_in_label.Visible = false;
                MessageBox.Show("Zadaná cesta nebo adresář není k dispozici", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                copy_of_files_label.Text = "nic";
            }
            catch (Exception exc)
            {
                count_of_files_in_label.Visible = false;
                MessageBox.Show("Došlo k neočekavané chybě:\n" + exc.ToString(), "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                copy_of_files_label.Text = "nic";
            }
            }
        }
        
}