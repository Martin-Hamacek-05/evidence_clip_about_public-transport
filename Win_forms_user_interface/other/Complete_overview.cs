using evidence_clip_about_public_transport.DAO.mysql.other_features;
using evidence_clip_about_public_transport.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using evidence_clip_about_public_transport.Other_classes;

namespace evidence_clip_about_public_transport.Win_forms_user_interface.other
{
    public partial class Complete_overview : Form
    {
        private readonly string[] headers_in_czech = { "název statistiky", "podrobnosti", "počet", "poznámky" };

        private static I_Other_database_features Other_database_features = Database_server_switch.other_Database_Features();
        public Complete_overview()
        {
            InitializeComponent();

            years_combobox.Items.Add("---vyberte---");
            years_combobox.SelectedIndex = 0;

            

            I_List_to_combobox list_To_Combobox = Database_server_switch.list_to_combobox();
            list_To_Combobox.yers_to_combobox("select distinct year(created) as years from clip order by years desc", years_combobox);
        }

        private void save_as_button_on_top_menu_trip_Click(object sender, EventArgs e)
        {
            string header = "";

            if (years_combobox.SelectedIndex == 0)
            {
                header = "přehled";
            }
            else 
            {
                header = "přehled za rok" + years_combobox.SelectedItem;
            }

            evidence_clip_about_public_transport.Other_classes.File_manager.export_data_to_other_format(data, header, string.Empty, "a");
        }

        private void load_button_Click(object sender, EventArgs e)
        {
            data.DataSource = Other_database_features.load_stored_procedure(Other_features.procedure_convertor(0), years_combobox.ComboBox.SelectedItem.ToString()).Tables[0];
            data.Update();

                for (int i = 0; i < headers_in_czech.Length; i++)
            {
                data.Columns[i].HeaderText = headers_in_czech[i];
            }

        }
    }
}
