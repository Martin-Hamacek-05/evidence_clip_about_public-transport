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
    /// This interface reprezent the most used functions in database entit: vehicle
    /// </summary>
    public interface I_DAO_Vehicle
    {
        /// <summary>
        /// Remove a selected record in table vehicle
        /// </summary>
        /// <param name="id">id of vehicle</param>
        /// <returns>is removed</returns>
        public string delete_vehicle(int id);
        /// <summary>
        /// Load all data from table vehicle
        /// </summary>
        /// <returns>all loaded data</returns>
        public DataSet get_all_vehicles();
        /// <summary>
        /// Load a selected record in database table vehicle
        /// </summary>
        /// <param name="id">id of vehicle</param>
        /// <returns>selected record</returns>
        public Vehicle get_vehicle(int id);
        /// <summary>
        /// Edit a exist now record if have not predecessor (self reference is null)
        /// </summary>
        /// <param name="vehicle">vehicle</param>
        /// <returns>is edit</returns>
        public string update_vehicle(Vehicle vehicle);
        /// <summary>
        /// Insert a new record if have not predecessor (self reference is null)
        /// </summary>
        /// <param name="vehicle">vehicle</param>
        /// <returns>is edit</returns>
        public string new_vehicle(Vehicle vehicle);
        /// <summary>
        /// Edit a exist now record if have predecessor (self reference is not null)
        /// </summary>
        /// <param name="vehicle">vehicle</param>
        /// <returns>is edit</returns>
        public string update_vehicle_with_predecessor(Vehicle vehicle);
        /// <summary>
        /// Edit a exist now record if have predecessor (self reference is not null)
        /// </summary>
        /// <param name="vehicle">vehicle</param>
        /// <returns>is inserted</returns>
        public string new_vehicle_with_predecessor(Vehicle vehicle);

        public List<Vehicle> get_all_for_backup();

        public string load_file(List<Vehicle> list);
    }
}
