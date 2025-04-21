using evidence_clip_about_public_transport.Database_connection;
using evidence_clip_about_public_transport.Entits;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* author: Martin Hamacek*/
namespace evidence_clip_about_public_transport.DAO
{
    /// <summary>
    /// This interface reprezent the most used functions in database entit: formats
    /// </summary>
    public interface I_DAO_Formats
    {
        /// <summary>
        /// Insert new record to table formats
        /// </summary>
        /// <param name="format">new Format</param>
        /// <returns>is inserted </returns>
        public string new_format(Formats format);
        /// <summary>
        /// Remove selected record in table formats
        /// </summary>
        /// <param name="id">id of format</param>
        /// <returns>is removed</returns>
        public string delete_format(int id);
        /// <summary>
        /// Edit is exist now record format
        /// </summary>
        /// <param name="format">exist format</param>
        /// <returns>is edited</returns>
        public string update_format(Formats format);
        /// <summary>
        /// Loaded all data from table formats
        /// </summary>
        /// <returns>all data</returns>
        public DataSet get_all_formats();
        /// <summary>
        /// Loaded a selected record from table formats
        /// </summary>
        /// <param name="id">id of format</param>
        /// <returns>Selected format</returns>
        public Formats get_format(int id);
        /// <summary>
        /// Load the unique names from table format for filter
        /// </summary>
        /// <returns>List of unique names in formats</returns>
        public CheckedListBox get_distict_format();

        /// <summary>
        /// Save backup of table backup
        /// </summary>
        /// <returns>list of formats</returns>
        public List<Formats> get_all_for_backup();

        /// <summary>
        /// Load backup of formats
        /// </summary>
        /// <param name="formats">list of formats</param>
        /// <returns>stave</returns>
        public string load_file(List<Formats> formats);

    }
}
