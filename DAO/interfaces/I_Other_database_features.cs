using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evidence_clip_about_public_transport.DAO.mysql.other_features
{
    public interface I_Other_database_features
    {
        public string vehicles_on_clip(int id);

        public void patterns_on_vehicle(int id, ListBox patterns);

        public List<CheckedListBox> parameters_for_filter();

        public DataSet load_stored_procedure(string name_of_procedure, string year);

    }
}
