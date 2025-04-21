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
    /// Convert selected data to html file
    /// </summary>
    public class Export_to_html : I_Export_file
    {
        public string export_file(DataGridView data, string path, string header, params string[] hide_columns)
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load("styles.xml");

                XmlNodeList xml_parse_fonts = xmlDoc.GetElementsByTagName("font");
                XmlNodeList xml_parse_rows = xmlDoc.GetElementsByTagName("font");
                XmlNodeList xml_parse_background = xmlDoc.GetElementsByTagName("background");
                XmlNodeList xml_parse_border = xmlDoc.GetElementsByTagName("border");
                XmlNodeList xml_parse_levels_of_rows = xmlDoc.GetElementsByTagName("row");
                XmlNodeList xml_parse_enable_odd_rows = xmlDoc.GetElementsByTagName("enable_odd_rows");

                string between_data = "";
                string between_data_II = "";
                int columnCount = data.Columns.Count;
                List<string> obsah = new List<string>();

                for (int i = 0; i < columnCount; i++)
                {
                    
                    if (!(data.Columns[i].HeaderText.ToString().Equals("id")))
                    {
                        if (!(data.Columns[i].HeaderText.ToString().Equals(hide_columns[0]))) 
                        {
                            between_data = between_data + "<th>" + data.Columns[i].HeaderText.ToString() + "</th>";
                        }
                            
                    }

                }

                int count_ = 0;
                foreach (DataGridViewRow row in data.Rows)
                {

                    if (((count_ % 2) == 0))
                    {
                        between_data_II = between_data_II + "<tr class='even'>";
                    }
                    else
                    {
                        between_data_II = between_data_II + "<tr class='odd'>";
                    }

                    for (int i = 0; i < data.Columns.Count; i++)
                    {
                        if (!(data.Columns[i].HeaderText.ToString().Equals("id")))
                        {
                            if (!(data.Columns[i].HeaderText.ToString().Equals(hide_columns[0])))
                            {
                                between_data_II = between_data_II + "<td>" + row.Cells[i].Value?.ToString() + "</td>";
                            }
                        }
                    }
                    between_data_II = between_data_II + "</tr>\n";
                    count_++;
                }

                char uvozovka = '"';

                using (StreamWriter writer = new StreamWriter(path))
                {
                    writer.WriteLine("<!DOCTYPE html>");
                    writer.WriteLine("<html>\n<!-- vygenerováno v programu: evidence záběrů o MHD-->\n<head>\n<style>");

                    writer.WriteLine("body{-webkit-print-color-adjust:exact !important;\r\n  print-color-adjust:exact !important; font-family: " + xml_parse_fonts[0].Attributes[3].InnerText + "; font-size: " + xml_parse_fonts[0].Attributes[1].InnerText + "pt; color: #" + xml_parse_fonts[0].Attributes[2].InnerText + "; background-color: #" + xml_parse_background[0].Attributes[0].InnerText + "}");
                    writer.WriteLine("h1{ font-size: " + xml_parse_fonts[1].Attributes[1].InnerText + "pt; color: #" + xml_parse_fonts[1].Attributes[2].InnerText + "; font-family: " + xml_parse_fonts[1].Attributes[3].InnerText + ";}");
                    writer.WriteLine("table{border: " + xml_parse_border[0].Attributes[0].InnerText + "px solid #" + xml_parse_border[0].Attributes[1].InnerText + "; border-collapse: collapse;background-color:#" + xml_parse_levels_of_rows[0].Attributes[1].InnerText + ";}");
                    writer.WriteLine("th{border: " + xml_parse_border[0].Attributes[0].InnerText + "px solid #" + xml_parse_border[0].Attributes[1].InnerText + "; border-collapse: collapse;background-color:#" + xml_parse_levels_of_rows[0].Attributes[1].InnerText + "; color: #" + xml_parse_fonts[4].Attributes[2].InnerText + ";}");
                    writer.WriteLine("td{border: " + xml_parse_border[0].Attributes[0].InnerText + "px solid #" + xml_parse_border[0].Attributes[1].InnerText + "; border-collapse: collapse;}");
                    writer.WriteLine(".odd{background-color: #" + xml_parse_levels_of_rows[1].Attributes[1].InnerText + "; color: #" + xml_parse_fonts[2].Attributes[2].InnerText + "; font-family: " + xml_parse_fonts[2].Attributes[3].InnerText + "; font-size:" + xml_parse_fonts[2].Attributes[1].InnerText + " pt;}");
                    writer.WriteLine(".even{background-color: #" + xml_parse_levels_of_rows[2].Attributes[1].InnerText + "; color: #" + xml_parse_fonts[3].Attributes[2].InnerText + "; font-family: " + xml_parse_fonts[3].Attributes[3].InnerText + "; font-size:" + xml_parse_fonts[3].Attributes[1].InnerText + "pt;}");
                    writer.WriteLine("</style>");
                    writer.WriteLine("<meta charset=" + uvozovka + "UTF-8" + uvozovka + ">");
                    writer.WriteLine("<title>" + header + "</title>\n</head>\n<body>\n<h1>" + header + "</h1>");

                    writer.WriteLine("<table>");
                    writer.WriteLine(between_data);
                    writer.WriteLine(between_data_II);
                    writer.WriteLine("</table>");
                    writer.WriteLine("</body>");
                    writer.WriteLine("</html>");


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
