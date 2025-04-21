using evidence_clip_about_public_transport.DAO;
using evidence_clip_about_public_transport.DAO.mysql.other_features;
using evidence_clip_about_public_transport.Database_connection;
using evidence_clip_about_public_transport.Entits;
using evidence_clip_about_public_transport.File_manager;
using evidence_clip_about_public_transport.Win_forms_user_interface.for_vehicles_on_clip;
using evidence_clip_about_public_transport.Work_with_ftp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
/* author Martin Hamacek, C4c, 2024/2025*/
namespace evidence_clip_about_public_transport.Win_forms_user_interface.for_clip
{

    public partial class Edit_clip : Form, I_Edit_data_in_table
    {
        private File_manager_switch file_Manager = new File_manager_switch();

        private int selected_index = 0;

        private bool is_edited = false;

        private List<int> list_of_id_of_vehicles;

        private string full_url = "";

        private readonly string[] headers_in_czech = { "evidenční číslo", "podtyp", "záběr", "dopravce" };
        public Edit_clip()
        {
            InitializeComponent();
            delete_button.Enabled = false;
            update_button.Enabled = false;
            create_button.Enabled = true;

            arrive.Checked = true;

            I_List_to_combobox list_for_lines = Database_server_switch.list_to_combobox();

            list_for_lines.selects_I("select id,name_line from line order by length(name_line),name_line", "name_line", "id", lines_combobox);
            list_for_lines.selects_II("select id,name_of_stop,direction,platform from stop_ order by name_of_stop", "name_of_stop + ', nástupiště: ' + platform + ', směr: ' + direction", "id", stops_combobox);
            list_for_lines.selects_I("select id,name_ from formats", "name_", "id", formats_combobox);

            I_File_type i_File_Type = file_Manager.selected_type(Int32.Parse(Load_info_from_file.read_info_from()[0]));

            for (int i = 0; i < i_File_Type.list_of_directories(Load_info_from_file.read_info_from()[1]).Count; i++)
            {
                if (i_File_Type.list_of_directories(Load_info_from_file.read_info_from()[1])[i] != null) 
                {
                    file_url.Items.Add(i_File_Type.list_of_directories(Load_info_from_file.read_info_from()[1])[i]);
                }
            }

            //ftp_functions.load_directory_to_combo_box(file_url);

            string selectt = "select vehicle.id, vehicle.number_,subtype_mean_of_transport.name_ as subtype_mean_of_transport,mean_of_transport.name_ as mean_of_transport from vehicle\r\n    inner join mean_of_transport on vehicle.mean_of_transport_id = mean_of_transport.id\r\n    inner join subtype_mean_of_transport on vehicle.subtype_mean_of_transport_id = subtype_mean_of_transport.id order by number_";
            list_for_lines.selects_II(selectt, "number_ + ', typ: ' + subtype_mean_of_transport + ', doprav_pros: ' + mean_of_transport", "id", vehicle_combobox);
        }
        public void set_column()
        {
            vehicles_on_clip.Columns.Add("id", "id");
            vehicles_on_clip.Columns.Add("number_", "number_");
            vehicles_on_clip.Columns[0].Visible = false;
            vehicles_on_clip.Columns[1].HeaderText = headers_in_czech[0];
        }
        public void set_selected_clip(Clip clip)
        {
            delete_button.Enabled = true;
            update_button.Enabled = true;
            is_edited = true;
            create_button.Enabled = false;
            name_of_clip.Enabled = false;
            file_url.Enabled = false;

            this.Text = "Úprava klipu";

            play_clip.Enabled = true;

            name_of_clip.Text = clip.Name_of_clip.ToString();
            created.Value = clip.Created.ToDateTime(TimeOnly.Parse("00:00 AM"));
            number_of_filming_day.Value = clip.Number_of_filming_day;

            if (clip.Arrive_or_depart)
            {
                depart.Checked = true;
                arrive.Checked = false;
            }
            else
            {
                depart.Checked = false;
                arrive.Checked = true;
            }

            order_on_the_line.Text = clip.Order_on_the_line;
            file_url.Text = clip.File_url;
            lenght_of_clip.Text = clip.Lenght_of_clip.ToString();
            stops_combobox.SelectedValue = clip.Stop_id;
            lines_combobox.SelectedValue = clip.Line_id;
            formats_combobox.SelectedValue = clip.Formats_id;

            //previours_name = name_of_clip.Text;

            I_Other_database_features other_Database_Features = Database_server_switch.other_Database_Features();
            vehicles_on_clip_label.Text = other_Database_Features.vehicles_on_clip(clip.Id) + " celkem na záběrů: " + clip.Count_of_vehicles_on_clip.ToString() + " vozů";
            id_of_clip_label.Text = clip.Id.ToString();

            I_DAO_Vehicles_on_clip edit_Vehicles_On_Clip = Database_server_switch.DAO_Vehicles_On_Clip();
            vehicles_on_clip.ClearSelection();

            vehicles_on_clip.DataSource = edit_Vehicles_On_Clip.get_all_vehicles_from_list(Int32.Parse(id_of_clip_label.Text)).Tables[0];
            vehicles_on_clip.Columns[0].Visible = false;

            for (int i = 0; i < headers_in_czech.Length; i++)
            {
                vehicles_on_clip.Columns[i + 1].HeaderText = headers_in_czech[i];
            }
            vehicles_on_clip.Update();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            I_DAO_Clip delete = Database_server_switch.dAO_Clips();
            MessageBox.Show(delete.delete_clip(Int32.Parse(id_of_clip_label.Text)));
            I_File_type i_File_Type = file_Manager.selected_type(Int32.Parse(Load_info_from_file.read_info_from()[0]));
            MessageBox.Show(i_File_Type.delete_file(name_of_clip.Text, Load_info_from_file.read_info_from()[1] + "\\" + file_url.Text));
        }

        private void create_button_Click(object sender, EventArgs e)
        {
            try
            {
                bool arrive_or_depart = false;

                File_manager_switch file_Manager_Switch = new File_manager_switch();
                list_of_id_of_vehicles = new List<int>();

                foreach (DataGridViewRow row in vehicles_on_clip.Rows)
                {
                    list_of_id_of_vehicles.Add(Convert.ToInt32(row.Cells[0].Value));
                }

                if (arrive.Checked == true && depart.Checked == false)
                {
                    arrive_or_depart = false;
                }
                else if (arrive.Checked == false && depart.Checked == true)
                {
                    arrive_or_depart = true;
                }

                I_DAO_Clip new_clip = Database_server_switch.dAO_Clips();
                I_File_type i_File_Type = file_Manager.selected_type(Int32.Parse(Load_info_from_file.read_info_from()[0]));

                new_clip.new_clip(new Clip(0, name_of_clip.Text, DateOnly.FromDateTime(created.Value), Int32.Parse(number_of_filming_day.Text), arrive_or_depart, order_on_the_line.Text, file_url.Text, float.Parse(lenght_of_clip.Text), 0, Convert.ToInt32(stops_combobox.SelectedValue), Convert.ToInt32(formats_combobox.SelectedValue), Convert.ToInt32(lines_combobox.SelectedValue)), list_of_id_of_vehicles);

                MessageBox.Show(i_File_Type.record_file(name_of_clip.Text, full_url, Load_info_from_file.read_info_from()[1] + "\\" + file_url.Text));
            }
            catch (FormatException exc)
            {
                MessageBox.Show(lenght_of_clip.Text + " není číslo");
            }
            catch (Exception exce)
            {
                MessageBox.Show("Došlo k nečekané chybě: " + exce.Message);
            }
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            try
            {
                bool arrive_or_depart = false;
                if (arrive.Checked == true && depart.Checked == false)
                {
                    arrive_or_depart = false;
                }
                else if (arrive.Checked == false && depart.Checked == true)
                {
                    arrive_or_depart = true;
                }

                I_File_type i_File_Type = file_Manager.selected_type(Int32.Parse(Load_info_from_file.read_info_from()[0]));
                I_DAO_Clip update = Database_server_switch.dAO_Clips();
                MessageBox.Show(update.update_clip(new Clip(Int32.Parse(id_of_clip_label.Text), name_of_clip.Text, DateOnly.FromDateTime(created.Value), Int32.Parse(number_of_filming_day.Text), arrive_or_depart, order_on_the_line.Text, file_url.Text, float.Parse(lenght_of_clip.Text), 0, Convert.ToInt32(stops_combobox.SelectedValue), Convert.ToInt32(formats_combobox.SelectedValue), Convert.ToInt32(lines_combobox.SelectedValue))));

                
            }
            catch (FormatException exc)
            {
                MessageBox.Show(lenght_of_clip.Text + " není číslo");
            }
            catch (Exception exce)
            {
                MessageBox.Show("Došlo k nečekané chybě: " + exce.Message);
            }
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void edit_vehicles_on_clip_Click(object sender, EventArgs e)
        {
            Edit_vehicles_on_clip edit_Vehicles_On_Clip = new Edit_vehicles_on_clip();
            edit_Vehicles_On_Clip.set_id_of_selected_clip(Int32.Parse(id_of_clip_label.Text));
            edit_Vehicles_On_Clip.load_grid();
            edit_Vehicles_On_Clip.Show();
        }
        private void add_to_list_Click(object sender, EventArgs e)
        {
            if (is_edited)
            {
                if (selected_index != -1)
                {
                    I_DAO_Vehicles_on_clip dAO_Vehicles_On_Clip = Database_server_switch.DAO_Vehicles_On_Clip();
                    MessageBox.Show(dAO_Vehicles_On_Clip.add_vehicles_to_clip(new Vehicles_on_clip(0, Convert.ToInt32(vehicle_combobox.SelectedValue), Int32.Parse(id_of_clip_label.Text))));
                    I_Other_database_features other_Database_Features = Database_server_switch.other_Database_Features();
                    vehicles_on_clip_label.Text = other_Database_Features.vehicles_on_clip(Int32.Parse(id_of_clip_label.Text)) + " celkém na záběrů: " + (vehicles_on_clip.Rows.Count + 1) + " vozů";

                    vehicles_on_clip.DataSource = dAO_Vehicles_On_Clip.get_all_vehicles_from_list(Int32.Parse(id_of_clip_label.Text)).Tables[0];
                    vehicles_on_clip.Columns[0].Visible = false;

                    for (int i = 0; i < headers_in_czech.Length; i++)
                    {
                        vehicles_on_clip.Columns[i + 1].HeaderText = headers_in_czech[i];
                    }
                    vehicles_on_clip.Update();
                }
            }
            else
            {
                vehicles_on_clip.Rows.Add(vehicle_combobox.SelectedValue, vehicle_combobox.GetItemText(vehicle_combobox.SelectedItem).ToString());
            }
        }
        private void remove_from_list_Click(object sender, EventArgs e)
        {
            if (is_edited)
            {
                if (selected_index != -1)
                {

                    DataGridViewRow selected_row = vehicles_on_clip.Rows[selected_index];
                    I_DAO_Vehicles_on_clip delete = Database_server_switch.DAO_Vehicles_On_Clip();
                    MessageBox.Show(delete.delete_vehicle_from_clip(new Vehicles_on_clip(Convert.ToInt32(selected_row.Cells[0].Value), 0, Int32.Parse(id_of_clip_label.Text))));
                    vehicles_on_clip.Update();
                    I_Other_database_features other_Database_Features = Database_server_switch.other_Database_Features();
                    vehicles_on_clip_label.Text = other_Database_Features.vehicles_on_clip(Int32.Parse(id_of_clip_label.Text)) + "\n celkem na záběrů: " + (vehicles_on_clip.Rows.Count - 1) + " vozů";
                    vehicles_on_clip.DataSource = delete.get_all_vehicles_from_list(Int32.Parse(id_of_clip_label.Text)).Tables[0];
                    vehicles_on_clip.Columns[0].Visible = false;

                    for (int i = 0; i < headers_in_czech.Length; i++)
                    {
                        vehicles_on_clip.Columns[i + 1].HeaderText = headers_in_czech[i];
                    }
                    vehicles_on_clip.Update();
                }
            }
            else
            {
                try
                {
                    vehicles_on_clip.Rows.RemoveAt(selected_index);
                }
                catch (ArgumentOutOfRangeException haha)
                {
                    MessageBox.Show("Byl vybrán neplatný záznam\nZkuste vybrat znova požadovaný záznam", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }

        private void vehicles_on_clip_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selected_index = e.RowIndex;
        }


        private void Edit_clip_DragDrop(object sender, DragEventArgs e)
        {
            string[] filePaths = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            name_of_clip.Text = Path.GetFileName(filePaths[0]);
            created.Value = File.GetCreationTime(filePaths[0]);
            full_url = Path.GetDirectoryName(filePaths[0]);
        }

        private void Edit_clip_DragEnter(object sender, DragEventArgs e)
        {
        }

        private void Edit_clip_DragEnter_1(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void play_clip_Click(object sender, EventArgs e)
        {
            I_File_type i_File_Type = file_Manager.selected_type(Int32.Parse(Load_info_from_file.read_info_from()[0]));
            MessageBox.Show(i_File_Type.load_file(name_of_clip.Text, Load_info_from_file.read_info_from()[1] + "\\" + file_url.Text));
        }
    }
}
