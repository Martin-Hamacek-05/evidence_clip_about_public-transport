using evidence_clip_about_public_transport.DAO;
using evidence_clip_about_public_transport.DAO.mysql.for_author;
using evidence_clip_about_public_transport.DAO.mysql.for_clip;
using evidence_clip_about_public_transport.DAO.mysql.for_formats;
using evidence_clip_about_public_transport.DAO.mysql.for_line;
using evidence_clip_about_public_transport.DAO.mysql.for_mean_of_transport;
using evidence_clip_about_public_transport.DAO.mysql.for_owner;
using evidence_clip_about_public_transport.DAO.mysql.for_pattern;
using evidence_clip_about_public_transport.DAO.mysql.for_pattern_on_vehicle;
using evidence_clip_about_public_transport.DAO.mysql.for_producer;
using evidence_clip_about_public_transport.DAO.mysql.for_stop;
using evidence_clip_about_public_transport.DAO.mysql.for_subtype_mean_of_transport;
using evidence_clip_about_public_transport.DAO.mysql.for_vehicles;
using evidence_clip_about_public_transport.DAO.mysql.for_vehicles_on_clip;
using evidence_clip_about_public_transport.Entits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
/* author Martin Hamacek, C4c, 2024/2025*/
namespace evidence_clip_about_public_transport.Other_classes.Backup_class
{
    /// <summary>
    /// Export data from table line and stop_ to csv file 
    /// </summary>
    public class Backup_to_CSV : I_Backup
    {
        public string export_data(string directopy_for_backup)
        {
            I_DAO_Line dAO_Line_Implement = Database_server_switch.dAO_Line();
            I_DAO_Stop dAO_Stop_Implement = Database_server_switch.dAO_stop();
            I_DAO_Author i_DAO_Author = Database_server_switch.DAO_Author();
            I_DAO_Clip i_DAO_Clip = Database_server_switch.dAO_Clips();
            I_DAO_Formats i_DAO_Formats = Database_server_switch.dAO_Formats();
            I_DAO_Vehicle i_DAO_Vehicle = Database_server_switch.dAO_Vehicle();
            I_DAO_Pattern i_DAO_Pattern = Database_server_switch.dAO_pattern();
            I_DAO_Pattern_on_vehicle i_DAO_Pattern_On_Vehicle = Database_server_switch.dAO_Pattern_On_Vehicle();
            I_DAO_Owner i_DAO_Owner = Database_server_switch.dAO_owner();
            I_DAO_Producer i_DAO_Producer = Database_server_switch.dAO_producer();
            I_DAO_Vehicles_on_clip i_DAO_Vehicles_On_Clip = Database_server_switch.DAO_Vehicles_On_Clip();
            I_DAO_Mean_of_transport i_DAO_Mean_Of_Transport = Database_server_switch.dAO_Mean_Of_Transport();
            I_DAO_Subtype_mean_of_transport i_DAO_Subtype_Mean_Of_Transport = Database_server_switch.dAO_Subtype_Mean_Of_Transport();

            save_to_file(new List<I_Work_with_Csv>(dAO_Line_Implement.get_all_for_backup().ToArray()), directopy_for_backup, "_line_.csv");
            save_to_file(new List<I_Work_with_Csv>(dAO_Stop_Implement.get_all_for_backup().ToArray()), directopy_for_backup, "_stop_.csv");
            save_to_file(new List<I_Work_with_Csv>(i_DAO_Clip.get_all_for_backup().ToArray()), directopy_for_backup, "_clip_.csv");
            save_to_file(new List<I_Work_with_Csv>(i_DAO_Author.get_all_for_backup().ToArray()), directopy_for_backup, "_author_.csv");
            save_to_file(new List<I_Work_with_Csv>(i_DAO_Formats.get_all_for_backup().ToArray()), directopy_for_backup, "_formats_.csv");
            save_to_file(new List<I_Work_with_Csv>(i_DAO_Vehicle.get_all_for_backup().ToArray()), directopy_for_backup, "_vehicle_.csv");
            save_to_file(new List<I_Work_with_Csv>(i_DAO_Pattern.get_all_for_backup().ToArray()), directopy_for_backup, "_pattern_.csv");
            save_to_file(new List<I_Work_with_Csv>(i_DAO_Pattern_On_Vehicle.get_all_for_backup().ToArray()), directopy_for_backup, "_pattern_on_vehicle_.csv");
            save_to_file(new List<I_Work_with_Csv>(i_DAO_Owner.get_all_for_backup().ToArray()), directopy_for_backup, "_owner_.csv");
            save_to_file(new List<I_Work_with_Csv>(i_DAO_Producer.get_all_for_backup().ToArray()), directopy_for_backup, "_producer_.csv");
            save_to_file(new List<I_Work_with_Csv>(i_DAO_Vehicles_On_Clip.get_all_for_backup().ToArray()), directopy_for_backup, "_vehicles_on_clip_.csv");
            save_to_file(new List<I_Work_with_Csv>(i_DAO_Mean_Of_Transport.get_all_for_backup().ToArray()), directopy_for_backup, "_mean_of_transport_.csv");
            save_to_file(new List<I_Work_with_Csv>(i_DAO_Subtype_Mean_Of_Transport.get_all_for_backup().ToArray()), directopy_for_backup, "_subtype_mean_of_transport_.csv");

            //Clip clip = new Clip();
            //MessageBox.Show(clip.from_csv("").ToString());

            return "hotovo";
        }

        public static void save_to_file(List<I_Work_with_Csv> i_Work_With_Csv,string directopy_for_backup,string file_name) 
        {
            //Thread thread = new Thread(() =>
            //{
                string data = "";

                foreach (I_Work_with_Csv i_Work_With_ in i_Work_With_Csv)
                {
                    data += i_Work_With_.to_csv() + "\n";
                }

                File_manager.export_to_csv(directopy_for_backup + file_name, data);
            //});

            /*thread.Start();
            thread.Join();*/
        }
    }
}
