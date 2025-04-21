using evidence_clip_about_public_transport.DAO.mysql.for_line;
using evidence_clip_about_public_transport.DAO.mysql.for_stop;
using evidence_clip_about_public_transport.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using evidence_clip_about_public_transport.Entits;
using Mysqlx.Connection;
/* author Martin Hamacek*/
namespace evidence_clip_about_public_transport.Other_classes.Backup_class
{
    /// <summary>
    /// Export data from table line and stop_ to xml file 
    /// </summary>
    public class Backup_to_xml : I_Backup
    {
        public string export_data(string directopy_for_backup)
        {   
            throw new NotSupportedException();
        }

    }
}
