using evidence_clip_about_public_transport.DAO;
using evidence_clip_about_public_transport.Entits;
using evidence_clip_about_public_transport.Other_classes;
using evidence_clip_about_public_transport.Win_forms_user_interface.ftp_manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace evidence_clip_about_public_transport.Win_forms_user_interface.other
{
    public partial class Login_popup : Form
    {
        public Login_popup()
        {
            InitializeComponent();
        }
        public Login_popup(Show_clips show_Clips) 
        {
            InitializeComponent();
            this.Show();
        }
        private void set_database_connection_button_Click(object sender, EventArgs e)
        {
            Database_set_connection database_Set_Connection = new Database_set_connection();
            database_Set_Connection.Show();
            /*Style_manager.load_style();
            Styles_for_html styles_For_Html = new Styles_for_html();
            styles_For_Html.Show();
            Database_set_connection database_Set_Connection = new Database_set_connection();
            database_Set_Connection.Show();
            Ftp_manager ftp_Manager = new Ftp_manager();
            ftp_Manager.Show();*/
        }
        private void login_to_system_button_Click(object sender, EventArgs e)
        {
            try
            {
                I_DAO_Author dAO_Author_Implement = Database_server_switch.DAO_Author();
                
                Entits.Author author = new Entits.Author(0, login_name.Text, false, "", "", new DateOnly(), 0, password_.Text);
                
                dAO_Author_Implement.change_count_of_access(author.Id);
                author = dAO_Author_Implement.set_author_for_login(author);
                Signpost show_clip = new Signpost(this);
                show_clip.set_clip(author);
                show_clip.Show();
                this.Hide();
            }
            catch (Exception excd) 
            {
                MessageBox.Show(excd.ToString());
            }
        }
    }
}