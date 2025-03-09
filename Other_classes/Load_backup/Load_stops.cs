using evidence_clip_about_public_transport.DAO;
using evidence_clip_about_public_transport.DAO.mysql.for_line;
using evidence_clip_about_public_transport.DAO.mysql.for_stop;
using evidence_clip_about_public_transport.Entits;
using evidence_clip_about_public_transport.Other_classes.Backup_class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
/* author Martin Hamacek, C4c, 2024/2025*/
namespace evidence_clip_about_public_transport.Other_classes.Load_backup
{
    /// <summary>
    /// load data of stops from file to database
    /// </summary>
    public class Load_stops : I_Load_to_database
    {
        public string load_database(string path)
        {
            throw new NotSupportedException();
        }
    }
}
