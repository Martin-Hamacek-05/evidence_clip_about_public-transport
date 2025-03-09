using evidence_clip_about_public_transport.Chart_manager.Chart_switch;
using evidence_clip_about_public_transport.DAO;
using evidence_clip_about_public_transport.DAO.mysql.other_features;
using evidence_clip_about_public_transport.Database_connection;
using evidence_clip_about_public_transport.Other_classes;
using evidence_clip_about_public_transport.Win_forms_user_interface.for_lines;
using ScottPlot.WinForms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
/* author Martin Hamacek, C4c, 2024/2025*/
namespace evidence_clip_about_public_transport.Win_forms_user_interface.other
{
    public partial class Statistics : Form
    {
        private int statistic_id = 0;
        private FormsPlot FormsPlot1 = new FormsPlot();
        private static I_Other_database_features Other_database_features = Database_server_switch.other_Database_Features();
        public Statistics(int index)
        {
            InitializeComponent();
            data_from_select.ReadOnly = true;
            splitcontainer.Panel2Collapsed = true;
            type_chart.SelectedIndex = 0;
            splitcontainer.Panel2.Controls.Add(FormsPlot1);
            splitcontainer.Panel2.Enabled = false;
            statistic_id = index;
            years_combobox.Items.Add("---vyberte---");
            years_combobox.SelectedIndex = 0;
            I_List_to_combobox list_To_Combobox = Database_server_switch.list_to_combobox();
            list_To_Combobox.yers_to_combobox("select distinct year(created) as years from clip order by years desc", years_combobox);
        }

        private List<CheckedListBox> all_parameters = Other_database_features.parameters_for_filter();

        private Chart_list chart_List = new Chart_list();

        private void new_record_Click(object sender, EventArgs e)
        {
            Edit_line new_line = new Edit_line();
            new_line.Show();
        }
        private void load_button_Click(object sender, EventArgs e)
        {
            try
            {
                string[] data = Other_features.set_header_in_czech(statistic_id);
                data_from_select.DataSource = null;

                data_from_select.Visible = false;
                data_from_select.DataSource = Other_database_features.load_stored_procedure(Other_features.procedure_convertor(statistic_id), years_combobox.ComboBox.SelectedItem.ToString()).Tables[0];

                for (int i = 0; i < Other_features.set_header_in_czech(statistic_id).Length; i++)
                {
                    data_from_select.Columns[i].HeaderText = Other_features.set_header_in_czech(statistic_id)[i];
                }

                data_from_select.Update();

                data_from_select.Visible = true;
                splitcontainer.Panel2Collapsed = false;
            
                chart_List.set_chart(type_chart.SelectedIndex, FormsPlot1, data_from_select, Other_features.name_of_statistics(statistic_id));
                status_label.Text = "OK | Počet nalezených záznamů: " + data_from_select.Rows.Count.ToString();

            }
            catch (FormatException exc)
            {
                MessageBox.Show("Data ve statistice nejsou validní");
            }
            catch (ArgumentOutOfRangeException exc) 
            {
                MessageBox.Show("Data ve statistice nejsou validní");
            }
            catch (Exception exce)
            {
                MessageBox.Show(exce.ToString());
            }
        }
        private void data_from_select_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void save_as_button_on_top_menu_trip_Click(object sender, EventArgs e)
        {
            evidence_clip_about_public_transport.Other_classes.File_manager.export_data_to_other_format_with_chart(data_from_select, "name_of_statistic.SelectedItem" + " za rok " + years_combobox.SelectedItem, FormsPlot1);
        }

        private void search_with_label_Click(object sender, EventArgs e)
        {

        }

        private void data_from_select_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            chart_List.set_chart(type_chart.SelectedIndex, FormsPlot1, data_from_select, Other_features.name_of_statistics(statistic_id));
        }
    }
}
