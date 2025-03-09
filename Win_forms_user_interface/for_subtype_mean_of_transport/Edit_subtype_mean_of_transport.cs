using evidence_clip_about_public_transport.DAO;
using evidence_clip_about_public_transport.DAO.mysql.for_owner;
using evidence_clip_about_public_transport.DAO.mysql.other_features;
using evidence_clip_about_public_transport.Database_connection;
using evidence_clip_about_public_transport.Entits;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* author Martin Hamacek, C4c, 2024/2025*/
namespace evidence_clip_about_public_transport.Win_forms_user_interface.for_subtype_mean_of_transport
{
    public partial class Edit_subtype_mean_of_transport : Form, I_Edit_data_in_table
    {
        public Edit_subtype_mean_of_transport()
        {
            InitializeComponent();

            delete_button.Enabled = false;
            update_button.Enabled = false;
            create_button.Enabled = true;

            I_List_to_combobox list_for_lines = Database_server_switch.list_to_combobox();
            list_for_lines.selects_I("select id,name_ from subtype_mean_of_transport", "name_", "id", subtype_combobox);
        }


        public void set_subtype_mean_of_transport(Subtype_mean_of_transport subtype_Mean_Of_Transport)
        {

            delete_button.Enabled = true;
            update_button.Enabled = true;
            create_button.Enabled = false;

            this.Text = "Úprava podtypu dopravního prostředků";

            name_.Text = subtype_Mean_Of_Transport.Name_;
                id_label.Text = subtype_Mean_Of_Transport.Id.ToString();

                if (subtype_Mean_Of_Transport.Subtype_mean_of_transport_id == 0)
                {
                    subtype_combobox.Enabled = false;
                    subtype.Checked = false;
                }
                else
                {
                    subtype_combobox.Enabled = true;
                    subtype.Checked = true;
                    subtype_combobox.SelectedValue = subtype_Mean_Of_Transport.Subtype_mean_of_transport_id;
                }
            
            
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            I_DAO_Subtype_mean_of_transport delete = Database_server_switch.dAO_Subtype_Mean_Of_Transport();
            MessageBox.Show(delete.delete_subtype_mean_of_transport(Int32.Parse(id_label.Text)));
        }

        private void create_button_Click(object sender, EventArgs e)
        {
            I_DAO_Subtype_mean_of_transport create = Database_server_switch.dAO_Subtype_Mean_Of_Transport();
            if (subtype.Checked)
            {
                MessageBox.Show(create.new_subtype_mean_of_transport(new Subtype_mean_of_transport(0, name_.Text, Convert.ToInt32(subtype_combobox.SelectedValue))));
            }
            else
            {
                MessageBox.Show(create.new_subtype_mean_of_transport(new Subtype_mean_of_transport(0, name_.Text, 0)));
            }

        }

        private void update_button_Click(object sender, EventArgs e)
        {
            I_DAO_Subtype_mean_of_transport edit = Database_server_switch.dAO_Subtype_Mean_Of_Transport();
            if (subtype.Checked)
            {
                MessageBox.Show(edit.update_subtype_mean_of_transport(new Subtype_mean_of_transport(Int32.Parse(id_label.Text), name_.Text, Convert.ToInt32(subtype_combobox.SelectedValue))));
            }
            else
            {
                MessageBox.Show(edit.update_subtype_mean_of_transport(new Subtype_mean_of_transport(Int32.Parse(id_label.Text), name_.Text, 0)));
            }
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void subtype_CheckedChanged(object sender, EventArgs e)
        {
            if (subtype.Checked) 
            {
                subtype_combobox.Enabled = true;
            }
        }
    }
}
