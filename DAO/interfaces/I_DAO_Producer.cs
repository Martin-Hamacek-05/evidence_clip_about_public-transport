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
    /// This interface reprezent the most used functions in database entit: producer
    /// </summary>
    public interface I_DAO_Producer
    {

        /// <summary>
        /// Remove a selected record in table producer
        /// </summary>
        /// <param name="id">id of producer</param>
        /// <returns>is removed</returns>
        public string delete_producer(int id);
        /// <summary>
        /// Load all data from table producer
        /// </summary>
        /// <returns>all loaded data</returns>
        public DataSet get_all_producers();
        /// <summary>
        /// Load a selected record in database table producer
        /// </summary>
        /// <param name="id">id of producer</param>
        /// <returns>selected record</returns>
        public Producer get_producer(int id);
        /// <summary>
        /// Edit a exist now record
        /// </summary>
        /// <param name="producer">producer</param>
        /// <returns>is edit</returns>
        public string update_producer(Producer producer);
        /// <summary>
        /// Insert a new record to database table producer
        /// </summary>
        /// <param name="producer">producer</param>
        public string new_producer(Producer producer);
        /// <summary>
        /// Load a unique names of producer from database table producer
        /// </summary>
        /// <returns>checklist of producer</returns>
        public CheckedListBox get_distict_producers();

        public List<Producer> get_all_for_backup();
        public string load_file(List<Producer> list);
    }
}
