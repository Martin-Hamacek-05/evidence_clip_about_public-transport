using Org.BouncyCastle.Bcpg;
using ScottPlot.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Author: Martin Hamacek
namespace evidence_clip_about_public_transport.File_export_mngr
{
    /// <summary>
    /// Convert data to specific types of file
    /// </summary>
    public interface I_Export_file
    {
        /// <summary>
        /// convert datagridview to file
        /// </summary>
        /// <param name="data"></param>
        /// <param name="path"></param>
        /// <param name="header"></param>
        /// <param name="hide_columns">list of hide colums</param>
        /// <returns>stave</returns>
        public string export_file(DataGridView data, string path, string header, params string[] hide_columns);
        
    }
}
