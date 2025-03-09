using evidence_clip_about_public_transport.Other_classes.Backup_class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evidence_clip_about_public_transport.Other_classes.Load_backup
{
    public class Load_fill_list
    {
        public static List<I_Load_to_database> fill() 
        {
            List<I_Load_to_database> to_db = new List<I_Load_to_database> ();
            to_db.Add(null);
            to_db.Add(new Load_authors());
            to_db.Add(new Load_formats());
            to_db.Add(new Load_lines());
            to_db.Add(new Load_mean_of_transport());
            to_db.Add(new Load_owner());
            to_db.Add(new Load_pattern());
            to_db.Add(new Load_producer());
            to_db.Add(new Load_stops());
            to_db.Add(new Load_subtype_mean_of_transport());
            to_db.Add(new Load_vehicle());
            to_db.Add(new Load_patterns_on_vehicle());
            to_db.Add(new Load_clip());
            to_db.Add(new Load_vehicles_on_clip());    
            return to_db;
        }
    }
}
