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

        /// <summary>
        /// Genetare backup from table Pattern
        /// </summary>
        /// <returns>list of patterns</returns>
        public List<Pattern> get_all_for_backup();

        /// <summary>
        /// Load backup of Patterns
        /// </summary>
        /// <param name="list">lis tof patterns</param>
        /// <returns>stave</returns>
        public string load_file(List<Pattern> list);
    }
}
