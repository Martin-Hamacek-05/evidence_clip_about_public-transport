using evidence_clip_about_public_transport.Database_connection;
using evidence_clip_about_public_transport.Entits;
using MySql.Data.MySqlClient;
using ScottPlot.Colormaps;
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
    /// This interface reprezent the most used functions in database entit: stop_
    /// </summary>
    public interface I_DAO_Stop
    {
        /// <summary>
        /// Remove a selected record in table stop
        /// </summary>
        /// <param name="id">id of stop</param>
        /// <returns>is removed</returns>

        public string delete_stop(int id);
        /// <summary>
        /// Load all data from table stop
        /// </summary>
        /// <returns>all loaded data</returns>
        public DataSet get_all_stops();
        /// <summary>
        /// Load a selected record in database table stop
        /// </summary>
        /// <param name="id">id of stop</param>
        /// <returns>selected record</returns>
        public Stop_ get_stop(int id);

        /// <summary>
        /// Edit a exist now record
        /// </summary>
        /// <param name="stop">stop</param>
        /// <returns>is edit</returns>
        public string update_stop(Stop_ stop);
        /// <summary>
        /// Insert a new record to database table stop
        /// </summary>
        /// <param name="stop">owner</param>
        public string new_stop(Stop_ stop);
        /// <summary>
        /// Load a unique names of owners from database table stop
        /// </summary>
        /// <returns>checklist of stops</returns>
        public CheckedListBox get_distict_stop();
        /// <summary>
        /// Load unjoined data from database table stop to file
        /// </summary>
        /// <returns>list of loaded stops</returns>
        public List<Stop_> get_all_for_backup();
        /// <summary>
        /// Change name of all platform on selected stop
        /// </summary>
        /// <param name="previours_name">previours name</param>
        /// <param name="new_name">new name</param>
        /// <returns>list of stops</returns>
        public string mass_rename_stop(string previours_name, string new_name);
        /// <summary>
        /// Load unjoined data from file to database table stops
        /// </summary>
        /// <param name="stops">list of stops</param>
        /// <returns>is loaded</returns>

        public string load_file(List<Stop_> stops);


    }
}
