using evidence_clip_about_public_transport.DAO;
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
namespace evidence_clip_about_public_transport.Win_forms_user_interface.for_stops
{
    public partial class Edit_stop : Form,I_Edit_data_in_table
    {
        public Edit_stop()
        {
            InitializeComponent();

            delete_button.Enabled = false;
            update_button.Enabled = false;
            create_button.Enabled = true;
        }

        public void set_stop(Stop_ stop) 
        {
            delete_button.Enabled = true;
            update_button.Enabled = true;
            create_button.Enabled = false;

            this.Text = "Úprava zastávky";

            name_stop.Text = stop.Name_of_stop;
            number_of_stop.Text = stop.Number_of_stop;
            platform.Text = stop.Platform;
            direction.Text = stop.Direction;
            is_operation.Checked = stop.Is_operation;
            is_row_rise.Checked = stop.Is_low_rise;
            note.Text = stop.Note;
            id_label.Text = stop.Id.ToString();

        }

        private void delete_button_Click(object sender, EventArgs e) 
        {
            I_DAO_Stop delete = Database_server_switch.dAO_stop();
            MessageBox.Show(delete.delete_stop(Int32.Parse(id_label.Text)));
        }

        private void create_button_Click(object sender, EventArgs e) 
        {
            I_DAO_Stop create = Database_server_switch.dAO_stop();
            MessageBox.Show(create.new_stop(new Stop_(0, name_stop.Text, number_of_stop.Text, platform.Text, direction.Text, is_operation.Checked, is_row_rise.Checked, note.Text)));
        }

        private void update_button_Click(object sender, EventArgs e) 
        {
            I_DAO_Stop create = Database_server_switch.dAO_stop();
            MessageBox.Show(create.update_stop(new Stop_(Int32.Parse(id_label.Text), name_stop.Text, number_of_stop.Text, platform.Text, direction.Text, is_operation.Checked, is_row_rise.Checked, note.Text)));
        }

        private void cancel_button_Click(object sender, EventArgs e) 
        { 
            this.Close();
        }
    }
}
