using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* author Martin Hamacek, C4c*/
namespace evidence_clip_about_public_transport.Other_classes.Backup_class
{
    /// <summary>
    /// Template for class, which export data from database to file
    /// </summary>
    public interface I_Backup
    {
        /// <summary>
        /// Data from database to file
        /// </summary>
        /// <param name="directopy_for_backup">path</param>
        /// <returns>is exported</returns>
        public string export_data(string directopy_for_backup);
    }
}
