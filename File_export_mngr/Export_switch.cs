using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Author: Martin Hamacek
namespace evidence_clip_about_public_transport.File_export_mngr
{
    /// <summary>
    /// Switcher for types of file to export
    /// </summary>
    public class Export_switch
    {
        /// <summary>
        /// List of types
        /// </summary>
        private List<I_Export_file> types_of_file = new List<I_Export_file>();
        
        /// <summary>
        /// load selected type of file
        /// </summary>
        /// <param name="type">index of list</param>
        /// <returns>selected type of file for rexport</returns>
        public I_Export_file selected_type_of_file(int type) 
        {
            add_to_list();
            return types_of_file[type];
        }

        /// <summary>
        /// add all types of file to list
        /// </summary>
        private void add_to_list() 
        {
            types_of_file.Add(null);
            types_of_file.Add(new Export_to_html());
            types_of_file.Add(new Export_to_csv());
            types_of_file.Add(new Export_to_tsv());
            types_of_file.Add(new Export_to_markdown());
            types_of_file.Add(new Export_to_json());
            types_of_file.Add(new Export_to_xml());
            types_of_file.Add(new Export_to_xml_datatypes());
            types_of_file.Add(new Export_to_excel());
        }
    }
}
