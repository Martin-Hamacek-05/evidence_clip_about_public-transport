using evidence_clip_about_public_transport.DAO;
using evidence_clip_about_public_transport.DAO.mysql.for_pattern;
using evidence_clip_about_public_transport.DAO.mysql.for_producer;
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
    /// export data from file to table producer
    /// </summary>
    public class Load_producer : I_Load_to_database
    {
        public string load_database(string path)
        {
            try
            {
                List<Producer> lines_to_database_csv = new List<Producer>();

                StreamReader load_row = new StreamReader(path);
                string row = null;

                while ((row = load_row.ReadLine()) != null&&row.Length>0)
                {
                    Producer from_ = new Producer();
                    lines_to_database_csv.Add((Producer)from_.from_csv(row));
                }


                I_DAO_Producer i_DAO_Line_CSV = Database_server_switch.dAO_producer();
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
