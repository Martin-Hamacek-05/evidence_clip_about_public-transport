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
    /// This interface reprezent the most used functions in database entit: line
    /// </summary>
    public interface I_DAO_Line
    {
        /// <summary>
        /// Insert a new record to database table line
        /// </summary>
        /// <param name="line">line</param>
        /// <returns>is inserted</returns>
        public string new_line(Line line);
        /// <summary>
        /// Remove record from table line
        /// </summary>
        /// <param name="id">id of line</param>
        /// <returns>is removed</returns>
        public string delete_line(int id);
        /// <summary>
        /// Edit a exist now record in table line
        /// </summary>
        /// <param name="line">line</param>
        /// <returns>is edit</returns>
        public string update_line(Line line);
        /// <summary>
        /// Load all databa from database table line
        /// </summary>
        /// <returns>list of lines</returns>
        public DataSet get_all_line();
        /// <summary>
        /// Loaded the selected record from database table line
        /// </summary>
        /// <param name="id">if of line</param>
        /// <returns>selected record</returns>
        public Line get_line(int id);
        /// <summary>
        /// Loaded a unique names of lines from table line
        /// </summary>
        /// <returns>checklist of unique line</returns>
        public CheckedListBox get_distict_name_of_lines();
        /// <summary>
        /// Load unjoined data from database table line to file
        /// </summary>
        /// <returns>list of loaded line</returns>
        public List<Line> get_all_for_backup();

        /// <summary>
        /// Load unjoined data from file to database table line
        /// </summary>
        /// <param name="lines">list of lines</param>
        /// <returns>is loaded</returns>
        public string load_file(List<Line> lines);
    }
}
