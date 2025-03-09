using evidence_clip_about_public_transport.DAO;
using evidence_clip_about_public_transport.DAO.mysql.for_mean_of_transport;
using evidence_clip_about_public_transport.Entits;
using evidence_clip_about_public_transport.Other_classes;
using evidence_clip_about_public_transport.Win_forms_user_interface.for_mean_of_transport;
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
namespace evidence_clip_about_public_transport.Win_forms_user_interface.for_owner
{
    public partial class Show_owner : Form, I_Edit_data_in_table
    {
        private readonly string[] headers_in_czech = { "název dopravce", "sídlo", "poznámky" };
        public Show_owner()
        {
            InitializeComponent();
            data_from_select.ReadOnly = true;
        }

        private void new_record_Click(object sender, EventArgs e)
        {
            Edit_owner new_owner = new Edit_owner();
            new_owner.Show();
        }
        private void load_button_Click(object sender, EventArgs e)
        {
            I_DAO_Owner owners = Database_server_switch.dAO_owner();
            data_from_select.DataSource = owners.get_all_owners().Tables[0];
            data_from_select.Columns[0].Visible = false;

            for (int i = 0; i < headers_in_czech.Length; i++)
            {
                data_from_select.Columns[i + 1].HeaderText = headers_in_czech[i];
            }

            data_from_select.Update();
            status_label.Text = "OK | Počet nalezených záznamů: " + data_from_select.Rows.Count.ToString();
        }
        private void data_from_select_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            I_DAO_Owner load = Database_server_switch.dAO_owner();
            Edit_owner edit = new Edit_owner();

            int selected = e.RowIndex;
            if (selected != -1)
            {

                DataGridViewRow selected_row = data_from_select.Rows[selected];
                edit.set_owner(load.get_owner(Convert.ToInt32(selected_row.Cells[0].Value)));
                edit.Show();
            }
        }
        private void save_as_button_on_top_menu_trip_Click(object sender, EventArgs e) 
        {
            evidence_clip_about_public_transport.Other_classes.File_manager.export_data_to_other_format(data_from_select, header.Text);
        }
        private void search_button_Click(object sender, EventArgs e)
        {
            try
            {
                data_from_select.Columns[1].HeaderText = "name_";
                BindingSource bs = new BindingSource();
                bs.DataSource = data_from_select.DataSource;
                bs.Filter = data_from_select.Columns[1].HeaderText.ToString() + " LIKE '%" + search_textbox.Text + "%'";
                data_from_select.DataSource = bs;
                data_from_select.Columns[1].HeaderText = headers_in_czech[0];
                status_label.Text = "OK | Počet nalezených záznamů: " + data_from_select.Rows.Count.ToString();
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Nelze nic vyhledat, protože nejsou načtená data");
            }
            catch (Exception exc)
            {
                MessageBox.Show("Došlo k neočekavané chybě: \n" + exc.Message);
            }
        }
    }
}
