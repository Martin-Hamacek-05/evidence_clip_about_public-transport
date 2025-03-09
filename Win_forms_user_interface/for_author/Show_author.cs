using evidence_clip_about_public_transport.DAO;
using evidence_clip_about_public_transport.DAO.mysql.for_clip;
using evidence_clip_about_public_transport.Other_classes;
using evidence_clip_about_public_transport.Win_forms_user_interface.Author;
using evidence_clip_about_public_transport.Win_forms_user_interface.for_clip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace evidence_clip_about_public_transport.Win_forms_user_interface.for_author
{
    public partial class Show_author : Form,I_List_from_table
    {
        private readonly string[] headers_in_czech = { "uživatelské jméno", "je admin", "podrobnosti", "e-mail", "datum vytvoření", "počet přístupů", "heslo"};
        public Show_author()
        {
            InitializeComponent();
        }

        private void new_record_Click(object sender, EventArgs e) 
        { 
            Edit_Author new_Author = new Edit_Author();
            new_Author.Show();
        }
        private void load_button_Click(object sender, EventArgs e) 
        {
            I_DAO_Author aO_Author_Implement = Database_server_switch.DAO_Author();
            data_from_select.DataSource = aO_Author_Implement.get_all_authors().Tables[0];
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
            I_DAO_Author load = Database_server_switch.DAO_Author();
            Edit_Author edit = new Edit_Author();

            int selected = e.RowIndex;
            if (selected != -1)
            {

                DataGridViewRow selected_row = data_from_select.Rows[selected];
                edit.set_author_for_edit(load.get_author(Convert.ToInt32(selected_row.Cells[0].Value)));
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
                data_from_select.Columns[1].HeaderText = "login_name";
                BindingSource bs = new BindingSource();
                bs.DataSource = data_from_select.DataSource;
                
                bs.Filter = data_from_select.Columns[1].HeaderText.ToString() + " LIKE '%" + search_textbox.Text + "%'";
                //bs.Filter = string.Format("created >= '{0}' AND created <= '{1}' and name_line='12' or name_line='5'", "2024-01-02","2024-01-31");
                data_from_select.Columns[1].HeaderText = headers_in_czech[0];
                data_from_select.DataSource = bs;
                status_label.Text = "OK | Počet nalezených záznamů: " + data_from_select.Rows.Count.ToString();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
