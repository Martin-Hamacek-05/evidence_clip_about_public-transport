using evidence_clip_about_public_transport.DAO;
using evidence_clip_about_public_transport.DAO.mysql.for_clip;
using evidence_clip_about_public_transport.Entits;
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

namespace evidence_clip_about_public_transport.Win_forms_user_interface.Author
{
    public partial class Edit_Author : Form, I_Edit_data_in_table
    {
        public void set_author(evidence_clip_about_public_transport.Entits.Author author)
        {
            name_.Text = author.Login_name;
            is_admin.Checked = author.Is_admin;
            message.Text = author.Message;
            email_.Text = author.Email;
            date_created.Value = author.Date_create.ToDateTime(TimeOnly.Parse("00:00 AM"));
            
            count_of_access.Value = author.Count_of_access; 
            password_.Text = author.User_password;
            id_label.Text = author.Id.ToString();

            name_.Enabled = false;
            delete_button.Enabled = false;
            update_button.Enabled = true;
            create_button.Enabled = false;
            reset_count_of_access_button.Enabled = false;
            count_of_access.Enabled = false;
            is_admin.Enabled = false;
            message.Enabled = true;
        }

        public void set_author_for_edit(evidence_clip_about_public_transport.Entits.Author author) 
        {
            name_.Text = author.Login_name;
            is_admin.Checked = author.Is_admin;
            message.Text = author.Message;
            email_.Text = author.Email;
            date_created.Value = author.Date_create.ToDateTime(TimeOnly.Parse("00:00 AM"));
            count_of_access.Value = author.Count_of_access;
            password_.Text = author.User_password;
            id_label.Text = author.Id.ToString();

            delete_button.Enabled = true;
            update_button.Enabled = true;
            create_button.Enabled = false;
            reset_count_of_access_button.Enabled = true;
            message.Enabled = true;
        }

        public Edit_Author()
        {
            InitializeComponent();
            //date_created.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            delete_button.Enabled = false;
            update_button.Enabled = false;
            create_button.Enabled = true;
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            I_DAO_Author delete_author = Database_server_switch.DAO_Author();
            delete_author.delete_author(Int32.Parse(id_label.Text));
        }

        private void create_button_Click(object sender, EventArgs e)
        {
            I_DAO_Author new_Author = Database_server_switch.DAO_Author();
            new_Author.new_author(new Entits.Author(0, name_.Text, is_admin.Checked, message.Text, email_.Text, DateOnly.FromDateTime(date_created.Value), Convert.ToInt32(count_of_access.Value), password_.Text));
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            if (name_.Enabled == false) 
            {
                MessageBox.Show("Změny se projeví po zvonu přihlášení");
            }
            I_DAO_Author update_author = Database_server_switch.DAO_Author();
            MessageBox.Show(date_created.Value.ToString());
            update_author.update_author(new Entits.Author(Int32.Parse(id_label.Text), name_.Text, is_admin.Checked, message.Text, email_.Text, DateOnly.FromDateTime(date_created.Value), Convert.ToInt32(count_of_access.Value), password_.Text));
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reset_count_of_access_button_Click(object sender, EventArgs e)
        {
            count_of_access.Value = 0;
        }

        private void change_password_button_Click(object sender, EventArgs e)
        {
            password_.Enabled = true;
        }
    }
}
