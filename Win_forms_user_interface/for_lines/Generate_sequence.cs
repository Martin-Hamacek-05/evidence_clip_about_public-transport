using evidence_clip_about_public_transport.DAO;
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

namespace evidence_clip_about_public_transport.Win_forms_user_interface.for_lines
{
    public partial class Generate_sequence : Form
    {
        public Generate_sequence()
        {
            InitializeComponent();
        }

        private void generate_Click(object sender, EventArgs e)
        {
            string for_check = "";

            if (Convert.ToInt32(from_.Value) >= Convert.ToInt32(to.Value))
            {
                MessageBox.Show("od musí být menší než do");
            }
            else
            {
                I_DAO_Line create_line = Database_server_switch.dAO_Line();
                MessageBox.Show(create_line.sequence_of_lines(Convert.ToInt32(from_.Value), Convert.ToInt32(to.Value), Convert.ToInt32(distance.Value)));
            }
        }

        private void check_Click(object sender, EventArgs e)
        {
            string for_check = "";

            if (Convert.ToInt32(from_.Value) >= Convert.ToInt32(to.Value))
            {
                MessageBox.Show("od musí být menší než do");
            }
            else 
            {
                for (int i = Convert.ToInt32(from_.Value); i <= Convert.ToInt32(to.Value); i = i + Convert.ToInt32(distance.Value))
                {
                    for_check = for_check + i.ToString() + ";";
                }
                MessageBox.Show(for_check);
            }

            
        }
    }
}
