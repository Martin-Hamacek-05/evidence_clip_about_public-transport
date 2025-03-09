using evidence_clip_about_public_transport.DAO;
using evidence_clip_about_public_transport.DAO.mysql.for_owner;
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
namespace evidence_clip_about_public_transport.Win_forms_user_interface.for_producer
{
    public partial class Edit_producer : Form,I_Edit_data_in_table
    {
        public Edit_producer()
        {
            InitializeComponent();

            delete_button.Enabled = false;
            update_button.Enabled = false;
            create_button.Enabled = true;
        }

        public void set_producer(Producer producer)
        {
            delete_button.Enabled = true;
            update_button.Enabled = true;
            create_button.Enabled = false;

            this.Text = "Úprava výrobce";

            name_.Text = producer.Name_;
            heardquarters.Text = producer.Headquarters;
            note.Text = producer.Note;
            id_label.Text = producer.Id.ToString();

        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            I_DAO_Producer delete = Database_server_switch.dAO_producer();
            MessageBox.Show(delete.delete_producer(Int32.Parse(id_label.Text)));
        }

        private void create_button_Click(object sender, EventArgs e)
        {
            I_DAO_Producer create = Database_server_switch.dAO_producer();
            MessageBox.Show(create.new_producer(new Producer(0, name_.Text, heardquarters.Text, note.Text)));
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            I_DAO_Producer edit = Database_server_switch.dAO_producer();
            MessageBox.Show(edit.update_producer(new Producer(Int32.Parse(id_label.Text), name_.Text, heardquarters.Text, note.Text)));
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
