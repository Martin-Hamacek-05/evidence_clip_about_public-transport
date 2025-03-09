using evidence_clip_about_public_transport.Other_classes.Backup_class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evidence_clip_about_public_transport.Other_classes.Load_backup
{
    public class Load_switch
    {
        private List<I_Load_to_database>load_to_database = new List<I_Load_to_database>();

        public void add_to_list(I_Load_to_database table) 
        {
            load_to_database.Add(table);
        }

        public I_Load_to_database get_from_list(int index) 
        { 
            return load_to_database[index];
        }

    }
}
