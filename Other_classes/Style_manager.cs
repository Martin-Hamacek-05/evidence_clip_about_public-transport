using ScottPlot.Statistics;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
/* author Martin Hamacek, C4c, 2024/2025*/
namespace evidence_clip_about_public_transport.Other_classes
{
    public class Style_manager
    {
        private static readonly char blockquote = '"';
        /// <summary>
        /// Load file styles.xml
        /// </summary>
        /// <param name="fonts"></param>
        /// <param name="size_fonts"></param>
        /// <param name="color_of_font"></param>
        /// <param name="color_of_row"></param>
        public static void load_style(List<string> fonts, List<int> size_fonts, List<string> color_of_font, List<string> color_of_row) 
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load("styles.xml");

                XmlNodeList xml_parse = xmlDoc.GetElementsByTagName("font");

                for (int i = 0; i < 5; i++)
                {
                    fonts.Add(xml_parse[i].Attributes[3].Value);
                }

                for (int i = 0; i < 5; i++)
                {
                    size_fonts.Add(Int32.Parse(xml_parse[i].Attributes[1].Value));
                }

                for (int i = 0; i < 5; i++)
                {
                    color_of_font.Add(xml_parse[i].Attributes[2].Value);
                }

                xml_parse = xmlDoc.GetElementsByTagName("row");

                for (int i = 0; i < 3; i++)
                {
                    color_of_row.Add(xml_parse[i].Attributes[1].Value);
                }
            }
            catch(FileNotFoundException exc) 
            {
                MessageBox.Show("Soubor styles.xml nebyl nalezen");
            }
            catch (XmlException exc)
            {
                MessageBox.Show("Soubor database.config je poškozen.", "Problém se souborem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// save style to styles.xml
        /// </summary>
        /// <param name="list_of_loaded_font"></param>
        /// <param name="list_of_sizes_of_font"></param>
        /// <param name="list_of_colours_of_font"></param>
        /// <param name="list_of_loaded_colours_of_rows"></param>
        /// <param name="color_of_background"></param>
        /// <param name="size_of_border"></param>
        /// <param name="color_of_border"></param>
        /// <param name="enable_odd_rows"></param>
        public static void save_style(List<string> list_of_loaded_font, List<int> list_of_sizes_of_font, List<string> list_of_colours_of_font, List<string> list_of_loaded_colours_of_rows,string color_of_background,int size_of_border,string color_of_border,bool enable_odd_rows,int page_type,int orientation,decimal width,decimal height,int units) 
        {
            string[] levels_of_fonts = { "normal","header","odd","even","header_of_table"};
            try
            {
                using (StreamWriter writer = new StreamWriter("styles.xml"))
                {
                    writer.WriteLine("<?xml version=" + blockquote + "1.0" + blockquote + " encoding=" + blockquote + "utf-8" + blockquote + " ?>");
                    writer.WriteLine("<style>");
                    writer.WriteLine("<levels_of_font>");
                    for (int i = 0; i < list_of_loaded_font.Count; i++)
                    {
                        writer.WriteLine("<font level=" + blockquote + levels_of_fonts[i] + blockquote + " size=" + blockquote + list_of_sizes_of_font[i] + blockquote + " color=" + blockquote + list_of_colours_of_font[i] + blockquote + " name_of_font=" + blockquote + list_of_loaded_font[i] + blockquote + " />");
                    }
                    writer.WriteLine("</levels_of_font>");
                    writer.WriteLine("<levels_of_rows>");
                    for (int i = 0; i < list_of_loaded_colours_of_rows.Count; i++)
                    {
                        writer.WriteLine("<row level=" + blockquote + levels_of_fonts[i + 1] + blockquote + " color=" + blockquote + list_of_loaded_colours_of_rows[i] + blockquote + " />");
                    }

                    writer.WriteLine("</levels_of_rows>");
                    writer.WriteLine("<background color=" + blockquote + color_of_background + blockquote + " />");
                    writer.WriteLine("<border size=" + blockquote + size_of_border + blockquote + " color=" + blockquote + color_of_border + blockquote + " />");

                    if (enable_odd_rows == true)
                    {
                        writer.WriteLine("<enable_odd_rows set=" + blockquote + "true" + blockquote + " />");
                    }
                    else
                    {
                        writer.WriteLine("<enable_odd_rows set=" + blockquote + "false" + blockquote + " />");
                    }


                    writer.WriteLine("<pagestyle size="+blockquote+ page_type+blockquote+" orientation="+blockquote+orientation+blockquote+" width=" + blockquote + width + blockquote + " height=" + blockquote + height + blockquote + " units=" + blockquote + units + blockquote + "/>");
                    writer.WriteLine("</style>");
                }
            }
            catch (Exception e) 
            {
                MessageBox.Show("Došlo k neočekavané chybě:\n" + e.Message);
            }
        }
    }
}
