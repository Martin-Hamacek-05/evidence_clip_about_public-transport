using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using evidence_clip_about_public_transport.DAO.mysql.for_line;
using System.Xml;
using evidence_clip_about_public_transport.Entits;
using evidence_clip_about_public_transport.DAO;

/* author Martin Hamacek*/
namespace evidence_clip_about_public_transport.Other_classes.Backup_class
{
    /// <summary>
    /// load data of lines from file to database
    /// </summary>
    public class Load_lines : I_Load_to_database
    {
        public string load_database(string path)
        {
                    try
                    {
                        List<Line> lines_to_database_csv = new List<Line>();

                        StreamReader load_row = new StreamReader(path);
                        string row = null;

                        while ((row = load_row.ReadLine()) != null && row.Length > 0)
                        {
                            Line from_csv = new Line();
                            lines_to_database_csv.Add((Line)from_csv.from_csv(row));
                        }

                        I_DAO_Line i_DAO_Line_CSV = Database_server_switch.dAO_Line();
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
