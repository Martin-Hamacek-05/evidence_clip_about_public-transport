using evidence_clip_about_public_transport.DAO;
using evidence_clip_about_public_transport.DAO.mysql.for_vehicles_on_clip;
using evidence_clip_about_public_transport.DAO.mysql.other_features;
using evidence_clip_about_public_transport.Database_connection;
using evidence_clip_about_public_transport.Entits;
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
namespace evidence_clip_about_public_transport.Win_forms_user_interface.for_pattern_on_vehicle
{
    public partial class Edit_pattern_on_vehicle : Form
    {
        private int selected_index = 0;
        
        private readonly string[] headers_in_czech = {"od","do","název nátěru" };

        public Edit_pattern_on_vehicle()
        {
            InitializeComponent();


            pattern_on_vehicle.ReadOnly = true;
            I_List_to_combobox list_for_lines = Database_server_switch.list_to_combobox();
            list_for_lines.selects_I("select id,name_of_pattern from pattern", "name_of_pattern", "id", pattern_combobox);

        }

        private void add_to_list_Click(object sender, EventArgs e)
        {
            I_DAO_Pattern_on_vehicle dAO_patterns_on_vehicle = Database_server_switch.dAO_Pattern_On_Vehicle();
            if (from_.Value <= to_.Value)
            {
                MessageBox.Show(dAO_patterns_on_vehicle.add_pattern_to_vehicle(new Pattern_on_vehicle(0, DateOnly.FromDateTime(from_.Value), DateOnly.FromDateTime(to_.Value), Int32.Parse(id_of_selected_vehicle_label.Text), Convert.ToInt32(pattern_combobox.SelectedValue))));
                load_grid();
                if (pattern_on_vehicle.Rows.Count < 1)
                {
                    remove_from_list.Enabled = false;
                }
                else
                {
                    remove_from_list.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Datum od musí být menší, jako datum do");
            }
        }

        private void remove_from_list_Click(object sender, EventArgs e)
        {
            DataGridViewRow selected_row = pattern_on_vehicle.Rows[selected_index];
            I_DAO_Pattern_on_vehicle delete = Database_server_switch.dAO_Pattern_On_Vehicle();
            MessageBox.Show(delete.delete_pattern_from_vehicle(Convert.ToInt32(selected_row.Cells[0].Value)));
            load_grid();

            if (pattern_on_vehicle.Rows.Count< 1)
            {
                remove_from_list.Enabled = false;
            }
            else
            {
                remove_from_list.Enabled = true;
            }

        }

        public void set_id_of_selected_vehicle(int id)
        {
            id_of_selected_vehicle_label.Text = id.ToString();
        }

        public void load_grid()
        {
            I_DAO_Pattern_on_vehicle edit_Vehicles_On_Clip = Database_server_switch.dAO_Pattern_On_Vehicle();
            pattern_on_vehicle.DataSource = edit_Vehicles_On_Clip.get_all_pattern_from_list(Int32.Parse(id_of_selected_vehicle_label.Text)).Tables[0];
            pattern_on_vehicle.Columns[0].Visible = false;
            pattern_on_vehicle.Update();

            for (int i = 0; i < headers_in_czech.Length; i++) 
            {
                pattern_on_vehicle.Columns[i+1].HeaderText = headers_in_czech[i];
            }

            if (pattern_on_vehicle.Rows.Count<1)
            {
                remove_from_list.Enabled = false;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pattern_on_vehicle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selected_index = e.RowIndex;
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
