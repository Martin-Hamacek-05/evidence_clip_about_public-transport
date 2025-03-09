using evidence_clip_about_public_transport.DAO;
using evidence_clip_about_public_transport.DAO.mysql.for_line;
using evidence_clip_about_public_transport.Entits;
using evidence_clip_about_public_transport.Other_classes;
using evidence_clip_about_public_transport.Win_forms_user_interface.for_lines;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace evidence_clip_about_public_transport.Win_forms_user_interface.for_stops
{
    public partial class Show_stops : Form, I_List_from_table
    {
        private readonly string[] headers_in_czech = { "Název zastávky", "číslo zastávky", "nástupiště", "směr", "je v provozu", "je bezbarierová", "poznámky" };
        public Show_stops()
        {
            InitializeComponent();
            data_from_select.ReadOnly = true;
        }

        private void new_record_Click(object sender, EventArgs e)
        {
            Edit_stop new_stop = new Edit_stop();
            new_stop.Show();
        }
        private void load_button_Click(object sender, EventArgs e)
        {
            I_DAO_Stop stops = Database_server_switch.dAO_stop();
            data_from_select.DataSource = stops.get_all_stops().Tables[0];
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
            I_DAO_Stop load = Database_server_switch.dAO_stop();
            Edit_stop edit = new Edit_stop();

            int selected = e.RowIndex;
            if (selected != -1)
            {

                DataGridViewRow selected_row = data_from_select.Rows[selected];
                edit.set_stop(load.get_stop(Convert.ToInt32(selected_row.Cells[0].Value)));
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
                data_from_select.Columns[1].HeaderText = "name_of_stop";
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

        private void mass_renaming_Click(object sender, EventArgs e)
        {
            Mass_rename_stop mass_Rename_Stop = new Mass_rename_stop();
            mass_Rename_Stop.Show();
        }
    }
}
