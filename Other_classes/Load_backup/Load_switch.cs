using evidence_clip_about_public_transport.Other_classes.Backup_class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Author: Martin Hamacek
namespace evidence_clip_about_public_transport.Other_classes.Load_backup
{
    /// <summary>
    /// Switchet for loaded tables to database
    /// </summary>
    public class Load_switch
    {
        /// <summary>
        /// list of tables
        /// </summary>
        private List<I_Load_to_database>load_to_database = new List<I_Load_to_database>();

        /// <summary>
        /// Add table to list
        /// </summary>
        /// <param name="table"></param>
        public void add_to_list(I_Load_to_database table) 
        {
            load_to_database.Add(table);
        }

        /// <summary>
        /// load data to selected table
        /// </summary>
        /// <param name="index">index</param>
        /// <returns>table for import</returns>
        public I_Load_to_database get_from_list(int index) 
        { 
            return load_to_database[index];
        }

    }
}
