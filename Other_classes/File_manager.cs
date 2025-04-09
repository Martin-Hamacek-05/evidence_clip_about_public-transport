
using evidence_clip_about_public_transport.File_export_mngr;
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

        private static string filter = 
            "hypetext markup language *.html|*.html|" +
            "textový soubor s oddělovači *.csv|*.csv|" +
            "textový soubor s tabulátorem oddělenými hodnotami *.tsv|*.tsv|" +
            "markdown *.md|*.md|" +
            "javascript object notation *.json|*.json|" +
            "extensible markup language *.xml|*.xml";
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
            saveFileDialog.Filter = filter;
            System.Windows.Forms.TextBox textBox = new System.Windows.Forms.TextBox();
                
            saveFileDialog.Container.Add(textBox);

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Export_switch export_Switch = new Export_switch();
                MessageBox.Show(export_Switch.selected_type_of_file(saveFileDialog.FilterIndex).export_file(data, Path.GetFullPath(saveFileDialog.FileName), header,""));
            }
        }

        public static void export_data_to_other_format(DataGridView data, string header, params string[] hide_columns)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = filter;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Export_switch export_Switch = new Export_switch();
                MessageBox.Show(export_Switch.selected_type_of_file(saveFileDialog.FilterIndex).export_file(data, Path.GetFullPath(saveFileDialog.FileName), header, hide_columns));
            }
        }

       
    }
}