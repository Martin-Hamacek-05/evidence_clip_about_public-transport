using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Author: Martin Hamacek
namespace evidence_clip_about_public_transport.File_manager
{
    /// <summary>
    /// Switcher for source of files
    /// </summary>
    public class File_manager_switch
    {
        /// <summary>
        /// list of sources of files
        /// </summary>
        private List<I_File_type> i_File_Types = new List<I_File_type>();

        /// <summary>
        /// fill list all supported source of files
        /// </summary>
        /// <returns>list</returns>
        private List<I_File_type> file_switch() 
        {
            i_File_Types.Add(new Work_with_local());
            i_File_Types.Add(new Work_with_ftp());
            return i_File_Types;
        }

        /// <summary>
        /// load selected source of files
        /// </summary>
        /// <param name="index">index in list</param>
        /// <returns>selected source of files</returns>
        public I_File_type selected_type(int index) 
        {
            file_switch();
            return i_File_Types[index];
        }

    }
}
