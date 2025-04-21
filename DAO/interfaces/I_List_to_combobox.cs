using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* author: Martin Hamacek */
namespace evidence_clip_about_public_transport.DAO.mysql.other_features
{
    /// <summary>
    /// Interface for better work with combobox
    /// </summary>
    public interface I_List_to_combobox
    {
        /// <summary>
        /// Fill combobox of data from other table
        /// </summary>
        /// <param name="sql_querry"></param>
        /// <param name="value_"></param>
        /// <param name="id"></param>
        /// <param name="combobox"></param>
        public void selects_I(string sql_querry, string value_, string id, ComboBox combobox);

        /// <summary>
        /// Fill combobox of data from other table with custom labels
        /// </summary>
        /// <param name="sql_querry"></param>
        /// <param name="value_"></param>
        /// <param name="id"></param>
        /// <param name="combobox"></param>
        public void selects_II(string sql_querry, string value_, string id, ComboBox combobox);

        /// <summary>
        /// Fill combobox of data from other table with out ID
        /// </summary>
        /// <param name="sql_querry"></param>
        /// <param name="value_"></param>
        /// <param name="combobox"></param>
        public void selects_III(string sql_querry, string value_, ComboBox combobox);

        /// <summary>
        /// Fill combobox of years in the table clip
        /// </summary>
        /// <param name="query"></param>
        /// <param name="combobox"></param>
        public void yers_to_combobox(string query, ToolStripComboBox combobox);
    }
}
