using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* author Martin Hamacek, C4c, 2024/2025*/
namespace evidence_clip_about_public_transport.Other_classes.Backup_class
{
    /// <summary>
    /// Template for class, which export data from file to database
    /// </summary>
    public interface I_Load_to_database
    {
        /// <summary>
        /// Data from file to database
        /// </summary>
        /// <param name="directopy_for_backup">path</param>
        /// <returns>is imported</returns>
        public string load_database(string path);
    }
}
