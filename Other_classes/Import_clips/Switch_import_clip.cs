using evidence_clip_about_public_transport.Import_clips;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evidence_clip_about_public_transport.Other_classes.Import_clips
{
    public class Switch_import_clip
    { 
        private List<I_Import_clip> clips = new List<I_Import_clip>();

        private void set_list() 
        {
            clips.Add(null);
            clips.Add(new Excel_Import_clip());
            
        }

        public I_Import_clip selected_clip(int index) 
        {
            set_list();
            return clips[index];
        }
    }
}
