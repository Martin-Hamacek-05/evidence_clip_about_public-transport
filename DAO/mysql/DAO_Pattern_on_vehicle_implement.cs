using evidence_clip_about_public_transport.Database_connection;
using evidence_clip_about_public_transport.Entits;
using evidence_clip_about_public_transport.exceptions;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evidence_clip_about_public_transport.DAO.mysql.for_pattern_on_vehicle
{
    public class DAO_Pattern_on_vehicle_implement : I_DAO_Pattern_on_vehicle
    {

        public string add_pattern_to_vehicle(Pattern_on_vehicle pattern_on_vehicle)
        {
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                MySqlCommand insert_command = new MySqlCommand("insert into pattern_on_vehicle(from_,to_,vehicle_id,pattern_id) values (@from_,@to_,@vehicle_id,@pattern_id)", connection);
                insert_command.Parameters.AddWithValue("@from_", pattern_on_vehicle.From_.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
                insert_command.Parameters.AddWithValue("@to_", pattern_on_vehicle.To_.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
                insert_command.Parameters.AddWithValue("@vehicle_id", pattern_on_vehicle.Vehicle_id);
                insert_command.Parameters.AddWithValue("@pattern_id", pattern_on_vehicle.Pattern_id);
                insert_command.ExecuteNonQuery();
                connection.Close();
                return "Vloženo";
            }
            catch (MySqlException e)
            {
                Work_with_expection.sql_exception_of_code(e.Number);
                return "";
            }
            catch (Exception exc)
            {
                return "Došlo k neočekavané chybě: \n" + exc.ToString();
            }
        }

        public string delete_pattern_from_vehicle(int id)
        {
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                MySqlCommand insert_command = new MySqlCommand("delete from pattern_on_vehicle where id=@id", connection);
                insert_command.Parameters.AddWithValue("@id", id);
                insert_command.ExecuteNonQuery();
                connection.Close();
                return "Smazáno";
                //MessageBox.Show("OK" + clip_id + ","+vehicle_id);
            }
            catch (MySqlException e)
            {
                Work_with_expection.sql_exception_of_code(e.Number);
                return "";
            }
            catch (Exception exc)
            {
                return "Došlo k neočekavané chybě: \n" + exc.ToString();
            }
        }

        public List<Pattern_on_vehicle> get_all_for_backup()
        {
            List<Pattern_on_vehicle> pattern = new List<Pattern_on_vehicle>();
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("select * from pattern_on_vehicle", connection);


                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    pattern.Add(new Pattern_on_vehicle(reader.GetInt32(0), DateOnly.FromDateTime(reader.GetDateTime(1)), DateOnly.FromDateTime(reader.GetDateTime(2)), reader.GetInt32(3), reader.GetInt32(4)));
                }
                connection.Close();
                return pattern;


            }
            catch (MySqlException e)
            {
                Work_with_expection.sql_exception_of_code(e.Number);
                return pattern;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Došlo k neočekavané chybě: \n" + exc.ToString());
                return pattern;
            }
        }

        public DataSet get_all_pattern_from_list(int id)
        {
            try
            {
                string query = "select pattern_on_vehicle.id,pattern_on_vehicle.from_,pattern_on_vehicle.to_,pattern.name_of_pattern from pattern_on_vehicle\r\ninner join vehicle on pattern_on_vehicle.vehicle_id = vehicle.id\r\ninner join pattern on pattern_on_vehicle.pattern_id = pattern.id\r\nwhere pattern_on_vehicle.vehicle_id=" + id;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, Database_connect.myssql_connection());

                DataSet dataSet_of_clip = new DataSet();
                adapter.Fill(dataSet_of_clip);
                return dataSet_of_clip;
            }
            catch (MySqlException e)
            {
                Work_with_expection.sql_exception_of_code(e.Number);
                return new DataSet();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Došlo k neočekavané chybě: \n" + exc.ToString());
                return new DataSet();
            }
        }

        public string load_file(List<Pattern_on_vehicle> list)
        {
            MySqlTransaction mySqlTransaction = null;
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();

                connection.Open();

                mySqlTransaction = connection.BeginTransaction();
                MySqlCommand insert_command = new MySqlCommand("insert into pattern_on_vehicle(id,from_,to_,vehicle_id,pattern_id) values (@id,@from_,@to_,@vehicle_id,@pattern_id)", connection);

                for (int i = 0; i < list.Count; i++)
                {
                    insert_command.Parameters.AddWithValue("@id", list[i].Id);
                    insert_command.Parameters.AddWithValue("@from_", list[i].From_.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
                    insert_command.Parameters.AddWithValue("@to_", list[i].To_.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
                    insert_command.Parameters.AddWithValue("@vehicle_id", list[i].Vehicle_id);
                    insert_command.Parameters.AddWithValue("@pattern_id", list[i].Pattern_id);

                    insert_command.ExecuteNonQuery();
                    insert_command.Parameters.Clear();

                }
                mySqlTransaction.Commit();

                connection.Close();
                return "Nahráno";
            }
            catch (Exception exc)
            {
                try
                {
                    mySqlTransaction.Rollback();
                    return exc.ToString();
                }
                catch (Exception exc2)
                {
                    return exc2.ToString();
                }

            }
        }
    }
}
