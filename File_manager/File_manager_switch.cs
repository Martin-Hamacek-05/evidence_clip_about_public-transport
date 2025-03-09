using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evidence_clip_about_public_transport.File_manager
{
    public class File_manager_switch
    {
        private List<I_File_type> i_File_Types = new List<I_File_type>();

        private List<I_File_type> file_switch() 
        {
            i_File_Types.Add(new Work_with_local());
            i_File_Types.Add(new Work_with_ftp());
            return i_File_Types;
        }

        public I_File_type selected_type(int index) 
        {
            file_switch();
            return i_File_Types[index];
        }

    }
}
