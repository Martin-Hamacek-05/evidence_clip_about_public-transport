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

//Author: Martin Hamacek
namespace evidence_clip_about_public_transport.DAO
{
    /// <summary>
    /// Swither between other database systems (currently support only MySQL server)
    /// </summary>
    public class Database_server_switch
    {
        /// <summary>
        /// Type of server 
        /// </summary>
        private int stave;

        /// <summary>
        /// set and get stave
        /// </summary>
        public int Stave { get => stave; set => stave = value; }

        /// <summary>
        /// Load set stave in file
        /// </summary>
        /// <returns>id of system</returns>
        public static int stave_from_file()
        {

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("database.config");

            XmlNodeList type_of_database = xmlDoc.GetElementsByTagName("type_of_database");

            return Int32.Parse(type_of_database[0].InnerText);
        }

        /// <summary>
        /// Switcher for table clip
        /// </summary>
        /// <returns>selected server for table clip</returns>
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

        /// <summary>
        /// Switcher for table formats
        /// </summary>
        /// <returns>selected server for table formats</returns>
        public static I_DAO_Formats dAO_Formats()
        {
            try
            {
                List<I_DAO_Formats> dAO_Formats = new List<I_DAO_Formats>();
            dAO_Formats.Add(new DAO_Formats_implement());
            return dAO_Formats[stave_from_file()];
            }
            catch (IndexOutOfRangeException exc)
            {
                MessageBox.Show("Došlo k přepnutí na MySQL databázi");
                return new DAO_Formats_implement();
            }

        }

        /// <summary>
        /// Switcher for table line
        /// </summary>
        /// <returns>selected server for table line</returns>
        public static I_DAO_Line dAO_Line()
        {
            try
            {
                List<I_DAO_Line> dAO_Formats = new List<I_DAO_Line>();
            dAO_Formats.Add(new DAO_Line_implement());
            
            return dAO_Formats[stave_from_file()];
            }
            catch (IndexOutOfRangeException exc)
            {
                MessageBox.Show("Došlo k přepnutí na MySQL databázi");
                return new DAO_Line_implement();
            }
        }

        /// <summary>
        /// Switcher for table Mean_Of_Transport
        /// </summary>
        /// <returns>selected server for table Mean_Of_Transport</returns>
        public static I_DAO_Mean_of_transport dAO_Mean_Of_Transport()
        {
            try { 
            List<I_DAO_Mean_of_transport> dAO_Formats = new List<I_DAO_Mean_of_transport>();
            dAO_Formats.Add(new DAO_Mean_of_transport_implement()); 
            return dAO_Formats[stave_from_file()];
            }
            catch (IndexOutOfRangeException exc)
            {
                MessageBox.Show("Došlo k přepnutí na MySQL databázi");
                return new DAO_Mean_of_transport_implement();
            }
        }

        /// <summary>
        /// Switcher for table Owner_
        /// </summary>
        /// <returns>selected server for table Owner_</returns>
        public static I_DAO_Owner dAO_owner()
        {
            try
            {
                List<I_DAO_Owner> dAO_Formats = new List<I_DAO_Owner>();
            dAO_Formats.Add(new DAO_Owner_implement());
            
            return dAO_Formats[stave_from_file()];
            }
            catch (IndexOutOfRangeException exc)
            {
                MessageBox.Show("Došlo k přepnutí na MySQL databázi");
                return new DAO_Owner_implement();
            }
        }

        /// <summary>
        /// Switcher for table Pattern
        /// </summary>
        /// <returns>selected server for table Pattern</returns>
        public static I_DAO_Pattern dAO_pattern()
        {
            try
            {
                List<I_DAO_Pattern> dAO_Formats = new List<I_DAO_Pattern>();
            dAO_Formats.Add(new DAO_Pattern_implement());
            
            return dAO_Formats[stave_from_file()];
            }
            catch (IndexOutOfRangeException exc)
            {
                MessageBox.Show("Došlo k přepnutí na MySQL databázi");
                return new DAO_Pattern_implement();
            }
        }

        /// <summary>
        /// Switcher for table Pattern_on_vehicle
        /// </summary>
        /// <returns>selected server for table Pattern_on_vehicle</returns>
        public static I_DAO_Pattern_on_vehicle dAO_Pattern_On_Vehicle()
        {
            try { 
            List<I_DAO_Pattern_on_vehicle> dAO_Formats = new List<I_DAO_Pattern_on_vehicle>();
            dAO_Formats.Add(new DAO_Pattern_on_vehicle_implement());
            
            return dAO_Formats[stave_from_file()];
            }
            catch (IndexOutOfRangeException exc)
            {
                MessageBox.Show("Došlo k přepnutí na MySQL databázi");
                return new DAO_Pattern_on_vehicle_implement();
            }
        }

        /// <summary>
        /// Switcher for table Producer
        /// </summary>
        /// <returns>selected server for table Producer</returns>
        public static I_DAO_Producer dAO_producer()
        {
            try
            {
                List<I_DAO_Producer> dAO_Formats = new List<I_DAO_Producer>();
                dAO_Formats.Add(new DAO_Producer_implement());
                return dAO_Formats[stave_from_file()];
            }
            catch (IndexOutOfRangeException exc)
            {
                MessageBox.Show("Došlo k přepnutí na MySQL databázi");
                return new DAO_Producer_implement();
            }
        }

        /// <summary>
        /// Switcher for table Producer
        /// </summary>
        /// <returns>selected server for table Stop</returns>
        public static I_DAO_Stop dAO_stop()
        {
            try
            {
                List<I_DAO_Stop> dAO_Formats = new List<I_DAO_Stop>();
            dAO_Formats.Add(new DAO_Stop_implement());
            
            return dAO_Formats[stave_from_file()];
            }
            catch (IndexOutOfRangeException exc)
            {
                MessageBox.Show("Došlo k přepnutí na MySQL databázi");
                return new DAO_Stop_implement();
            }
        }

        /// <summary>
        /// Switcher for table Subtype_mean_of_transport 
        /// </summary>
        /// <returns>selected server for table Subtype_mean_of_transport</returns>
        public static I_DAO_Subtype_mean_of_transport dAO_Subtype_Mean_Of_Transport()
        {
            try
            {
                List<I_DAO_Subtype_mean_of_transport> dAO_Formats = new List<I_DAO_Subtype_mean_of_transport>();
            dAO_Formats.Add(new DAO_Subtype_mean_of_transport_implement());
            
            return dAO_Formats[stave_from_file()];
            }
            catch (IndexOutOfRangeException exc)
            {
                MessageBox.Show("Došlo k přepnutí na MySQL databázi");
                return new DAO_Subtype_mean_of_transport_implement();
            }
        }

        /// <summary>
        /// Switcher for table Vehicle 
        /// </summary>
        /// <returns>selected server for table Vehicle</returns>
        public static I_DAO_Vehicle dAO_Vehicle()
        {
            try
            {
                List<I_DAO_Vehicle> dAO_Formats = new List<I_DAO_Vehicle>();
            dAO_Formats.Add(new DAO_Vehicle_implement());
            
            return dAO_Formats[stave_from_file()];
            }
            catch (IndexOutOfRangeException exc)
            {
                MessageBox.Show("Došlo k přepnutí na MySQL databázi");
                return new DAO_Vehicle_implement();
            }
        }

        /// <summary>
        /// Switcher for table Vehicles_on_clip 
        /// </summary>
        /// <returns>selected server for table Vehicles_on_clip</returns>
        public static I_DAO_Vehicles_on_clip DAO_Vehicles_On_Clip()
        {
            try
            {
                List<I_DAO_Vehicles_on_clip> dAO_Formats = new List<I_DAO_Vehicles_on_clip>();
            dAO_Formats.Add(new DAO_Vehicles_on_clip_implements());
            
            return dAO_Formats[stave_from_file()];
            }
            catch (IndexOutOfRangeException exc)
            {
                MessageBox.Show("Došlo k přepnutí na MySQL databázi");
                return new DAO_Vehicles_on_clip_implements();
            }
        }

        /// <summary>
        /// Switcher for table Author 
        /// </summary>
        /// <returns>selected server for table Author</returns>
        public static I_DAO_Author DAO_Author()
        {
            try
            {
                List<I_DAO_Author> dAO_Formats = new List<I_DAO_Author>();
            dAO_Formats.Add(new DAO_Author_implement());
            
            return dAO_Formats[stave_from_file()];
            }
            catch (IndexOutOfRangeException exc)
            {
                MessageBox.Show("Došlo k přepnutí na MySQL databázi");
                return new DAO_Author_implement();
            }
        }

        /// <summary>
        /// Switcher for list_to_combobox
        /// </summary>
        /// <returns>selected server for list_to_combobox</returns>
        public static I_List_to_combobox list_to_combobox()
        {
            try
            {
                List<I_List_to_combobox> list_To_Combobox = new List<I_List_to_combobox>();
            list_To_Combobox.Add(new List_to_combobox());
            

            return list_To_Combobox[stave_from_file()];
            }
            catch (IndexOutOfRangeException exc)
            {
                MessageBox.Show("Došlo k přepnutí na MySQL databázi");
                return new List_to_combobox();
            }
        }

        /// <summary>
        /// Switcher for other_Database_Features 
        /// </summary>
        /// <returns>selected server for other_Database_Features</returns>
        public static I_Other_database_features other_Database_Features()
        {
            try
            {
                List<I_Other_database_features> list_Other_Database_ = new List<I_Other_database_features>();
            list_Other_Database_.Add(new Other_database_features());
            
            return list_Other_Database_[stave_from_file()];
                }
            catch (IndexOutOfRangeException exc)
            {
                MessageBox.Show("Došlo k přepnutí na MySQL databázi");
                return new Other_database_features();
            }
        }

    }
}
