using evidence_clip_about_public_transport.DAO;
using evidence_clip_about_public_transport.DAO.mysql.for_clip;
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
namespace evidence_clip_about_public_transport.Win_forms_user_interface.for_vehicles_on_clip
{
    public partial class Edit_vehicles_on_clip : Form
    {

        
        private int selected_index = 0;
        public Edit_vehicles_on_clip()
        {
            InitializeComponent();
            vehicles_on_clip.ReadOnly = true;

            I_List_to_combobox list_for_lines = Database_server_switch.list_to_combobox();
            string selectt = "select vehicle.id, vehicle.number_,subtype_mean_of_transport.name_ as subtype_mean_of_transport,mean_of_transport.name_ as mean_of_transport from vehicle\r\n    inner join mean_of_transport on vehicle.mean_of_transport_id = mean_of_transport.id\r\n    inner join subtype_mean_of_transport on vehicle.subtype_mean_of_transport_id = subtype_mean_of_transport.id";
            list_for_lines.selects_II(selectt, "number_ + ', typ: ' + subtype_mean_of_transport + ', doprav_pros: ' + mean_of_transport", "id", vehicle_combobox);

        }

        private void add_to_list_Click(object sender, EventArgs e)
        {
            I_DAO_Vehicles_on_clip dAO_Vehicles_On_Clip = Database_server_switch.DAO_Vehicles_On_Clip();
            MessageBox.Show(dAO_Vehicles_On_Clip.add_vehicles_to_clip(new Vehicles_on_clip(0, Convert.ToInt32(vehicle_combobox.SelectedValue), Int32.Parse(id_of_selected_clip_label.Text))));
            load_grid();
            
        }

        private void remove_from_list_Click(object sender, EventArgs e)
        {


            DataGridViewRow selected_row = vehicles_on_clip.Rows[selected_index];
            I_DAO_Vehicles_on_clip delete = Database_server_switch.DAO_Vehicles_On_Clip();
            MessageBox.Show(delete.delete_vehicle_from_clip(new Vehicles_on_clip(Convert.ToInt32(selected_row.Cells[0].Value),0, Int32.Parse(id_of_selected_clip_label.Text))));
            load_grid();

            

        }

        public void set_id_of_selected_clip(int id)
        {
            id_of_selected_clip_label.Text = id.ToString();
            
        }

        public void load_grid()
        {
            

            

        }

        private void vehicles_on_clip_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selected_index = e.RowIndex;


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
