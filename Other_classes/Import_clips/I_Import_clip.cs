using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evidence_clip_about_public_transport.Other_classes.Import_clips
{
    public interface I_Import_clip
    {
        public DataTable load(string path);
    }
}
