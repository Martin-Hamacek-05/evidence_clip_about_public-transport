using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace evidence_clip_about_public_transport.Work_with_ftp
{
    public class ftp_connection
    {
        public static ftp_connection_object ftp_connect()
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load("ftp_connect.xml");

                XmlNodeList server = xmlDoc.GetElementsByTagName("server");
                XmlNodeList user_name = xmlDoc.GetElementsByTagName("user_name");
                XmlNodeList password = xmlDoc.GetElementsByTagName("password");

                return new ftp_connection_object(server[0].InnerText, new NetworkCredential(user_name[0].InnerText, password[0].InnerText));
            }
            catch (Exception exc) 
            {
                return null;
            }
            
        }
    }
}
