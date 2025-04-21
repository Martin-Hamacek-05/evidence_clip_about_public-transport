using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Author: Martin Hamacek
namespace evidence_clip_about_public_transport.File_manager
{
    /// <summary>
    /// Methods for work with source of files
    /// </summary>
    public interface I_File_type
    {
        /// <summary>
        /// record selected file to specific drive or server
        /// </summary>
        /// <param name="name_of_file"></param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns>stave</returns>
        public string record_file(string name_of_file, string from, string to);

        /// <summary>
        /// rename files
        /// </summary>
        /// <param name="previours_name_of_file"></param>
        /// <param name="new_name_of_file"></param>
        /// <param name="path"></param>
        /// <returns>stave</returns>
        public string rename_file(string previours_name_of_file, string new_name_of_file, string path);

        /// <summary>
        /// loaded selected file
        /// </summary>
        /// <param name="name_of_file"></param>
        /// <param name="from"></param>
        /// <returns>stave</returns>
        public string load_file(string name_of_file, string from);

        /// <summary>
        /// delete selected file
        /// </summary>
        /// <param name="name_of_file"></param>
        /// <param name="from"></param>
        /// <returns>stave</returns>
        public string delete_file(string name_of_file, string from);

        /// <summary>
        /// load list of directories on drive or server
        /// </summary>
        /// <param name="path"></param>
        /// <returns>list of directories</returns>
        public List<string> list_of_directories(string path);

        /// <summary>
        /// make a new directory
        /// </summary>
        /// <param name="name"></param>
        /// <param name="path"></param>
        /// <returns>stave</returns>
        public string make_directory(string name,string path);
        /// <summary>
        /// copy file from one location to selected location
        /// </summary>
        /// <param name="from_"></param>
        /// <param name="file"></param>
        /// <param name="to_"></param>
        /// <param name="alternative"></param>
        /// <returns>stave</returns>
        public string copy_file_from_one_location_to_another(string from_, string file, string to_, string alternative);

        /// <summary>
        /// move selected file to other location
        /// </summary>
        /// <param name="from_"></param>
        /// <param name="to"></param>
        /// <param name="file"></param>
        /// <returns>stave</returns>
        public string move_file(string from_,string to, string file);
    }
}
