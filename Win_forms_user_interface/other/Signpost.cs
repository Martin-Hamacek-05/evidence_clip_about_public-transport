using evidence_clip_about_public_transport.Entits;
using evidence_clip_about_public_transport.Other_classes;
using evidence_clip_about_public_transport.Other_classes.Backup_class;
using evidence_clip_about_public_transport.Win_forms_user_interface.Author;
using evidence_clip_about_public_transport.Win_forms_user_interface.for_author;
using evidence_clip_about_public_transport.Win_forms_user_interface.for_formats;
using evidence_clip_about_public_transport.Win_forms_user_interface.for_lines;
using evidence_clip_about_public_transport.Win_forms_user_interface.for_mean_of_transport;
using evidence_clip_about_public_transport.Win_forms_user_interface.for_owner;
using evidence_clip_about_public_transport.Win_forms_user_interface.for_pattern;
using evidence_clip_about_public_transport.Win_forms_user_interface.for_producer;
using evidence_clip_about_public_transport.Win_forms_user_interface.for_stops;
using evidence_clip_about_public_transport.Win_forms_user_interface.for_subtype_mean_of_transport;
using evidence_clip_about_public_transport.Win_forms_user_interface.for_vehicle;
using evidence_clip_about_public_transport.Win_forms_user_interface.other;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
namespace evidence_clip_about_public_transport.Win_forms_user_interface.other
{
    public partial class Signpost : Form
    {
        private evidence_clip_about_public_transport.Entits.Author login_author;
        private Login_popup previours;
        private ImageList imageList;

        public Signpost(Login_popup previours_)
        {
            //ImageList imageList = new ImageList();
            //imageList.Images.Add(imageList.Images[0]);

            InitializeComponent();
            previours = previours_;
            imageList = new ImageList();

            switch ((float)DeviceDpi / 96)
            {
                case 1:
                    imageList.ImageSize = new System.Drawing.Size(16, 16);
                    break;

                default:
                    imageList.ImageSize = new System.Drawing.Size(32, 32);
                    break;
            }

            Thread.Sleep(20);
            imageList.Images.Add("folder", new System.Drawing.Icon("Icon2.ico"));
            imageList.Images.Add("file", new System.Drawing.Icon("Icon4.ico"));
            imageList.Images.Add("file", new System.Drawing.Icon("Icon6.ico"));
            imageList.Images.Add("file", new System.Drawing.Icon("Icon5.ico"));
            imageList.Images.Add("file", new System.Drawing.Icon("Icon7.ico"));
            imageList.Images.Add("file", new System.Drawing.Icon("Icon8.ico"));
            imageList.Images.Add("file", new System.Drawing.Icon("Icon9.ico"));
            imageList.Images.Add("file", new System.Drawing.Icon("Icon10.ico"));
            imageList.Images.Add("file", new System.Drawing.Icon("Icon11.ico"));
            treeView1.ShowPlusMinus = false;
            treeView1.ShowRootLines = false;

            treeView1.ImageList = imageList;

            treeView1.Nodes.Add(edit_clip());
            treeView1.Nodes.Add(new TreeNode("spravovat vozidla", 1, 1, edit_vehicles()));
            treeView1.Nodes.Add(statistic());
            treeView1.Nodes.Add(new TreeNode("filtr", 2, 2));
            treeView1.Nodes.Add(new TreeNode("SQL dotaz", 3, 3));
            treeView1.Nodes.Add(settings());

        }
        public void set_clip(evidence_clip_about_public_transport.Entits.Author author)
        {
            if (author != null)
            {
                login_author = author;
                user_button.Text = author.Login_name;

                if (author.Is_admin)
                {
                    importdata_button_on_top_menu_trip.Enabled = true;
                    exportdata_button_on_top_menu_trip.Enabled = true;
                    accounts_ToolStripMenuItem.Enabled = true;
                    //edit_author_ToolStripMenuItem.Enabled = true;
                }
            }
            else
            {
                this.Close();
            }
        }
        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            //MessageBox.Show(treeView1.SelectedNode.Index.ToString() + ":" + treeView1.SelectedNode.Text);
        }
        private static TreeNode[] edit_vehicles()
        {
            TreeNode[] table_vehicle = { new TreeNode("tabulka vozidla", 0, 0), new TreeNode("tabulka dopravce", 0, 0), new TreeNode("tabulka nátěr", 0, 0), new TreeNode("tabulka výrobce", 0, 0), new TreeNode("tabulka dopravních prostředků", 0, 0), new TreeNode("tabulka podtyp dopravních prostředků", 0, 0) };
            return table_vehicle;
        }
        private static TreeNode edit_clip()
        {
            TreeNode[] table_clip = { new TreeNode("tabulka záběrů", 0, 0), new TreeNode("tabulka zastávek", 0, 0), new TreeNode("tabulka linek", 0, 0), new TreeNode("tabulka formátů") };
            TreeNode root = new TreeNode("spravovat záběry", 1, 1, table_clip);
            //MessageBox.Show(root.Index.ToString());
            return root;
        }
        private static TreeNode statistic()
        {
            TreeNode root = new TreeNode("statistiky", 1, 1, Other_features.list_of_statistics());
            return root;
        }

        private TreeNode settings()
        {

            TreeNode[] settings_ = { new TreeNode("správce úložiště", 7, 7), new TreeNode("nastavení stylopisu", 8, 8) };
            TreeNode root = new TreeNode("nastavení", 6, 6, settings_);
            return root;
        }

        public bool is_admin()
        {
            return login_author.Is_admin == true;
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                if (e.Node.Parent != null && Other_features.load_tree_view(e.Node.Parent.Index, treeView1.SelectedNode.Index) != null)
                {

                    Form embeddedForm = Other_features.load_tree_view(e.Node.Parent.Index, treeView1.SelectedNode.Index);
                    embeddedForm.TopLevel = false;
                    splitContainer1.Panel2.Controls.Add(embeddedForm);
                    embeddedForm.Show();
                }
                else if (e.Node.Parent == null && treeView1.SelectedNode.Index > 2 && treeView1.SelectedNode.Index < 5)
                {

                    Form embeddedForm = Other_features.load_tree_view(treeView1.SelectedNode.Index);
                    embeddedForm.TopLevel = false;
                    splitContainer1.Panel2.Controls.Add(embeddedForm);
                    embeddedForm.Show();
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(treeView1.SelectedNode.Index + "," + treeView1.SelectedNode.Index + "" + exc.ToString());
            }
        }


        private void Signpost_FormClosed(object sender, FormClosedEventArgs e)
        {
            previours.Show();
        }

        private void user_button_Click(object sender, EventArgs e)
        {
            Edit_Author author = new Edit_Author();
            author.set_author(login_author);
            author.Show();
        }
        private void importdata_button_on_top_menu_trip_Click(object sender, EventArgs e)
        {
            Backup_import data = new Backup_import();
            data.Show();
        }
        private void exportdata_button_on_top_menu_trip_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "soubor s oddělovačem *.csv|*.csv|xml soubor *.xml|*.xml";
            saveFileDialog.Title = "vyberte kam vytvořit zálohu";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                switch (saveFileDialog.FilterIndex)
                {
                    case 0:
                        MessageBox.Show("");
                        break;
                    case 1:
                        Backup_to_CSV backup_To_CSV = new Backup_to_CSV();
                        backup_To_CSV.export_data(Path.GetFullPath(saveFileDialog.FileName).Remove(Path.GetFullPath(saveFileDialog.FileName).Length - 4));
                        break;
                    case 2:
                        Backup_to_xml backup_To_Xml = new Backup_to_xml();
                        backup_To_Xml.export_data(Path.GetFullPath(saveFileDialog.FileName).Remove(Path.GetFullPath(saveFileDialog.FileName).Length - 4));
                        break;
                }
            }
            else
            {
                
            }
        }
        private void about_software_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About_software about_software = new About_software();
            about_software.Show();
        }

        private void LoadImageList()
        {


        }

        private void accounts_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show_author author = new Show_author();
            author.Show();
        }
    }
}
