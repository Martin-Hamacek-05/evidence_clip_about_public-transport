using ScottPlot.Statistics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace evidence_clip_about_public_transport.File_manager
{
    public class Load_info_from_file
    {
        private static readonly char blockquote = '"';
        public static string write_info_to_file(string type_of_server,string path,string user_name,string password)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("file_config.config"))
                {
                    writer.WriteLine("<?xml version=" + blockquote + "1.0" + blockquote + " encoding=" + blockquote + "utf-8" + blockquote + " ?>");
                    writer.WriteLine("<configuration>");
                    writer.WriteLine("<file_config>");
                    writer.WriteLine("<type_of_server>" + type_of_server + "</type_of_server>");
                    writer.WriteLine("<path>" + path + "</path>");
                    writer.WriteLine("<user_name>" + user_name + "</user_name>");
                    writer.WriteLine("<password>" + password + "</password>");
                    writer.WriteLine("</file_config>");
                    writer.WriteLine("</configuration>");

                }
                return "Načteno";
            }
            catch (Exception e) 
            {
                return e.Message;
            }
        }

        public static string[] read_info_from()
        {
            try
            {

                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load("file_config.config");

                XmlNodeList type_of_server = xmlDoc.GetElementsByTagName("type_of_server");
                XmlNodeList addresss = xmlDoc.GetElementsByTagName("path");
                XmlNodeList login_name = xmlDoc.GetElementsByTagName("user_name");
                XmlNodeList passwordd = xmlDoc.GetElementsByTagName("password");
                XmlNodeList portt = xmlDoc.GetElementsByTagName("port");

                string[] array = { type_of_server[0].InnerText, addresss[0].InnerText, login_name[0].InnerText, passwordd[0].InnerText};

                return array;

            }
            catch (Exception e) 
            {
                return null;
            }
        }
    }
}
