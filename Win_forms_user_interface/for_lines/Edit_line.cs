using evidence_clip_about_public_transport.DAO;
using evidence_clip_about_public_transport.DAO.mysql.for_formats;
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
namespace evidence_clip_about_public_transport.Win_forms_user_interface.for_lines
{
    public partial class Edit_line : Form,I_Edit_data_in_table
    {
      
        public void set_line_for_edit(Line line) 
        {
            delete_button.Enabled = true;
            update_button.Enabled = true;
            create_button.Enabled = false;

            this.Text = "Úprava linky";

            name_line.Text= line.Name_line;
            number_line.Value= line.Number_line;
            id_label.Text = line.Id.ToString();

        }

        public Edit_line()
        {
            InitializeComponent();

            delete_button.Enabled = false;
            update_button.Enabled = false;
            create_button.Enabled = true;
        }

        private void delete_button_Click(object sender, EventArgs e) 
        {
            I_DAO_Line delete_line = Database_server_switch.dAO_Line();
            MessageBox.Show(delete_line.delete_line(Int32.Parse(id_label.Text)));
        }

        private void create_button_Click(object sender, EventArgs e) 
        {
            I_DAO_Line create_line = Database_server_switch.dAO_Line();
            MessageBox.Show(create_line.new_line(new Line(0, (int)number_line.Value, name_line.Text)));
        }

        private void update_button_Click(object sender, EventArgs e) 
        {
            I_DAO_Line update_line = Database_server_switch.dAO_Line();
            MessageBox.Show(update_line.update_line(new Line(Int32.Parse(id_label.Text), (int)number_line.Value, name_line.Text)));
        }

        private void cancel_button_Click(object sender, EventArgs e) 
        { 
            this.Close();
        }
    }
}
