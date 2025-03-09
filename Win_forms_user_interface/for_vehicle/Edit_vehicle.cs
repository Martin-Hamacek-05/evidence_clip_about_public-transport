using evidence_clip_about_public_transport.DAO;
using evidence_clip_about_public_transport.DAO.mysql.other_features;
using evidence_clip_about_public_transport.Database_connection;
using evidence_clip_about_public_transport.Entits;
using evidence_clip_about_public_transport.Win_forms_user_interface.for_pattern_on_vehicle;
using evidence_clip_about_public_transport.Win_forms_user_interface.for_vehicles_on_clip;
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
    public partial class Edit_vehicle : Form, I_Edit_data_in_table
    {

        public void set_vehicle(Vehicle vehicle)
        {
            delete_button.Enabled = true;
            update_button.Enabled = true;
            create_button.Enabled = false;

            this.Text = "Úprava vozidla";

            number.Text = vehicle.Number_;
            vehicle_registration_plate.Text = vehicle.Vehicle_registration_plate;
            year_of_made.Value = vehicle.Year_of_made;
            in_operation_from.Value = vehicle.In_operation_from.ToDateTime(TimeOnly.Parse("00:00 AM")); ;
            in_operation_to.Value = vehicle.In_operation_to.ToDateTime(TimeOnly.Parse("00:00 AM")); ;
            is_low_rise.Checked = vehicle.Is_low_rise;
            have_air_conditioning.Checked = vehicle.Have_air_conditioning;
            producer_combobox.SelectedValue = vehicle.Producer_id;
            mean_of_transport_combobox.SelectedValue = vehicle.Mean_of_transport_id;
            subtype_mean_of_transport_combobox.SelectedValue = vehicle.Subtype_mean_of_transport_id;
            I_Other_database_features other_Database_Features = Database_server_switch.other_Database_Features();
            other_Database_Features.patterns_on_vehicle(vehicle.Id, pattern_list);
            direction_of_vehicle.Text = vehicle.Direction_of_vehicle;
            owner_combobox.SelectedValue = vehicle.Owner_id;
            id_label.Text = vehicle.Id.ToString();
            edit_pattern_button.Enabled = true;
            if (vehicle.Vehicle_id == 0)
            {
                predecessor_combobox.Enabled = false;
                is_predecessor.Checked = false;
            }
            else 
            {
                predecessor_combobox.Enabled = true;
                is_predecessor.Checked = true;
                predecessor_combobox.SelectedValue= vehicle.Vehicle_id;
            }

        }
        public Edit_vehicle()
        {
            InitializeComponent();
             
            delete_button.Enabled = false;
            update_button.Enabled = false;
            create_button.Enabled = true;

            I_List_to_combobox list_for_lines = Database_server_switch.list_to_combobox();

            list_for_lines.selects_I("select id,name_ from producer", "name_", "id", producer_combobox);
            list_for_lines.selects_I("select id,name_ from mean_of_transport", "name_", "id", mean_of_transport_combobox);
            list_for_lines.selects_I("select id,name_ from subtype_mean_of_transport", "name_", "id", subtype_mean_of_transport_combobox);
            list_for_lines.selects_I("select id,name_ from owner_", "name_", "id", owner_combobox);
            list_for_lines.selects_III("select distinct direction_of_vehicle from vehicle", "direction_of_vehicle", direction_of_vehicle);
            string selectt = "select vehicle.id, vehicle.number_,subtype_mean_of_transport.name_ as subtype_mean_of_transport,mean_of_transport.name_ as mean_of_transport from vehicle\r\n    inner join mean_of_transport on vehicle.mean_of_transport_id = mean_of_transport.id\r\n    inner join subtype_mean_of_transport on vehicle.subtype_mean_of_transport_id = subtype_mean_of_transport.id";
            list_for_lines.selects_II(selectt, "number_ + ', typ: ' + subtype_mean_of_transport + ', doprav_pros: ' + mean_of_transport", "id", predecessor_combobox);
        }

        private void delete_button_Click(object sender, EventArgs e) 
        { 
            I_DAO_Vehicle delete = Database_server_switch.dAO_Vehicle();
            MessageBox.Show(delete.delete_vehicle(Int32.Parse(id_label.Text)));
        }

        private void create_button_Click(object sender, EventArgs e) 
        {
            I_DAO_Vehicle new_vehicle = Database_server_switch.dAO_Vehicle();
            if (in_operation_from.Value <= in_operation_to.Value)
            {
                if (is_predecessor.Checked)
                {
                    MessageBox.Show(new_vehicle.new_vehicle_with_predecessor(new Vehicle(0, number.Text, vehicle_registration_plate.Text, Convert.ToInt32(year_of_made.Value), DateOnly.FromDateTime(in_operation_from.Value), DateOnly.FromDateTime(in_operation_to.Value), is_low_rise.Checked, have_air_conditioning.Checked, Convert.ToInt32(producer_combobox.SelectedValue), Convert.ToInt32(mean_of_transport_combobox.SelectedValue), Convert.ToInt32(subtype_mean_of_transport_combobox.SelectedValue), Convert.ToInt32(owner_combobox.SelectedValue), Convert.ToInt32(predecessor_combobox.SelectedValue),direction_of_vehicle.Text)));
                }
                else
                {
                    MessageBox.Show(new_vehicle.new_vehicle(new Vehicle(0, number.Text, vehicle_registration_plate.Text, Convert.ToInt32(year_of_made.Value), DateOnly.FromDateTime(in_operation_from.Value), DateOnly.FromDateTime(in_operation_to.Value), is_low_rise.Checked, have_air_conditioning.Checked, Convert.ToInt32(producer_combobox.SelectedValue), Convert.ToInt32(mean_of_transport_combobox.SelectedValue), Convert.ToInt32(subtype_mean_of_transport_combobox.SelectedValue), Convert.ToInt32(owner_combobox.SelectedValue), direction_of_vehicle.Text)));
                }
            }
            else 
            {
                MessageBox.Show("Datum od musí být menší, nebo stejné jako datum do");
            }
            //MessageBox.Show(direction_of_vehicle.Text);
        }

        private void update_button_Click(object sender, EventArgs e) 
        {
            I_DAO_Vehicle update_vehicle = Database_server_switch.dAO_Vehicle();
            if (in_operation_from.Value <= in_operation_to.Value)
            {

                if (is_predecessor.Checked)
                {
                    MessageBox.Show(update_vehicle.update_vehicle_with_predecessor(new Vehicle(Int32.Parse(id_label.Text), number.Text, vehicle_registration_plate.Text, Convert.ToInt32(year_of_made.Value), DateOnly.FromDateTime(in_operation_from.Value), DateOnly.FromDateTime(in_operation_to.Value), is_low_rise.Checked, have_air_conditioning.Checked, Convert.ToInt32(producer_combobox.SelectedValue), Convert.ToInt32(mean_of_transport_combobox.SelectedValue), Convert.ToInt32(subtype_mean_of_transport_combobox.SelectedValue), Convert.ToInt32(owner_combobox.SelectedValue), Convert.ToInt32(predecessor_combobox.SelectedValue), direction_of_vehicle.Text)));
                }
                else
                {
                    MessageBox.Show(update_vehicle.update_vehicle(new Vehicle(Int32.Parse(id_label.Text), number.Text, vehicle_registration_plate.Text, Convert.ToInt32(year_of_made.Value), DateOnly.FromDateTime(in_operation_from.Value), DateOnly.FromDateTime(in_operation_to.Value), is_low_rise.Checked, have_air_conditioning.Checked, Convert.ToInt32(producer_combobox.SelectedValue), Convert.ToInt32(mean_of_transport_combobox.SelectedValue), Convert.ToInt32(subtype_mean_of_transport_combobox.SelectedValue), Convert.ToInt32(owner_combobox.SelectedValue), direction_of_vehicle.Text)));
                }
            }
            else 
            {
                MessageBox.Show("Datum od musí být menší, nebo stejné jako datum do");
            }
        }

        private void cancel_button_Click(object sender, EventArgs e) 
        { 
            this.Close();
        }

        private void edit_pattern_button_Click(object sender, EventArgs e)
        {
            Edit_pattern_on_vehicle  edit_Pattern_On_Vehicle = new Edit_pattern_on_vehicle();
            edit_Pattern_On_Vehicle.set_id_of_selected_vehicle(Int32.Parse(id_label.Text));
            edit_Pattern_On_Vehicle.load_grid();
            edit_Pattern_On_Vehicle.Show();
        }

        private void is_predecessor_CheckedChanged(object sender, EventArgs e)
        {
            if (is_predecessor.Checked)
            {
                predecessor_combobox.Enabled = true;
            }
            else 
            { 
                predecessor_combobox.Enabled=false;
            }
        }
    }
}
