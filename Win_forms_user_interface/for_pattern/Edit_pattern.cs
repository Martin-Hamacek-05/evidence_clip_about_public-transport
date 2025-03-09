using evidence_clip_about_public_transport.DAO;
using evidence_clip_about_public_transport.DAO.mysql.for_producer;
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
using System.Xml.Linq;
/* author Martin Hamacek, C4c, 2024/2025*/
namespace evidence_clip_about_public_transport.Win_forms_user_interface.for_pattern
{
    public partial class Edit_pattern : Form,I_Edit_data_in_table
    {
        public Edit_pattern()
        {
            InitializeComponent();
            delete_button.Enabled = false;
            update_button.Enabled = false;
            create_button.Enabled = true;
            
        }

        public void set_pattern(Pattern pattern)
        {
            delete_button.Enabled = true;
            update_button.Enabled = true;
            create_button.Enabled = false;

            this.Text = "Úprava nátěru";

            name_.Text = pattern.Name_of_pattern;
            note.Text = pattern.Note;
            id_label.Text = pattern.Id.ToString();

        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            I_DAO_Pattern delete = Database_server_switch.dAO_pattern();
            MessageBox.Show(delete.delete_pattern(Int32.Parse(id_label.Text)));
        }

        private void create_button_Click(object sender, EventArgs e)
        {
            I_DAO_Pattern create = Database_server_switch.dAO_pattern();
            MessageBox.Show(create.new_pattern(new Pattern(0, name_.Text, note.Text)));
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            I_DAO_Pattern edit = Database_server_switch.dAO_pattern();
            MessageBox.Show(edit.update_pattern(new Pattern(Int32.Parse(id_label.Text), name_.Text, note.Text)));
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
