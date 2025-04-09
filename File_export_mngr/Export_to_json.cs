using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Text.Json;


namespace evidence_clip_about_public_transport.File_export_mngr
{
    public class Export_to_json : I_Export_file
    {
        private static readonly char blockquote = '"';

        public string export_file(DataGridView data, string path, string header, params string[] hide_columns)
        {
            try
            {

                string between_data = "[";

                int columnCount = data.Columns.Count;
                List<string> obsah = new List<string>();

                


                foreach (DataGridViewRow row in data.Rows)
                {
                    between_data = between_data + "{\n";
                    for (int i = 0; i < data.Columns.Count; i++)
                    {
                        if (!(data.Columns[i].HeaderText.ToString().Equals("id")))
                        {
                            if (!(data.Columns[i].HeaderText.ToString().Equals(hide_columns[0])))
                            {
                                between_data = between_data + datatype(data.Columns[i].HeaderText.ToString(), row.Cells[i].Value?.ToString(), row.Cells[i].Value.GetType().ToString())+",";
                            }
                        }
                        
                    }
                    between_data = between_data.Remove(between_data.Length - 1);
                    between_data = between_data + "\n";
                    between_data = between_data + "},";
                }
                between_data = between_data.Remove(between_data.Length - 1);
                between_data = between_data + "\n";
                between_data = between_data + "]";

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

        private string datatype(string column, string value, string datatype)
        {
            if (value.Equals("False"))
            {
                return blockquote + column + blockquote + ":false";
            }

            if (value.Equals("True"))
            {
                return blockquote + column + blockquote + ":true";
            }

            if (datatype.Equals("System.DateTime"))
            {
                var parsedDate = DateTime.Parse(value);
                return blockquote + column + blockquote + ":" + JsonSerializer.Serialize(parsedDate);
            }

            if (datatype.Equals("System.String"))
            {
                return blockquote + column + blockquote + ":" + blockquote + value + blockquote;
            }
            else
            {
                return blockquote + column + blockquote + ":" + value;
            }

            
        }
    }
}
