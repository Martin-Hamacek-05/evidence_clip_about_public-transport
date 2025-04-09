using evidence_clip_about_public_transport.Database_connection;
using evidence_clip_about_public_transport.Entits;
using evidence_clip_about_public_transport.Win_forms_user_interface;
using evidence_clip_about_public_transport.Win_forms_user_interface.for_clip;
using evidence_clip_about_public_transport.Win_forms_user_interface.for_formats;
using evidence_clip_about_public_transport.Win_forms_user_interface.for_lines;
using evidence_clip_about_public_transport.Win_forms_user_interface.for_stops;
using evidence_clip_about_public_transport.Win_forms_user_interface.for_vehicle;
using evidence_clip_about_public_transport.Win_forms_user_interface.other;
using evidence_clip_about_public_transport.Chart_manager;
using MySql.Data.MySqlClient;
using ScottPlot.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using evidence_clip_about_public_transport.Other_classes.Backup_class;
using evidence_clip_about_public_transport.DAO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using evidence_clip_about_public_transport.Win_forms_user_interface.Author;
using evidence_clip_about_public_transport.Win_forms_user_interface.for_author;
using evidence_clip_about_public_transport.Win_forms_user_interface.ftp_manager;
using evidence_clip_about_public_transport.DAO.mysql.other_features;
/* author Martin Hamacek, C4c, 2024/2025*/
namespace evidence_clip_about_public_transport
{
    public partial class Show_clips : Form, I_List_from_table
    {
        private readonly string[] headers_in_czech = { "název klipu", "pořízeno", "číslo natáčecího dne", "příjezd / odjezd", "linka", "zastávka", "nástupiště", "směr", "evidenční čísla vozidel", "formát" };

        private bool search_by_number_ = false;
        public Show_clips()
        {
            try
            {
                InitializeComponent();
                I_List_to_combobox list_To_Combobox = Database_server_switch.list_to_combobox();
                list_To_Combobox.yers_to_combobox("select distinct YEAR(created) as years from clip order by years desc", from_year_combo_box);
                from_year_combo_box.SelectedIndex = 0;
                data_from_select.ReadOnly = true;
            }
            catch (ArgumentOutOfRangeException exc)
            {
                MessageBox.Show("Výběr letepočtů je prázdný ");
            }
        }
        private void new_record_Click(object sender, EventArgs e)
        {
            Edit_clip new_clip = new Edit_clip();
            new_clip.set_column();
            new_clip.Show();
        }
        private void load_button_Click(object sender, EventArgs e)
        {
            try
            {
                I_DAO_Clip dAO_Clip_Implement = Database_server_switch.dAO_Clips();
                data_from_select.DataSource = dAO_Clip_Implement.get_all_clip_from_year(Int32.Parse(from_year_combo_box.Text)).Tables[0];
                data_from_select.Columns[0].Visible = false;
                for (int i = 0; i < headers_in_czech.Length; i++)
                {
                    data_from_select.Columns[i + 1].HeaderText = headers_in_czech[i];
                }

                foreach (DataGridViewRow row in data_from_select.Rows)
                {
                    if (row.Cells[9].Value.GetType().ToString().Equals("System.DBNull"))
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                    }
                }

                data_from_select.Update();

                status_label.Text = "OK | Počet nalezených záznamů: " + data_from_select.Rows.Count.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("výběr letopočtu je prázdný");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo k neočekavané chybě: \n" + ex.Message);
            }
        }
        private void data_from_select_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            I_DAO_Clip load = Database_server_switch.dAO_Clips();
            Edit_clip edit = new Edit_clip();

            int selected = e.RowIndex;
            if (selected != -1)
            {

                DataGridViewRow selected_row = data_from_select.Rows[selected];


                edit.set_selected_clip(load.get_clip(Convert.ToInt32(selected_row.Cells[0].Value)));
                edit.Show();
            }
        }

        private void save_as_button_on_top_menu_trip_Click(object sender, EventArgs e)
        {
            evidence_clip_about_public_transport.Other_classes.File_manager.export_data_to_other_format(data_from_select, header.Text);
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
                    bs.Filter = data_from_select.Columns[1].HeaderText.ToString() + " LIKE '%" + search_clip_textbox.Text + "%'";
                    //bs.Filter = string.Format("created >= '{0}' AND created <= '{1}' and name_line='12' or name_line='5'", "2024-01-02","2024-01-31");
                    data_from_select.Columns[1].HeaderText = headers_in_czech[0];
                    data_from_select.DataSource = bs;
                    status_label.Text = "OK | Počet nalezených záznamů: " + data_from_select.Rows.Count.ToString();
                }
                else
                {
                    BindingSource bs = new BindingSource();
                    bs.DataSource = data_from_select.DataSource;
                    data_from_select.Columns[9].HeaderText = "number_of_vehicle";
                    bs.Filter = data_from_select.Columns[9].HeaderText.ToString() + " LIKE '%" + search_clip_textbox.Text + "%'";
                    //bs.Filter = string.Format("created >= '{0}' AND created <= '{1}' and name_line='12' or name_line='5'", "2024-01-02","2024-01-31");
                    data_from_select.Columns[9].HeaderText = headers_in_czech[8];
                    data_from_select.DataSource = bs;
                    status_label.Text = "OK | Počet nalezených záznamů: " + data_from_select.Rows.Count.ToString();
                }
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
        private void filtr_button_on_top_menu_trip_Click(object sender, EventArgs e)
        {
            Filter filter = new Filter();
            filter.Show();
        }

        private void search_with_clip_name_label_Click(object sender, EventArgs e)
        {

            if (search_by_number_ == false)
            {
                search_with_clip_name_label.Text = "Vyhledat podle evidečního čísla";
                search_by_number_ = true;
            }
            else
            {
                search_with_clip_name_label.Text = "Vyhledat podle označení";
                search_by_number_ = false;
            }
        }
        private void exportdata_button_on_top_menu_trip_Click(object sender, EventArgs e)
        {

        }

        private void style_of_document_button_on_top_menu_trip_Click(object sender, EventArgs e)
        {
            Styles_for_html styles_For_Html = new Styles_for_html();
            styles_For_Html.Show();
        }

        private void about_software_ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void Show_clips_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this.Dispose();
        }

        private void edit_author_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show_author show_Author = new Show_author();
            show_Author.Show();
        }
        private void fTPManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ftp_manager ftp_Manager = new Ftp_manager();
            ftp_Manager.Show();
        }

        private void load_data_Click(object sender, EventArgs e)
        {
            Load_table_from_file load_Table_From_File = new Load_table_from_file();
            load_Table_From_File.Show();
        }

    }
}