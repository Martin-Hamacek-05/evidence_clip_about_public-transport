using evidence_clip_about_public_transport.DAO;
using evidence_clip_about_public_transport.DAO.mysql.for_pattern_on_vehicle;
using evidence_clip_about_public_transport.DAO.mysql.for_vehicles;
using evidence_clip_about_public_transport.Entits;
using evidence_clip_about_public_transport.Other_classes.Backup_class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evidence_clip_about_public_transport.Other_classes.Load_backup
{
    public class Load_patterns_on_vehicle : I_Load_to_database
    {
        public string load_database(string path)
        {
            try
            {
                List<Pattern_on_vehicle> lines_to_database_csv = new List<Pattern_on_vehicle>();

                StreamReader load_row = new StreamReader(path);
                string row = null;

                while ((row = load_row.ReadLine()) != null && row.Length>0)
                {
                    Pattern_on_vehicle from_csv = new Pattern_on_vehicle();    
                    lines_to_database_csv.Add((Pattern_on_vehicle)from_csv.from_csv(row));
                }

                I_DAO_Pattern_on_vehicle i_DAO_Owner_CSV = Database_server_switch.dAO_Pattern_On_Vehicle();
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
