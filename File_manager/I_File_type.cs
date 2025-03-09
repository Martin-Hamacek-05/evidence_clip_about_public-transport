using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evidence_clip_about_public_transport.File_manager
{
    public interface I_File_type
    {
        public string record_file(string name_of_file, string from, string to);
        public string rename_file(string previours_name_of_file, string new_name_of_file, string path);
        public string load_file(string name_of_file, string from);
        public string delete_file(string name_of_file, string from);
        public List<string> list_of_directories(string path);
        public string make_directory(string name,string path);
        public string copy_file_from_one_location_to_another(string from_, string file, string to_, string alternative);
    }
}
