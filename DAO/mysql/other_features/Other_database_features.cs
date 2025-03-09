using evidence_clip_about_public_transport.DAO.mysql.for_producer;
using evidence_clip_about_public_transport.DAO.mysql.for_formats;
using evidence_clip_about_public_transport.DAO.mysql.for_line;
using evidence_clip_about_public_transport.DAO.mysql.for_owner;
using evidence_clip_about_public_transport.DAO.mysql.for_stop;
using evidence_clip_about_public_transport.DAO.mysql.for_subtype_mean_of_transport;
using evidence_clip_about_public_transport.Database_connection;
using evidence_clip_about_public_transport.Entits;
using evidence_clip_about_public_transport.exceptions;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* author Martin Hamacek, C4c, 2024/2025*/
namespace evidence_clip_about_public_transport.DAO.mysql.other_features
{
    /// <summary>
    /// specific features for work with database
    /// </summary>
    public class Other_database_features : I_Other_database_features
    {

        /// <summary>
        /// Generate string about list of vehicle on selected clip
        /// </summary>
        /// <param name="id">selected clip</param>
        /// <returns>string</returns>
        public string vehicles_on_clip(int id)
        {
            try
            {
                string querry = "select vehicle.number_ as number_, subtype_mean_of_transport.name_,clip.name_of_clip from vehicles_on_clip\r\n    inner join vehicle on vehicles_on_clip.vehicle_id = vehicle.id\r\n    inner join subtype_mean_of_transport on vehicle.subtype_mean_of_transport_id = subtype_mean_of_transport.id\r\n    inner join clip on vehicles_on_clip.clip_id = clip.id\r\n    where clip.id = @clip_id";

                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                MySqlCommand command = new MySqlCommand(querry, connection);
                command.Parameters.AddWithValue("@clip_id", id);

                string final = "";

                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    final = final + " " + reader.GetInt32(0) + " (" + reader.GetString(1) + ")";
                }
                return final;
            }
            catch (MySqlException exc)
            {
                Work_with_expection.sql_exception_of_code(exc.Number);
                return "";
            }
            catch (Exception exc)
            {
                return "Došlo k neočekavané chybě:\n" + exc.Message;
            }
        }
        /// <summary>
        /// Set list of patterns of vehicle on selected vehicle
        /// </summary>
        /// <param name="id"></param>
        /// <param name="patterns"></param>
        public void patterns_on_vehicle(int id, ListBox patterns)
        {
            try
            {
                string querry = "select pattern.name_of_pattern,pattern_on_vehicle.from_,pattern_on_vehicle.to_ from pattern_on_vehicle\r\ninner join pattern on pattern_id = pattern.id\r\nwhere vehicle_id = @id;";

                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                MySqlCommand command = new MySqlCommand(querry, connection);
                command.Parameters.AddWithValue("@id", id);

                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    patterns.Items.Add(reader.GetString(0) + " - (od " + DateOnly.FromDateTime(reader.GetDateTime(1)) + " od " + DateOnly.FromDateTime(reader.GetDateTime(2)) + ")");
                }

            }
            catch (MySqlException exc)
            {
                Work_with_expection.sql_exception_of_code(exc.Number);

            }
            catch (Exception exc)
            {
                MessageBox.Show("Došlo k neočekavané chybě:\n" + exc.Message);
            }
        }
        /// <summary>
        /// Set filter propeties
        /// </summary>
        /// <returns>List of CheckedListBox</returns>
        public List<CheckedListBox> parameters_for_filter()
        {
            List<CheckedListBox> all_parameters = new List<CheckedListBox>();
            DAO_Formats_implement dAO_Formats_implement = new DAO_Formats_implement();
            DAO_Line_implement dAO_Line_Implement = new DAO_Line_implement();
            DAO_Owner_implement dAO_Owner_Implement = new DAO_Owner_implement();
            DAO_Stop_implement dAO_Stop_Implement = new DAO_Stop_implement();
            DAO_Subtype_mean_of_transport_implement dAO_Subtype_Mean_Of_Transport_Implement = new DAO_Subtype_mean_of_transport_implement();

            CheckedListBox formats = dAO_Formats_implement.get_distict_format();
            formats.Dock = DockStyle.Fill;
            CheckedListBox lines = dAO_Line_Implement.get_distict_name_of_lines();
            lines.Dock = DockStyle.Fill;
            CheckedListBox owners = dAO_Owner_Implement.get_distict_owners();
            owners.Dock = DockStyle.Fill;
            CheckedListBox stops = dAO_Stop_Implement.get_distict_stop();
            stops.Dock = DockStyle.Fill;
            CheckedListBox subtypes_mean_of_public_transport = dAO_Subtype_Mean_Of_Transport_Implement.get_distict_subtype_mean_of_public_transport();
            subtypes_mean_of_public_transport.Dock = DockStyle.Fill;


            all_parameters.Add(formats);
            all_parameters.Add(lines);
            all_parameters.Add(owners);
            all_parameters.Add(stops);
            all_parameters.Add(subtypes_mean_of_public_transport);

            return all_parameters;
        }
        /// <summary>
        /// Load of stored prodecure, witch have a parameter year
        /// </summary>
        /// <param name="name_of_procedure"></param>
        /// <param name="year"></param>
        /// <returns>table</returns>
        public DataSet load_stored_procedure(string name_of_procedure, string year)
        {
            try
            {

                MySqlCommand dotaz = new MySqlCommand(name_of_procedure, Database_connect.myssql_connection());
                MySqlDataAdapter adapter = new MySqlDataAdapter(dotaz);
                dotaz.CommandType = CommandType.StoredProcedure;
                dotaz.Parameters.AddWithValue("@year_", year);
                DataSet dataSet_from_procedure = new DataSet();
                adapter.Fill(dataSet_from_procedure);

                return dataSet_from_procedure;
            }
            catch (MySqlException exc)
            {
                Work_with_expection.sql_exception_of_code(exc.Number);
                return new DataSet();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Došlo k neočekavané chybě:\n" + exc.Message);
                return new DataSet();
            }
        }


    }
}
