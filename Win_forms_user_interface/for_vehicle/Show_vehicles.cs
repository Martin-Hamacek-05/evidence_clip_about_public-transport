using evidence_clip_about_public_transport.DAO;
using evidence_clip_about_public_transport.DAO.mysql.for_clip;
using evidence_clip_about_public_transport.Other_classes;
using evidence_clip_about_public_transport.Win_forms_user_interface.for_clip;
using evidence_clip_about_public_transport.Win_forms_user_interface.for_mean_of_transport;
using evidence_clip_about_public_transport.Win_forms_user_interface.for_owner;
using evidence_clip_about_public_transport.Win_forms_user_interface.for_pattern;
using evidence_clip_about_public_transport.Win_forms_user_interface.for_producer;
using evidence_clip_about_public_transport.Win_forms_user_interface.for_subtype_mean_of_transport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* author Martin Hamacek, C4c, 2024/2025*/
namespace evidence_clip_about_public_transport.Win_forms_user_interface.for_vehicle
{

    public partial class Show_vehicles : Form, I_List_from_table
    {
        private readonly string[] headers_in_czech = {"evidenční číslo","SPZ","rok výroby","v provozu od","v provozu do","je nízkopodlažní","má klimatizaci","výrobce","dopravní prostředek","podtyp","dopravce / vlastník","předchůdce","směr vozidla" };

        public Show_vehicles()
        {
            InitializeComponent();
            data_from_select.ReadOnly = true;
        }

        private void new_record_Click(object sender, EventArgs e)
        {
            try
            {
                Edit_vehicle new_vehicle = new Edit_vehicle();
                new_vehicle.Show();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void load_button_Click(object sender, EventArgs e)
        {
            
            I_DAO_Vehicle dAO_Clip_Implement = Database_server_switch.dAO_Vehicle();
            data_from_select.DataSource = dAO_Clip_Implement.get_all_vehicles().Tables[0];
            data_from_select.Columns[0].Visible = false;

            for (int i = 0; i < headers_in_czech.Length; i++) 
            {
                data_from_select.Columns[i+1].HeaderText=headers_in_czech[i];
            }

            data_from_select.Update();
            status_label.Text = "OK | Počet nalezených záznamů: " + data_from_select.Rows.Count.ToString();
        }

        private void data_from_select_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            I_DAO_Vehicle load = Database_server_switch.dAO_Vehicle();
            Edit_vehicle edit = new Edit_vehicle();

            int selected = e.RowIndex;
            if (selected != -1)
            {
                DataGridViewRow selected_row = data_from_select.Rows[selected];
                edit.set_vehicle(load.get_vehicle(Convert.ToInt32(selected_row.Cells[0].Value)));
                
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
                data_from_select.Columns[1].HeaderText = "number_";
                BindingSource bs = new BindingSource();
                bs.DataSource = data_from_select.DataSource;
                bs.Filter = data_from_select.Columns[1].HeaderText.ToString() + " LIKE '%" + search_clip_textbox.Text + "%'";
                data_from_select.DataSource = bs;
                data_from_select.Columns[1].HeaderText = headers_in_czech[0];
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

     
        private void edit_producer_button_Click(object sender, EventArgs e)
        {
            Show_producer show_Producer = new Show_producer();
            show_Producer.Show();
        }

        private void edit_pattern_button_Click(object sender, EventArgs e)
        {
            Show_pattern show_Pattern = new Show_pattern();
            show_Pattern.Show();
        }

        private void edit_owner_button_Click(object sender, EventArgs e)
        {
            Show_owner owner = new Show_owner();
            owner.Show();
        }

        private void edit_subtype_mean_of_transport_button_Click(object sender, EventArgs e)
        {
            Show_subtype subtype_Mean_Of_Transport = new Show_subtype();
            subtype_Mean_Of_Transport.Show();
        }

        private void edit_mean_of_transport_button_Click(object sender, EventArgs e)
        {
            Show_mean_of_transport show_Mean_Of_Transport = new Show_mean_of_transport();
            show_Mean_Of_Transport.Show();
        }
    }
}
