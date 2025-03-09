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
/* author Martin Hamacek, C4c, 2024/2025*/
namespace evidence_clip_about_public_transport.Win_forms_user_interface.for_stops
{
    public partial class Mass_rename_stop : Form
    {
        public Mass_rename_stop()
        {
            InitializeComponent();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            I_DAO_Stop dAO_Stop_Implement = Database_server_switch.dAO_stop();
            MessageBox.Show(dAO_Stop_Implement.mass_rename_stop(previours_name.Text, new_name.Text));
        }
    }
}
