using evidence_clip_about_public_transport.Entits;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* author: Martin Hamacek */
namespace evidence_clip_about_public_transport.DAO
{
    /// <summary>
    /// This interface reprezent the most used functions in database entit: Vehicles_on_clip
    /// </summary>
    public interface I_DAO_Vehicles_on_clip
    {

        /// <summary>
        /// Insert a new record to database table Vehicles_on_clip
        /// </summary>
        /// <param name="vehicles_On_Clip">vehicles_On_Clip</param>
        public string add_vehicles_to_clip(Vehicles_on_clip vehicles_On_Clip);
        /// <summary>
        /// Remove a selected record in table Vehicles_on_clip
        /// </summary>
        /// <param name="vehicles_On_Clip">vehicles_On_Clip</param>
        /// <returns>is removed</returns>
        public string delete_vehicle_from_clip(Vehicles_on_clip vehicles_On_Clip);
        /// <summary>
        /// Load all data from table Vehicles_on_clip
        /// </summary>
        /// <returns>all loaded data</returns>
        public DataSet get_all_vehicles_from_list(int id);

        /// <summary>
        /// Generate backup of table Vehicles_on_clip
        /// </summary>
        /// <returns>list of Vehicles_on_clips</returns>
        public List<Vehicles_on_clip> get_all_for_backup();

        /// <summary>
        /// Load backup of table Vehicles_on_clip
        /// </summary>
        /// <param name="list">list of Vehicles_on_clips</param>
        /// <returns>stave</returns>
        public string load_file(List<Vehicles_on_clip> list);
    }
}
