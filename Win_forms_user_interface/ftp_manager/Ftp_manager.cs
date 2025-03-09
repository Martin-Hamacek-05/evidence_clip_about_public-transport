using evidence_clip_about_public_transport.File_manager;
using evidence_clip_about_public_transport.Work_with_ftp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace evidence_clip_about_public_transport.Win_forms_user_interface.ftp_manager
{
    public partial class Ftp_manager : Form
    {
        private File_manager_switch file_Manager_Switch = new File_manager_switch();
        private I_File_type type_of_file;
        public Ftp_manager()
        {
            InitializeComponent();
            try 
            {
            file_source.SelectedIndex = Int32.Parse(Load_info_from_file.read_info_from()[0]);
            server.Text = Load_info_from_file.read_info_from()[1];
            user_name.Text = Load_info_from_file.read_info_from()[2];
            password.Text = Load_info_from_file.read_info_from()[3];
            }
            catch(Exception Exc) 
            {
                file_source.SelectedIndex = 0;
                MessageBox.Show(Exc.Message);
            }
        }
        
        private void connect_button_Click(object sender, EventArgs e)
        {
            Load_info_from_file.write_info_to_file(file_source.SelectedIndex.ToString(),server.Text,user_name.Text,password.Text);
            type_of_file = file_Manager_Switch.selected_type(file_source.SelectedIndex);
            list_of_directories.Nodes.Clear();
            List<string> list = type_of_file.list_of_directories(server.Text);
            foreach (string directory in list) 
            { 
                list_of_directories.Nodes.Add(directory);
            }

        }

        private void create_directory_Click(object sender, EventArgs e)
        {
            type_of_file.make_directory(directory_name.Text,server.Text);
            list_of_directories.Nodes.Clear();
            List<string> list = type_of_file.list_of_directories(server.Text);
            foreach (string directory in list)
            {
                list_of_directories.Nodes.Add(directory);
            }
        }

        private void list_of_directories_AfterSelect(object sender, TreeViewEventArgs e)
        {
            delete_selected_directory.Enabled = true;
        }

        private void delete_selected_directory_Click(object sender, EventArgs e)
        {
            /*ftp_functions.delete_directory(list_of_directories.SelectedNode.Text);
            list_of_directories.Nodes.Clear();
            ftp_functions.load_directories(list_of_directories);*/

        }
    }
}
