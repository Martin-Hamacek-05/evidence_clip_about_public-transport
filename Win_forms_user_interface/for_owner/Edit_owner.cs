using evidence_clip_about_public_transport.DAO;
using evidence_clip_about_public_transport.DAO.mysql.for_mean_of_transport;
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
using evidence_clip_about_public_transport.Entits;
/* author Martin Hamacek, C4c, 2024/2025*/
namespace evidence_clip_about_public_transport.Win_forms_user_interface.for_owner
{

    public partial class Edit_owner : Form, I_Edit_data_in_table
    {
        public Edit_owner()
        {
            InitializeComponent();
            delete_button.Enabled = false;
            update_button.Enabled = false;
            create_button.Enabled = true;
        }

        public void set_owner(Owner_ owner)
        {
            delete_button.Enabled = true;
            update_button.Enabled = true;
            create_button.Enabled = false;

            this.Text = "Úprava dopravce";

            name_.Text = owner.Name_;
            heardquarters.Text = owner.Headquarters;
            note.Text = owner.Note;
            id_label.Text = owner.Id.ToString();

        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            I_DAO_Owner delete = Database_server_switch.dAO_owner();
            MessageBox.Show(delete.delete_owner(Int32.Parse(id_label.Text)));
        }

        private void create_button_Click(object sender, EventArgs e)
        {
            I_DAO_Owner create = Database_server_switch.dAO_owner();
            MessageBox.Show(create.new_owner(new Owner_(0, name_.Text, heardquarters.Text,note.Text)));
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            I_DAO_Owner edit = Database_server_switch.dAO_owner();
            MessageBox.Show(edit.update_owner(new Owner_(Int32.Parse(id_label.Text), name_.Text, heardquarters.Text, note.Text)));
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
