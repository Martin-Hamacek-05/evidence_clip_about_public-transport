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
    /// This interface reprezent the most used functions in database entit: pattern
    /// </summary>
    public interface I_DAO_Pattern
    {

        /// <summary>
        /// Remove a selected record in table pattern
        /// </summary>
        /// <param name="id">id of pattern</param>
        /// <returns>is removed</returns>

        public string delete_pattern(int id);

        /// <summary>
        /// Load all data from table pattern
        /// </summary>
        /// <returns>all loaded data</returns>
        public DataSet get_all_patterns();
        /// <summary>
        /// Load a selected record in database table pattern
        /// </summary>
        /// <param name="id">id of pattern</param>
        /// <returns>selected record</returns>
        public Pattern get_pattern(int id);

        /// <summary>
        /// Edit a exist now record
        /// </summary>
        /// <param name="pattern">pattern</param>
        /// <returns>is edit</returns>
        public string update_pattern(Pattern pattern);
        /// <summary>
        /// Insert a new pattern to database table pattern
        /// </summary>
        /// <param name="pattern">pattern</param>
        public string new_pattern(Pattern pattern);

        public List<Pattern> get_all_for_backup();

        public string load_file(List<Pattern> list);
    }
}
