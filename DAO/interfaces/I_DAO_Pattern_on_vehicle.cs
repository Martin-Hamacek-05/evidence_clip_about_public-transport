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
    /// This interface reprezent the most used functions in database entit: pattern on vehicle
    /// </summary>
    public interface I_DAO_Pattern_on_vehicle
    {

        /// <summary>
        /// Insert a new record to database table pattern_on_vehicle
        /// </summary>
        /// <param name="pattern_on_vehicle">pattern_on_vehicle</param>
        public string add_pattern_to_vehicle(Pattern_on_vehicle pattern_on_vehicle);
        /// <summary>
        /// Remove a selected record in table pattern on vehicle
        /// </summary>
        /// <param name="id">id of pattern on vehicle</param>
        /// <returns>is removed</returns>
        public string delete_pattern_from_vehicle(int id);
        /// <summary>
        /// Load all data from table pattern on vehicle
        /// </summary>
        /// <returns>all loaded data</returns>
        public DataSet get_all_pattern_from_list(int id);

        /// <summary>
        /// Generate backup for table Pattern_on_vehicle
        /// </summary>
        /// <returns>list of Pattern_on_vehicle</returns>
        public List<Pattern_on_vehicle> get_all_for_backup();

        /// <summary>
        /// Load backup of table Pattern_on_vehicle
        /// </summary>
        /// <param name="list">list of Pattern_on_vehicle</param>
        /// <returns>stave</returns>
        public string load_file(List<Pattern_on_vehicle> list);
    }
}
