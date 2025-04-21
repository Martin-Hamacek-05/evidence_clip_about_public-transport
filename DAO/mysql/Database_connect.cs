using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using evidence_clip_about_public_transport.exceptions;
using System.Xml;
/* author Martin Hamacek*/
namespace evidence_clip_about_public_transport.Database_connection
{
    /// <summary>
    /// Is used for connect to MySQL database
    /// </summary>
    public class Database_connect
    {
        private static MySqlConnection conn;

        /// <summary>
        /// This class load config of coneection to database from file
        /// </summary>
        /// <returns>connection string</returns>
        public static string connection_string()
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load("database.config"); 

                XmlNodeList addresss = xmlDoc.GetElementsByTagName("adress");
                XmlNodeList port = xmlDoc.GetElementsByTagName("port");
                XmlNodeList databaze = xmlDoc.GetElementsByTagName("database");
                XmlNodeList uzivjm = xmlDoc.GetElementsByTagName("user_name");
                XmlNodeList heslo = xmlDoc.GetElementsByTagName("password");
                XmlNodeList otherr = xmlDoc.GetElementsByTagName("other");

                return "server=" + addresss[0].InnerText + ";database=" + databaze[0].InnerText + ";port=" + port[0].InnerText + ";uid=" + uzivjm[0].InnerText + ";pwd=" + heslo[0].InnerText + ";" + otherr[0].InnerText;
            }
            catch(FileNotFoundException exc) 
            {
                return "Soubor database.config nebyl nalezen";
            }
            catch (XmlException exc)
            {
                MessageBox.Show("Soubor database.config je poškozen.", "Problém se souborem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Došlo k neočekavané chybě:\n" + exc.Message);
                return null;
            }
        }

        /// <summary>
        /// Provided connection to MySQL database
        /// </summary>
        /// <returns>MySQLConnection</returns>
        public static MySqlConnection myssql_connection()
        {
            try
            {
                return conn = new MySqlConnection(connection_string());
            }
            catch (MySqlException exc)
            {
                Work_with_expection.sql_exception_of_code(exc.Number);
                return null;
            }
            catch (ArgumentException exc)
            {
                MessageBox.Show("Nejde pracovat s databází", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Někde se stala chyba" + exc.ToString(), "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        
    }
}
