using evidence_clip_about_public_transport.Other_classes;
using MySqlX.XDevAPI.Relational;
using ScottPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
/* author Martin Hamacek, C4c, 2024/2025*/
namespace evidence_clip_about_public_transport.Win_forms_user_interface.other
{
    public partial class Styles_for_html : Form
    {
        private List<string> list_of_loaded_font = new List<string>();

        private List<int> list_of_loaded_sizes_of_font = new List<int>();

        private List<string> list_of_loaded_colours_of_font = new List<string>();

        private List<string> list_of_loaded_colours_of_rows = new List<string>();



        public Styles_for_html()
        {
            InitializeComponent();

            foreach (FontFamily font in System.Drawing.FontFamily.Families)
            {
                list_of_fonts.Items.Add(font.Name);
            }

            Style_manager.load_style(list_of_loaded_font, list_of_loaded_sizes_of_font, list_of_loaded_colours_of_font, list_of_loaded_colours_of_rows);

            Thread.Sleep(1000);
            levels_of_text.SelectedIndex = 0;
            type_of_row.SelectedIndex = 0;

            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load("styles.xml");

                XmlNodeList xml_parse;

                xml_parse = xmlDoc.GetElementsByTagName("background");
                colour_of_background.Text = xml_parse[0].Attributes[0].Value;

                xml_parse = xmlDoc.GetElementsByTagName("border");
                border_of_cell.Value = Convert.ToInt32(xml_parse[0].Attributes[0].Value);
                colour_of_border.Text = xml_parse[0].Attributes[1].Value;

                xml_parse = xmlDoc.GetElementsByTagName("enable_odd_rows");
                if (xml_parse[0].Attributes[0].Value.Equals("false"))
                {
                    differentiate_even_rows.Checked = false;
                }
                else
                {
                    differentiate_even_rows.Checked = true;
                }
            }
            catch (FileNotFoundException fnf) 
            {
                MessageBox.Show("Soubor styles.xml nebyl nalezen");
            }

        }

        private void set_colour_Click(object sender, EventArgs e)
        {
            colour_of_text.Text = Other_features.color_();
        }

        private void set_colour_for_background_Click(object sender, EventArgs e)
        {
            colour_of_background.Text = Other_features.color_();
        }

        private void set_colour_of_row_Click(object sender, EventArgs e)
        {
            colour_of_row.Text = Other_features.color_();
        }

        private void save_Click(object sender, EventArgs e)
        {
            Style_manager.save_style(list_of_loaded_font, list_of_loaded_sizes_of_font, list_of_loaded_colours_of_font, list_of_loaded_colours_of_rows, colour_of_background.Text, (int)border_of_cell.Value, colour_of_border.Text, differentiate_even_rows.Checked);
            MessageBox.Show("Uloženo");
        }

        private void levels_of_text_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                list_of_fonts.SelectedItem = list_of_loaded_font[levels_of_text.SelectedIndex];
                colour_of_text.Text = list_of_loaded_colours_of_font[levels_of_text.SelectedIndex];
                size_of_font.Value = list_of_loaded_sizes_of_font[levels_of_text.SelectedIndex];
            }
            catch (ArgumentOutOfRangeException ex) 
            {
                MessageBox.Show("Zkontrolujte správnost dat v souboru styles.xml");
            }
        }

        private void list_of_fonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            list_of_loaded_font[levels_of_text.SelectedIndex] = list_of_fonts.SelectedItem.ToString();
        }

        private void colour_of_text_TextChanged(object sender, EventArgs e)
        {
            
            list_of_loaded_colours_of_font[levels_of_text.SelectedIndex] = colour_of_text.Text;
        }

        private void size_of_font_ValueChanged(object sender, EventArgs e)
        {
            list_of_loaded_sizes_of_font[levels_of_text.SelectedIndex] = Convert.ToInt32(size_of_font.Value);
        }

        private void type_of_row_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                colour_of_row.Text = list_of_loaded_colours_of_rows[type_of_row.SelectedIndex];
            }
            catch (ArgumentOutOfRangeException ex) 
            {
                MessageBox.Show("Zkontrolujte správnost dat v souboru styles.xml");
            }
        }

        private void colour_of_row_TextChanged(object sender, EventArgs e)
        {
            try 
            {
            list_of_loaded_colours_of_rows[type_of_row.SelectedIndex] = colour_of_row.Text;
            }
            catch (ArgumentOutOfRangeException ex) 
            {
                MessageBox.Show("Zkontrolujte správnost dat v souboru styles.xml");
            }
}

        private void set_colour_for_border_Click(object sender, EventArgs e)
        {
            colour_of_border.Text = Other_features.color_();
        }
    }
}