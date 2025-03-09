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
    /// This interface reprezent the most used functions in database entit: clip
    /// </summary>
    public interface I_DAO_Clip
    {

        /// <summary>
        /// Insert a new record to table clip
        /// </summary>
        /// <param name="clip">new clip</param>
        /// <param name="list_id_of_vehicles">list of id for vehicles on clip</param>
        /// <returns></returns>
        public string new_clip(Clip clip, List<int> list_id_of_vehicles);
        /// <summary>
        /// Remove selected record from table clip
        /// </summary>
        /// <param name="id">id of clip</param>
        /// <returns></returns>
        public string delete_clip(int id);
        /// <summary>
        /// Edit the exist now record in table clip
        /// </summary>
        /// <param name="clip">replace clip</param>
        /// <returns></returns>
        public string update_clip(Clip clip);

        /// <summary>
        /// Load all data from table clip from selected year
        /// </summary>
        /// <param name="year">selected year</param>
        /// <returns>loaded data from database view clip</returns>
        public DataSet get_all_clip_from_year(int year);
        /// <summary>
        /// This 
        /// </summary>
        /// <returns></returns>
        public DataSet get_all_clip_for_filter();
        /// <summary>
        /// This method is used for load the clip
        /// </summary>
        /// <param name="id">id of clip</param>
        /// <returns>loaded clip</returns>
        public Clip get_clip(int id);

        public List<Clip> get_all_for_backup();
        public string load_file(List<Clip> list);

    }
}
