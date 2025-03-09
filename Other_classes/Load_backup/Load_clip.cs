using evidence_clip_about_public_transport.DAO;
using evidence_clip_about_public_transport.DAO.mysql.for_author;
using evidence_clip_about_public_transport.DAO.mysql.for_clip;
using evidence_clip_about_public_transport.Entits;
using evidence_clip_about_public_transport.Other_classes.Backup_class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evidence_clip_about_public_transport.Other_classes.Load_backup
{
    public class Load_clip: I_Load_to_database
    {
        public string load_database(string path)
        {
            try
            {
                List<Clip> lines_to_database_csv = new List<Clip>();

                StreamReader load_row = new StreamReader(path);
                string row = null;

                while ((row = load_row.ReadLine()) != null&&row.Length>0)
                {
                    Clip from_ = new Clip();
                    lines_to_database_csv.Add((Clip)from_.from_csv(row));
                }


                I_DAO_Clip i_DAO_Line_CSV = Database_server_switch.dAO_Clips();
                return i_DAO_Line_CSV.load_file(lines_to_database_csv);
            }
            catch (FormatException exc)
            {
                return "Vybraný soubor není validní"/*+exc.Message*/;
            }
            catch (Exception exc)
            {
                return "Došlo k neočekavané chybě: \n" + exc.Message;
            }
        }
    }
}
