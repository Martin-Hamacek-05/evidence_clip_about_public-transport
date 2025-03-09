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
using System.Xml;
using System.Xml.Schema;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
/* author Martin Hamacek, C4c, 2024/2025*/
namespace evidence_clip_about_public_transport.Win_forms_user_interface.other
{
    public partial class Database_set_connection : Form
    {
        private readonly char blockquote = '"';
        public Database_set_connection()
        {
            InitializeComponent();
            server_switch.SelectedIndex = Database_server_switch.stave_from_file();
            try
            {
                XmlDocument xmlDoc = new XmlDocument(); 
                xmlDoc.Load("database.config"); 

                XmlNodeList addresss = xmlDoc.GetElementsByTagName("adress"); 
                XmlNodeList databasse = xmlDoc.GetElementsByTagName("database"); 
                XmlNodeList login_name = xmlDoc.GetElementsByTagName("user_name");
                XmlNodeList passwordd = xmlDoc.GetElementsByTagName("password");
                XmlNodeList portt = xmlDoc.GetElementsByTagName("port");

                server.Text = addresss[0].InnerText;
                database.Text = databasse[0].InnerText;
                user_name.Text = login_name[0].InnerText;
                password.Text = passwordd[0].InnerText;
                port.Text = portt[0].InnerText;
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("soubor database.config nebyl nalezen");
            }
            catch (XmlException)
            {
                MessageBox.Show("soubor database.config je poškozen");
            }
            catch (Exception exc) 
            { 
                MessageBox.Show("Došlo k neočekavané chybě:\n"+exc.Message);
            }
        }
        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("database.config"))
                {
                    writer.WriteLine("<?xml version=" + blockquote + "1.0" + blockquote + " encoding=" + blockquote + "utf-8" + blockquote + " ?>");
                    writer.WriteLine("<configuration>");
                    writer.WriteLine("<database_connection>");
                    writer.WriteLine("<type_of_database>" + server_switch.SelectedIndex + "</type_of_database>");
                    writer.WriteLine("<adress>" + server.Text + "</adress>");
                    writer.WriteLine("<port>" + port.Text + "</port>");
                    writer.WriteLine("<database>" + database.Text + "</database>");
                    writer.WriteLine("<user_name>" + user_name.Text + "</user_name>");
                    writer.WriteLine("<password>" + password.Text + "</password>");
                    writer.WriteLine("<other>" + other.Text + "</other>");
                    writer.WriteLine("</database_connection>");
                    writer.WriteLine("</configuration>");
                }
                MessageBox.Show("Nastaveno", "Informace", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString(), "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}