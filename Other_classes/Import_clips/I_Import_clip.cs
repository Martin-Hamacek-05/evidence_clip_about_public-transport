using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Author: Martin Hamacek
namespace evidence_clip_about_public_transport.Other_classes.Import_clips
{
    /// <summary>
    /// Template for class, which import data of clip in simplified format
    /// </summary>
    public interface I_Import_clip
    {
        /// <summary>
        /// save data of clip in simplified format to Datatable
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public DataTable load(string path);
    }
}
