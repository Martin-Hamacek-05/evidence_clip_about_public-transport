using evidence_clip_about_public_transport.Import_clips;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Author: Martin Hamacek
namespace evidence_clip_about_public_transport.Other_classes.Import_clips
{
    /// <summary>
    /// Switch formats for simplified format of clip
    /// </summary>
    public class Switch_import_clip
    { 
        /// <summary>
        /// list of formats
        /// </summary>
        private List<I_Import_clip> clips = new List<I_Import_clip>();

        /// <summary>
        /// fill list of formats
        /// </summary>
        private void set_list() 
        {
            clips.Add(null);
            clips.Add(new Excel_Import_clip());
            clips.Add(new Csv_Import_clip());
            
        }

        /// <summary>
        /// load to selected format
        /// </summary>
        /// <param name="index">index</param>
        /// <returns>selected format</returns>
        public I_Import_clip selected_clip(int index) 
        {
            set_list();
            return clips[index];
        }
    }
}
