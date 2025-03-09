using evidence_clip_about_public_transport.DAO.mysql.for_author;
using evidence_clip_about_public_transport.DAO.mysql.for_clip;
using evidence_clip_about_public_transport.DAO.mysql.for_formats;
using evidence_clip_about_public_transport.DAO.mysql.for_line;
using evidence_clip_about_public_transport.DAO.mysql.for_mean_of_transport;
using evidence_clip_about_public_transport.DAO.mysql.for_pattern;
using evidence_clip_about_public_transport.DAO.mysql.for_pattern_on_vehicle;
using evidence_clip_about_public_transport.DAO.mysql.for_producer;
using evidence_clip_about_public_transport.DAO.mysql.for_stop;
using evidence_clip_about_public_transport.DAO.mysql.for_subtype_mean_of_transport;
using evidence_clip_about_public_transport.DAO.mysql.for_vehicles;
using evidence_clip_about_public_transport.DAO.mysql.for_vehicles_on_clip;
using evidence_clip_about_public_transport.DAO.mysql.other_features;
using evidence_clip_about_public_transport.DAO.mysql.for_owner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


namespace evidence_clip_about_public_transport.DAO
{
    public class Database_server_switch
    {
        private int stave;

        public int Stave { get => stave; set => stave = value; }

        public static int stave_from_file()
        {

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("database.config");

            XmlNodeList type_of_database = xmlDoc.GetElementsByTagName("type_of_database");

            return Int32.Parse(type_of_database[0].InnerText);
        }

        public static I_DAO_Clip dAO_Clips()
        {
            try
            {
                List<I_DAO_Clip> dAO_ = new List<I_DAO_Clip>();
                dAO_.Add(new DAO_Clip_implement());
                return dAO_[stave_from_file()];
            }
            catch (IndexOutOfRangeException exc)
            {
                MessageBox.Show("Došlo k přepnutí na MySQL databázi");
                return new DAO_Clip_implement();
            }
        }

        public static I_DAO_Formats dAO_Formats()
        {
            List<I_DAO_Formats> dAO_Formats = new List<I_DAO_Formats>();
            dAO_Formats.Add(new DAO_Formats_implement());
            return dAO_Formats[stave_from_file()];
        }

        public static I_DAO_Line dAO_Line()
        {
            List<I_DAO_Line> dAO_Formats = new List<I_DAO_Line>();
            dAO_Formats.Add(new DAO_Line_implement());
            
            return dAO_Formats[stave_from_file()];
        }

        public static I_DAO_Mean_of_transport dAO_Mean_Of_Transport()
        {
            List<I_DAO_Mean_of_transport> dAO_Formats = new List<I_DAO_Mean_of_transport>();
            dAO_Formats.Add(new DAO_Mean_of_transport_implement()); 
            return dAO_Formats[stave_from_file()];
        }

        public static I_DAO_Owner dAO_owner()
        {
            List<I_DAO_Owner> dAO_Formats = new List<I_DAO_Owner>();
            dAO_Formats.Add(new DAO_Owner_implement());
            
            return dAO_Formats[stave_from_file()];
        }

        public static I_DAO_Pattern dAO_pattern()
        {
            List<I_DAO_Pattern> dAO_Formats = new List<I_DAO_Pattern>();
            dAO_Formats.Add(new DAO_Pattern_implement());
            
            return dAO_Formats[stave_from_file()];
        }

        public static I_DAO_Pattern_on_vehicle dAO_Pattern_On_Vehicle()
        {
            List<I_DAO_Pattern_on_vehicle> dAO_Formats = new List<I_DAO_Pattern_on_vehicle>();
            dAO_Formats.Add(new DAO_Pattern_on_vehicle_implement());
            
            return dAO_Formats[stave_from_file()];
        }

        public static I_DAO_Producer dAO_producer()
        {
            List<I_DAO_Producer> dAO_Formats = new List<I_DAO_Producer>();
            dAO_Formats.Add(new DAO_Producer_implement());
            
            return dAO_Formats[stave_from_file()];
        }

        public static I_DAO_Stop dAO_stop()
        {
            List<I_DAO_Stop> dAO_Formats = new List<I_DAO_Stop>();
            dAO_Formats.Add(new DAO_Stop_implement());
            
            return dAO_Formats[stave_from_file()];
        }

        public static I_DAO_Subtype_mean_of_transport dAO_Subtype_Mean_Of_Transport()
        {
            List<I_DAO_Subtype_mean_of_transport> dAO_Formats = new List<I_DAO_Subtype_mean_of_transport>();
            dAO_Formats.Add(new DAO_Subtype_mean_of_transport_implement());
            
            return dAO_Formats[stave_from_file()];
        }

        public static I_DAO_Vehicle dAO_Vehicle()
        {
            List<I_DAO_Vehicle> dAO_Formats = new List<I_DAO_Vehicle>();
            dAO_Formats.Add(new DAO_Vehicle_implement());
            
            return dAO_Formats[stave_from_file()];
        }

        public static I_DAO_Vehicles_on_clip DAO_Vehicles_On_Clip()
        {
            List<I_DAO_Vehicles_on_clip> dAO_Formats = new List<I_DAO_Vehicles_on_clip>();
            dAO_Formats.Add(new DAO_Vehicles_on_clip_implements());
            
            return dAO_Formats[stave_from_file()];
        }

        public static I_DAO_Author DAO_Author()
        {
            List<I_DAO_Author> dAO_Formats = new List<I_DAO_Author>();
            dAO_Formats.Add(new DAO_Author_implement());
            
            return dAO_Formats[stave_from_file()];
        }

        public static I_List_to_combobox list_to_combobox()
        {

            List<I_List_to_combobox> list_To_Combobox = new List<I_List_to_combobox>();
            list_To_Combobox.Add(new List_to_combobox());
            

            return list_To_Combobox[stave_from_file()];
        }

        public static I_Other_database_features other_Database_Features()
        {
            List<I_Other_database_features> list_Other_Database_ = new List<I_Other_database_features>();
            list_Other_Database_.Add(new Other_database_features());
            
            return list_Other_Database_[stave_from_file()];
        }
    }
}
