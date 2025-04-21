using ScottPlot.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
//Author: Martin Hamacek
namespace evidence_clip_about_public_transport.File_export_mngr
{
    /// <summary>
    /// Convert selected data to CSV file
    /// </summary>
    public class Export_to_csv : I_Export_file
    {
        public string export_file(DataGridView data, string path, string header, params string[] hide_columns)
        {
            try
            {
               string between_data_II = "";
                int columnCount = data.Columns.Count;
                List<string> obsah = new List<string>();

                int count_ = 0;
                foreach (DataGridViewRow row in data.Rows)
                {
                    for (int i = 0; i < data.Columns.Count; i++)
                    {
                        if (!(data.Columns[i].HeaderText.ToString().Equals("id")))
                        {
                            if (!(data.Columns[i].HeaderText.ToString().Equals(hide_columns[0])))
                            {
                                between_data_II = between_data_II + row.Cells[i].Value?.ToString() + ";";
                            }
                        }
                    }
                    between_data_II = between_data_II.Remove(between_data_II.Length - 1) + "\n";
                    count_++;
                }

                char uvozovka = '"';

                using (StreamWriter writer = new StreamWriter(path))
                {
                    writer.WriteLine(between_data_II);
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
    }
}
