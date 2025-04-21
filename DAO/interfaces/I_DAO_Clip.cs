using evidence_clip_about_public_transport.Entits;
using evidence_clip_about_public_transport.Other_classes.Import_clips;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* author: Martin Hamacek*/
namespace evidence_clip_about_public_transport.DAO
{
    /// <summary>
    /// This interface reprezent the most used functions in database entit: clip
    /// </summary>
    public interface I_DAO_Clip
    {

        /// <summary>
        /// Insert a new record to table clip
        /// </summary>
        /// <param name="clip">new clip</param>
        /// <param name="list_id_of_vehicles">list of id for vehicles on clip</param>
        /// <returns>stave</returns>
        public string new_clip(Clip clip, List<int> list_id_of_vehicles);

        /// <summary>
        /// Remove selected record from table clip
        /// </summary>
        /// <param name="id">id of clip</param>
        /// <returns>stave</returns>
        public string delete_clip(int id);

        /// <summary>
        /// Edit the exist now record in table clip
        /// </summary>
        /// <param name="clip">replace clip</param>
        /// <returns>stave</returns>
        public string update_clip(Clip clip);

        /// <summary>
        /// Load all data from table clip from selected year
        /// </summary>
        /// <param name="year">selected year</param>
        /// <returns>loaded data from database view clip</returns>
        public DataSet get_all_clip_from_year(int year);
        /// <summary>
        /// Load all clip for filter
        /// </summary>
        /// <returns>specific dataset</returns>
        public DataSet get_all_clip_for_filter();
        /// <summary>
        /// This method is used for load the clip
        /// </summary>
        /// <param name="id">id of clip</param>
        /// <returns>loaded clip</returns>
        public Clip get_clip(int id);

        /// <summary>
        /// Load all Clips for backup
        /// </summary>
        /// <returns>list for backup</returns>
        public List<Clip> get_all_for_backup();

        /// <summary>
        /// Load backup of clip
        /// </summary>
        /// <param name="list">list of clips</param>
        /// <returns>stave</returns>
        public string load_file(List<Clip> list);

        /// <summary>
        /// Load sheet of clips to database
        /// </summary>
        /// <param name="to_upload">list of simplified form of clip</param>
        /// <returns>stave</returns>
        public string load_record_from_file(List<Import_clip_object> to_upload);

    }
}
