using evidence_clip_about_public_transport.Entits;
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
    /// This interface reprezent the most used functions in database entit: Mean_of_transport
    /// </summary>
    public interface I_DAO_Mean_of_transport
    {
        /// <summary>
        /// Remove a selected record from database table Mean_of_transport
        /// </summary>
        /// <param name="id">id of mean of transport</param>
        /// <returns>is removed</returns>
        public string delete_mean_of_transport(int id);
        /// <summary>
        /// Load data from database table mean of transport
        /// </summary>
        /// <returns>all data</returns>
        public DataSet get_all_mean_of_transport();
        /// <summary>
        /// Load a selected record from database table mean of transport
        /// </summary>
        /// <param name="id">id of record</param>
        /// <returns>selected record</returns>
        public Mean_of_transport get_mean_of_transport(int id);
        /// <summary>
        /// Loaded a unique name mean of public transport from database table mean of transport
        /// </summary>
        /// <returns>checklist for filter</returns>
        public CheckedListBox get_distict_mean_of_public_transport();
        /// <summary>
        /// Edit a exist now record in database table mean of transport
        /// </summary>
        /// <param name="mean_of_transport">mean of transport</param>
        /// <returns>is edit</returns>
        public string update_mean_of_transport(Mean_of_transport mean_of_transport);
        /// <summary>
        /// Insert a new record to database table mean of transport
        /// </summary>
        /// <param name="mean_of_transport">mean of transport</param>
        /// <returns>is inserted</returns>
        public string new_mean_of_transport(Mean_of_transport mean_of_transport);

        /// <summary>
        /// Generate backup from table Mean_of_transport
        /// </summary>
        /// <returns>list of Means_of_transport</returns>
        public List<Mean_of_transport> get_all_for_backup();

        /// <summary>
        /// Load backup of Mean of transport
        /// </summary>
        /// <param name="lines">list for recovery</param>
        /// <returns>stave</returns>
        public string load_file(List<Mean_of_transport> lines);
    }
}
