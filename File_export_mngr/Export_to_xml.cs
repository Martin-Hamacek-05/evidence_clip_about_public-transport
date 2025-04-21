using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml;
//Author: Martin Hamacek
namespace evidence_clip_about_public_transport.File_export_mngr
{
    /// <summary>
    /// Convert selected data to xml file
    /// </summary>
    public class Export_to_xml : I_Export_file
    {
        private static readonly char blockquote = '"';

        public string export_file(DataGridView data, string path, string header, params string[] hide_columns)
        {
            try
            {

                string between_data = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>\n<export_data header='" + header+"'>\n";

                int columnCount = data.Columns.Count;
                List<string> obsah = new List<string>();

                foreach (DataGridViewRow row in data.Rows)
                {
                    between_data = between_data + "<object>\n";
                    for (int i = 0; i < data.Columns.Count; i++)
                    {
                        if (!(data.Columns[i].HeaderText.ToString().Equals("id")))
                        {
                            if (!(data.Columns[i].HeaderText.ToString().Equals(hide_columns[0])))
                            {
                                between_data = between_data + datatype(data.Columns[i].HeaderText.ToString(), row.Cells[i].Value?.ToString(), row.Cells[i].Value.GetType().ToString()) + "\n";
                            }
                        }

                    }
                    between_data = between_data + "\n";
                    between_data = between_data + "</object>\n";
                }
                between_data = between_data + "</export_data>";

                using (StreamWriter writer = new StreamWriter(path))
                {
                    writer.WriteLine(between_data);
                    return "Hotovo";
                }

            }
            catch (FileNotFoundException exc)
            {
                return "Soubor styles.xml nebyl nalezen";
            }
            catch (XmlException exc)
            {
                return "Soubor styles.xml je poškozen.";
            }
            catch (Exception exc)
            {
                return "Došlo k neočekavané chybě:\n" + exc.Message;
            }
        }

        /// <summary>
        /// replace form of datatype to valid version
        /// </summary>
        /// <param name="column">name of column</param>
        /// <param name="value">value</param>
        /// <param name="datatype">datatapy</param>
        /// <returns>valid string</returns>
        private string datatype(string column, string value, string datatype)
        {
            string diaritics = "áćéíĺńóŕśúýźčďěľňřšťžůäïëöüÿÁĆÉÍĹŃÓŔŚÚÝŹČĎĚĽŇŘŠŤŽŮÄÏËÖÜŸ";

            string with_out_diaritics = "aceilnorsuyzcdelnrstzuaieouyACEILNORSUYZCDELNRSTZUAIEOUY";

            string between_string = column;
            between_string = between_string.Replace(' ', '_');
            between_string = between_string.Replace('/', '_');

            for (int i = 0; i < diaritics.Length; i++) 
            {
                between_string = between_string.Replace(diaritics[i], with_out_diaritics[i]);
            }

            return "<" + between_string + ">"+value+"</"+ between_string + ">";
        }
    }
}
