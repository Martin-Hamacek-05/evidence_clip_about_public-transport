using evidence_clip_about_public_transport.Entits;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* author: Martin Hamacek, C4c, 2024/2025 */
namespace evidence_clip_about_public_transport.DAO
{
    /// <summary>
    /// This interface reprezent the most used functions in database entit: subtype mean of transport
    /// </summary>
    public interface I_DAO_Subtype_mean_of_transport
    {
        /// <summary>
        /// Remove a selected record in table subtype mean of transport
        /// </summary>
        /// <param name="id">id of subtype mean of transport</param>
        /// <returns>is removed</returns>
        public string delete_subtype_mean_of_transport(int id);
        /// <summary>
        /// Load all data from table subtype mean of transport
        /// </summary>
        /// <returns>all loaded data</returns>
        public DataSet get_all_subtype_mean_of_transport();
        /// <summary>
        /// Load a selected record in database table subtype mean of transport
        /// </summary>
        /// <param name="id">id of owner</param>
        /// <returns>selected record</returns>
        public Subtype_mean_of_transport get_subtype_mean_of_transport(int id);
        /// <summary>
        /// Edit a exist now record if have not predecessor (self reference is null)
        /// </summary>
        /// <param name="subtype_Mean_Of_Transport">subtype_Mean_Of_Transport</param>
        /// <returns>is edit</returns>
        public string update_subtype_mean_of_transport(Subtype_mean_of_transport subtype_Mean_Of_Transport);
        /// <summary>
        /// Insert a new record if have not predecessor (self reference is null)
        /// </summary>
        /// <param name="subtype_Mean_Of_Transport">subtype_Mean_Of_Transport</param>
        /// <returns>is inserted</returns>
        public string new_subtype_mean_of_transport(Subtype_mean_of_transport subtype_Mean_Of_Transport);
        /// <summary>
        /// Edit a exist now record if have predecessor (self reference is not null)
        /// </summary>
        /// <param name="subtype_Mean_Of_Transport">subtype_Mean_Of_Transport</param>
        /// <returns>is edit</returns>
        public string update_subtype_mean_of_transport_with_predecessor(Subtype_mean_of_transport subtype_Mean_Of_Transport);
        /// <summary>
        /// Insert a new record if have predecessor (self reference is not null)
        /// </summary>
        /// <param name="subtype_Mean_Of_Transport">subtype_Mean_Of_Transport</param>
        /// <returns>is inserted</returns>
        public string new_subtype_mean_of_transport_with_predecessor(Subtype_mean_of_transport subtype_Mean_Of_Transport);
        /// <summary>
        /// Load a unique names of subtypes mean of transport from database table of subtypes mean of transport
        /// </summary>
        /// <returns>checklist of owner</returns>
        public CheckedListBox get_distict_subtype_mean_of_public_transport();

        public List<Subtype_mean_of_transport> get_all_for_backup();

        public string load_file(List<Subtype_mean_of_transport> lines);
    }
}
