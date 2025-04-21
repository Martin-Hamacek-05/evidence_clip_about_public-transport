using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Author: Martin Hamacek
namespace evidence_clip_about_public_transport.Entits
{
    
    /// <summary>
    /// method for load or save object to csv string
    /// </summary>
    public interface I_Work_with_Csv
    {
        /// <summary>
        /// convert object to csv
        /// </summary>
        /// <returns></returns>
        public string to_csv();


        /// <summary>
        /// convert csv to object
        /// </summary>
        /// <param name="row">csv string</param>
        /// <returns>new object from csv string</returns>
        public object from_csv(string row);

    }
}
