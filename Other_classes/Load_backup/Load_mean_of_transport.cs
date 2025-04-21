using evidence_clip_about_public_transport.DAO;
using evidence_clip_about_public_transport.DAO.mysql.for_line;
using evidence_clip_about_public_transport.DAO.mysql.for_mean_of_transport;
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
    /// export data from file to table Mean_of_transport
    /// </summary>
    public class Load_mean_of_transport : I_Load_to_database
    {
        public string load_database(string path)
        {
            try
            {
                List<Mean_of_transport> lines_to_database_csv = new List<Mean_of_transport>();

                StreamReader load_row = new StreamReader(path);
                string row = null;

                while ((row = load_row.ReadLine()) != null && row.Length > 0)
                {
                    Mean_of_transport from_csv = new Mean_of_transport();
                    lines_to_database_csv.Add((Mean_of_transport)from_csv.from_csv(row));
                }

                I_DAO_Mean_of_transport i_DAO_Line_CSV = Database_server_switch.dAO_Mean_Of_Transport();
                return i_DAO_Line_CSV.load_file(lines_to_database_csv);
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
