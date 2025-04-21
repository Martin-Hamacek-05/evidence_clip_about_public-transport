using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* author: Martin Hamacek */
namespace evidence_clip_about_public_transport.DAO.mysql.other_features
{
    /// <summary>
    /// Method for other database features
    /// </summary>
    public interface I_Other_database_features
    {
        /// <summary>
        /// Generate string about list of vehicle on selected clip
        /// </summary>
        /// <param name="id">selected clip</param>
        /// <returns>string</returns>
        public string vehicles_on_clip(int id);

        /// <summary>
        /// Set list of patterns of vehicle on selected vehicle
        /// </summary>
        /// <param name="id"></param>
        /// <param name="patterns"></param>
        public void patterns_on_vehicle(int id, ListBox patterns);

        /// <summary>
        /// Set filter propeties
        /// </summary>
        /// <returns>List of CheckedListBox</returns>
        public List<CheckedListBox> parameters_for_filter();

        /// <summary>
        /// Load of stored prodecure, witch have a parameter year
        /// </summary>
        /// <param name="name_of_procedure"></param>
        /// <param name="year"></param>
        /// <returns>table</returns>
        public DataSet load_stored_procedure(string name_of_procedure, string year);

    }
}
