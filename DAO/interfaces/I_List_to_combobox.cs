using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evidence_clip_about_public_transport.DAO.mysql.other_features
{
    public interface I_List_to_combobox
    {
        public void selects_I(string sql_querry, string value_, string id, ComboBox combobox);

        public void selects_II(string sql_querry, string value_, string id, ComboBox combobox);

        public void selects_III(string sql_querry, string value_, ComboBox combobox);

        public void yers_to_combobox(string query, ToolStripComboBox combobox);
    }
}
