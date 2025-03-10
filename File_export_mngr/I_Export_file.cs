using Org.BouncyCastle.Bcpg;
using ScottPlot.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evidence_clip_about_public_transport.File_export_mngr
{
    public interface I_Export_file
    {
        public string export_file(DataGridView data, string path, string header, params int[] hide_columns);

        public string export_file_chart(DataGridView data, string path, string header, FormsPlot chart, params int[] hide_columns); 
        
        
    }
}
