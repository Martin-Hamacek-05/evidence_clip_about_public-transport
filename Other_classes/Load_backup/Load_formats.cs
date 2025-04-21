using evidence_clip_about_public_transport.DAO;
using evidence_clip_about_public_transport.DAO.mysql.for_formats;
using evidence_clip_about_public_transport.Entits;
using evidence_clip_about_public_transport.Other_classes.Backup_class;
using evidence_clip_about_public_transport.Win_forms_user_interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Author: Martin Hamacek
namespace evidence_clip_about_public_transport.Other_classes.Load_backup
{
    /// <summary>
    /// export data from file to table Formats
    /// </summary>
    public class Load_formats : I_Load_to_database
    {
        public string load_database(string path)
        {
            try
            {
                List<Formats> lines_to_database_csv = new List<Formats>();

                StreamReader load_row = new StreamReader(path);
                string row = null;

                while ((row = load_row.ReadLine()) != null && row.Length>0)
                {
                    Formats from_csv = new Formats();
                    lines_to_database_csv.Add((Formats)from_csv.from_csv(row));
                }

                I_DAO_Formats i_DAO_Format_CSV = Database_server_switch.dAO_Formats();
                return i_DAO_Format_CSV.load_file(lines_to_database_csv);
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
