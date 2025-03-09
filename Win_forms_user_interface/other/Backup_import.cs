using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using evidence_clip_about_public_transport.DAO.mysql.for_line;
using evidence_clip_about_public_transport.Entits;
using evidence_clip_about_public_transport.Other_classes.Backup_class;
using evidence_clip_about_public_transport.Other_classes.Load_backup;
/* author Martin Hamacek, C4c, 2024/2025*/
namespace evidence_clip_about_public_transport.Win_forms_user_interface.other
{
    public partial class Backup_import : Form
    {
        private Load_switch load_Switch = new Load_switch();
        public Backup_import()
        {

            InitializeComponent();
            table_name_combobox.SelectedIndex = 0;
            for (int i = 0; i < Load_fill_list.fill().Count; i++)
            {
                load_Switch.add_to_list(Load_fill_list.fill()[i]);
            }



        }

        private void load_file_line_Click(object sender, EventArgs e)
        {
            MessageBox.Show(load_Switch.get_from_list(table_name_combobox.SelectedIndex).load_database(path_for_line.Text));
            //MessageBox.Show(table_name_combobox.SelectedIndex.ToString());
            
            //MessageBox.Show(i_Load_To_Database.load_database(path_for_line.Text, selected_format_for_line));

        }

        private void load_file_stop_Click(object sender, EventArgs e)
        {
            I_Load_to_database i_Load_To_Database = new Load_stops();
            //MessageBox.Show(i_Load_To_Database.load_database(path_for_stop.Text, selected_format_for_stop));
        }

        private void select_file_line_Click(object sender, EventArgs e)
        {
            OpenFileDialog load_file = new OpenFileDialog();
            load_file.Filter = "soubor s oddělovačem *.csv|*.csv";
            load_file.ShowDialog();
            if (!(string.IsNullOrWhiteSpace(load_file.FileName)))
            {
                path_for_line.Text = Path.GetFullPath(load_file.FileName);
            }

        }

        private void select_file_stop_Click(object sender, EventArgs e)
        {
            OpenFileDialog load_file = new OpenFileDialog();
            load_file.Filter = "soubor s oddělovačem *.csv|*.csv";
            load_file.ShowDialog();
            if (!(string.IsNullOrWhiteSpace(load_file.FileName)))
            {
                //path_for_stop.Text = Path.GetFullPath(load_file.FileName);
            }

        }

        private void load_file_author_Click(object sender, EventArgs e)
        {
            I_Load_to_database i_Load_To_Database = new Load_authors();
            //MessageBox.Show(i_Load_To_Database.load_database(path_for_author.Text, 1));
        }

        private void select_file_author_Click(object sender, EventArgs e)
        {
            OpenFileDialog load_file = new OpenFileDialog();
            load_file.Filter = "soubor s oddělovačem *.csv|*.csv";
            load_file.ShowDialog();
            load_file.FilterIndex=1;
            if (!(string.IsNullOrWhiteSpace(load_file.FileName)))
            {
                //path_for_author.Text = Path.GetFullPath(load_file.FileName);
            }
        }
    }

}
