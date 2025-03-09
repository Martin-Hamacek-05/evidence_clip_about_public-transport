using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evidence_clip_about_public_transport.Entits
{
    public interface I_Work_with_Csv
    {
        public string to_csv();

        public object from_csv(string row);

    }
}
