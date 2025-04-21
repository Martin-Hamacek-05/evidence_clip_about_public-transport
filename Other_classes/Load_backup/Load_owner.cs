using evidence_clip_about_public_transport.DAO;
using evidence_clip_about_public_transport.DAO.mysql.for_formats;
using evidence_clip_about_public_transport.DAO.mysql.for_owner;
using evidence_clip_about_public_transport.Entits;
using evidence_clip_about_public_transport.Other_classes.Backup_class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Author: Martin Hamacek
namespace evidence_clip_about_public_transport.Other_classes.Load_backup
{
    /// <summary>
    /// export data from file to table owner_
    /// </summary>
    public class Load_owner : I_Load_to_database
    {
        public string load_database(string path)
        {
            try
            {
                List<Owner_> lines_to_database_csv = new List<Owner_>();

                StreamReader load_row = new StreamReader(path);
                string row = null;

                while ((row = load_row.ReadLine()) != null&&row.Length >0)
                {
                    Owner_ from_csv = new Owner_();
                    lines_to_database_csv.Add((Owner_)from_csv.from_csv(row));
                }

                I_DAO_Owner i_DAO_Owner_CSV = Database_server_switch.dAO_owner();
                return i_DAO_Owner_CSV.load_file(lines_to_database_csv);
            }
            catch (FormatException exc)
            {
                return "Vybraný soubor není validní";
            }
            catch (Exception exc)
            {
                return "Došlo k neočekavané chybě: \n" + exc.Message;
            }
        }
    }
}
