using evidence_clip_about_public_transport.DAO;
using evidence_clip_about_public_transport.DAO.mysql.for_stop;
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
using static Mysqlx.Crud.Order.Types;
/* author Martin Hamacek, C4c, 2024/2025*/
namespace evidence_clip_about_public_transport.Win_forms_user_interface.for_mean_of_transport
{
    public partial class Edit_mean_of_transport : Form,I_Edit_data_in_table
    {
        public Edit_mean_of_transport()
        {
            
            InitializeComponent();
            delete_button.Enabled = false;
            update_button.Enabled = false;
            create_button.Enabled = true;

        }

        public void set_mean_of_transport(Mean_of_transport mean_of_transport)
        {
            delete_button.Enabled = true;
            update_button.Enabled = true;
            create_button.Enabled = false;

            this.Text = "Úprava dopravního prostředků";

            name_.Text = mean_of_transport.Name_;
            short_name.Text = mean_of_transport.Short_name;
            id_label.Text = mean_of_transport.Id.ToString();

        }

        private void delete_button_Click(object sender, EventArgs e) 
        {
            I_DAO_Mean_of_transport delete = Database_server_switch.dAO_Mean_Of_Transport();
            MessageBox.Show(delete.delete_mean_of_transport(Int32.Parse(id_label.Text)));
        }

        private void create_button_Click(object sender, EventArgs e) 
        {
            I_DAO_Mean_of_transport create = Database_server_switch.dAO_Mean_Of_Transport();
            MessageBox.Show(create.new_mean_of_transport(new Mean_of_transport(0, name_.Text,short_name.Text)));
        }

        private void update_button_Click(object sender, EventArgs e) 
        {
            I_DAO_Mean_of_transport edit = Database_server_switch.dAO_Mean_Of_Transport();
            MessageBox.Show(edit.update_mean_of_transport(new Mean_of_transport(Int32.Parse(id_label.Text), name_.Text, short_name.Text)));
        }

        private void cancel_button_Click(object sender, EventArgs e) 
        { 
            this.Close();
        }
    }
}
