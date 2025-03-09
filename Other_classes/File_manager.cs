
using ScottPlot.WinForms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
/* author Martin Hamacek, C4c, 2024/2025*/
namespace evidence_clip_about_public_transport.Other_classes
{
    /// <summary>
    /// Methods for work with file
    /// </summary>
    public class File_manager
    {
        /// <summary>
        /// Copy file from selected directory to new directory
        /// </summary>
        /// <param name="from_">source</param>
        /// <param name="file">file</param>
        /// <param name="to_">to</param>
        /// <param name="alternative">alternative</param>
        /// <returns></returns>
        public static int copy_file_from_one_location_to_another(string from_, string file, string to_,string alternative) 
        {
            
                File.Copy(from_ + file, to_ + '\\' +alternative+"_"+ file, false);
                return 1;

        }
        /// <summary>
        /// Writer csv string to file
        /// </summary>
        /// <param name="path"></param>
        /// <param name="csv"></param>
        /// <returns></returns>
        public static int export_to_csv(string path,string csv) 
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(path))
                {
                    writer.WriteLine(csv);
                    writer.Close();
                }
                return 1;
            }
            catch (Exception exC) 
            {
                MessageBox.Show("Došlo k neočekavané chybě:\n"+exC.Message);
                return 0;
            }
        }
        /// <summary>
        /// write data from table to file
        /// </summary>
        /// <param name="data">table</param>
        /// <param name="header">header</param>
        public static void export_data_to_other_format(DataGridView data, string header)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "hypetext markup language *.html|*.html";



            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                switch (saveFileDialog.FilterIndex)
                {
                    case 0:
                        break;

                    case 1:
                        File_manager.export_data_from_select_to_html(data, Path.GetFullPath(saveFileDialog.FileName), header,null);
                        break;

                    default:
                        break;

                }
            }
        }

        /// <summary>
        /// write data from table to file with chart
        /// </summary>
        /// <param name="data">table</param>
        /// <param name="header">header</param>
        /// <param name="chart">chart</param>
        public static void export_data_to_other_format_with_chart(DataGridView data, string header,FormsPlot chart)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "hypetext markup language *.html|*.html";



            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                switch (saveFileDialog.FilterIndex)
                {
                    case 0:
                        break;

                    case 1:
                        File_manager.export_data_from_select_to_html(data, Path.GetFullPath(saveFileDialog.FileName), header,chart);
                        break;

                    default:

                        break;

                }
            }
        }

        /// <summary>
        /// write data from table to html file with chart
        /// </summary>
        /// <param name="data">table</param>
        /// <param name="path">path</param>
        /// <param name="header">header</param>
        /// <param name="chart">chart</param>
        private static void export_data_from_select_to_html(DataGridView data,string path,string header,FormsPlot chart) 
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

                if (chart != null)
                {
                    chart.Plot.SavePng(Path.GetFullPath(path).Remove(Path.GetFullPath(path).Length - 5) + "_chart.png", 1920, 1080);
                }

                string between_data = "";
                string between_data_II = "";
                int columnCount = data.Columns.Count;
                List<string> obsah = new List<string>();

                for (int i = 0; i < columnCount; i++)
                {
                    if (!(data.Columns[i].HeaderText.ToString().Equals("id")))
                    {
                        between_data = between_data + "<th>" + data.Columns[i].HeaderText.ToString() + "</th>";
                    }

                }

                int count_ = 0;
                foreach (DataGridViewRow row in data.Rows)
                {

                    if (((count_ % 2) == 0) && xml_parse_enable_odd_rows[0].Attributes[0].InnerText.Equals("true"))
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
                            between_data_II = between_data_II + "<td>" + row.Cells[i].Value?.ToString() + "</td>";
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

                    writer.WriteLine("body{ font-family: " + xml_parse_fonts[0].Attributes[3].InnerText + "; font-size: " + xml_parse_fonts[0].Attributes[1].InnerText + "pt; color: #" + xml_parse_fonts[0].Attributes[2].InnerText + "; background-color: #" + xml_parse_background[0].Attributes[0].InnerText + "}");
                    writer.WriteLine("h1{ font-size: " + xml_parse_fonts[1].Attributes[1].InnerText + "pt; color: #" + xml_parse_fonts[1].Attributes[2].InnerText + "; font-family: " + xml_parse_fonts[1].Attributes[3].InnerText + ";}");
                    writer.WriteLine("table{border: " + xml_parse_border[0].Attributes[0].InnerText + "px solid #" + xml_parse_border[0].Attributes[1].InnerText + "; border-collapse: collapse;background-color:#" + xml_parse_levels_of_rows[0].Attributes[1].InnerText + ";}");
                    writer.WriteLine("th{border: " + xml_parse_border[0].Attributes[0].InnerText + "px solid #" + xml_parse_border[0].Attributes[1].InnerText + "; border-collapse: collapse;background-color:#" + xml_parse_levels_of_rows[0].Attributes[1].InnerText + "; color: #" + xml_parse_fonts[4].Attributes[2].InnerText+";}");
                    writer.WriteLine("td{border: " + xml_parse_border[0].Attributes[0].InnerText + "px solid #" + xml_parse_border[0].Attributes[1].InnerText + "; border-collapse: collapse;}");
                    writer.WriteLine(".odd{background-color: #" + xml_parse_levels_of_rows[1].Attributes[1].InnerText + "; color: #" + xml_parse_fonts[2].Attributes[2].InnerText + "; font-family: " + xml_parse_fonts[2].Attributes[3].InnerText + "; font-size:" + xml_parse_fonts[2].Attributes[1].InnerText + " pt;}");
                    writer.WriteLine(".even{background-color: #" + xml_parse_levels_of_rows[2].Attributes[1].InnerText + "; color: #" + xml_parse_fonts[3].Attributes[2].InnerText + "; font-family: " + xml_parse_fonts[3].Attributes[3].InnerText + "; font-size:" + xml_parse_fonts[3].Attributes[1].InnerText + "pt;}");
                    writer.WriteLine("</style>");
                    writer.WriteLine("<meta charset=" + uvozovka + "UTF-8" + uvozovka + ">");
                    writer.WriteLine("<title>" + header + "</title>\n</head>\n<body>\n<h1>" + header + "</h1>");

                    if (chart != null)
                    {
                        writer.WriteLine("<img style='float:right;width:75%' src='" + Path.GetFullPath(path).Remove(Path.GetFullPath(path).Length - 5) + "_chart.png" + "'>");
                    }

                    writer.WriteLine("<table>");
                    writer.WriteLine(between_data);
                    writer.WriteLine(between_data_II);
                    writer.WriteLine("</table>");
                    writer.WriteLine("</body>");
                    writer.WriteLine("</html>");


                    MessageBox.Show("Hotovo");
                }

            }
            catch (FileNotFoundException exc)
            {
                MessageBox.Show("Soubor styles.xml nebyl nalezen", "Problém se souborem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (XmlException exc)
            {
                MessageBox.Show("Soubor styles.xml je poškozen.", "Problém se souborem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception exc) 
            {
                MessageBox.Show("Došlo k neočekavané chybě:\n" + exc.Message, "Problém se souborem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}