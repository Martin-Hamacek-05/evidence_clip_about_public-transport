using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evidence_clip_about_public_transport.File_export_mngr
{
    public class Export_switch
    {
        private List<I_Export_file> types_of_file = new List<I_Export_file>();
        
        public I_Export_file selected_type_of_file(int type) 
        {
            add_to_list();
            return types_of_file[type];
        }

        private void add_to_list() 
        {
            types_of_file.Add(null);
            types_of_file.Add(new Export_to_html());
            types_of_file.Add(new Export_to_pdf());
        }
    }
}
