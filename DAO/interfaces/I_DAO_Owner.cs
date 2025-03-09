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
    /// This interface reprezent the most used functions in database entit: owner
    /// </summary>
    public interface I_DAO_Owner
    {
        /// <summary>
        /// Remove a selected record in table owner
        /// </summary>
        /// <param name="id">id of owner</param>
        /// <returns>is removed</returns>
        public string delete_owner(int id);
        /// <summary>
        /// Load all data from table owner
        /// </summary>
        /// <returns>all loaded data</returns>
        public DataSet get_all_owners();
        /// <summary>
        /// Load a selected record in database table owner
        /// </summary>
        /// <param name="id">id of owner</param>
        /// <returns>selected record</returns>
        public Owner_ get_owner(int id);
        /// <summary>
        /// Edit a exist now record
        /// </summary>
        /// <param name="owner">owner</param>
        /// <returns>is edit</returns>
        public string update_owner(Owner_ owner);
        /// <summary>
        /// Insert a new record to database table owner
        /// </summary>
        /// <param name="owner">owner</param>
        /// <returns>is insert</returns>
        public string new_owner(Owner_ owner);
        /// <summary>
        /// Load a unique names of owners from database table owner
        /// </summary>
        /// <returns>checklist of owner</returns>
        public CheckedListBox get_distict_owners();

        public List<Owner_> get_all_for_backup();
        public string load_file(List<Owner_> lines);
    }
}
