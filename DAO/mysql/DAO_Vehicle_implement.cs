using evidence_clip_about_public_transport.Database_connection;
using evidence_clip_about_public_transport.Entits;
using evidence_clip_about_public_transport.exceptions;
using MySql.Data.MySqlClient;
using System.Data;
using System.Globalization;
//Author: Martin Hamacek
namespace evidence_clip_about_public_transport.DAO.mysql.for_vehicles
{
    /// <summary>
    /// This class is implent of interface I_DAO_Vehicle for MySQL server
    /// </summary>
    public class DAO_Vehicle_implement : I_DAO_Vehicle
    {
        public string delete_vehicle(int id)
        {
            MySqlTransaction mySqlTransaction = null;
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                mySqlTransaction = connection.BeginTransaction();

                MySqlCommand delete_command = new MySqlCommand("delete from pattern_on_vehicle where vehicle_id= @id", connection);
                delete_command.Parameters.AddWithValue("@id", id);
                delete_command.ExecuteNonQuery();
                delete_command = new MySqlCommand("delete from vehicle where id= @id", connection);
                delete_command.Parameters.AddWithValue("@id", id);
                delete_command.ExecuteNonQuery();
                mySqlTransaction.Commit();
                connection.Close();
                return "Smazáno";
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
        public List<Vehicle> get_all_for_backup()
        {
            List<Vehicle> loaded_clip = new List<Vehicle>();
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("select * from vehicle", connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int presedor = 0;
                    if (reader["vehicle_id"] == DBNull.Value)
                    {
                        presedor =0;
                        loaded_clip.Add(new Vehicle(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), DateOnly.FromDateTime(reader.GetDateTime(4)), DateOnly.FromDateTime(reader.GetDateTime(5)), reader.GetBoolean(6), reader.GetBoolean(7), reader.GetInt32(8), reader.GetInt32(9), reader.GetInt32(10), reader.GetInt32(11), presedor, reader.GetString(13)));
                    }
                    else 
                    { 
                        presedor = reader.GetInt32(12);
                        loaded_clip.Add(new Vehicle(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), DateOnly.FromDateTime(reader.GetDateTime(4)), DateOnly.FromDateTime(reader.GetDateTime(5)), reader.GetBoolean(6), reader.GetBoolean(7), reader.GetInt32(8), reader.GetInt32(9), reader.GetInt32(10), reader.GetInt32(11), presedor, reader.GetString(13)));
                    }
                }
                connection.Close();
                return loaded_clip;
            }
            catch (MySqlException e)
            {
                Work_with_expection.sql_exception_of_code(e.Number);
                return loaded_clip;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Došlo k neočekavané chybě: \n" + exc.ToString());
                return loaded_clip;
            }
        }
        public DataSet get_all_vehicles()
        {
            try
            {
                MySqlDataAdapter adapterII = new MySqlDataAdapter("select * from show_vehicles", Database_connect.myssql_connection());
                DataSet dataSet_of_stops = new DataSet();
                adapterII.Fill(dataSet_of_stops);
                return dataSet_of_stops;
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
        public Vehicle get_vehicle(int id)
        {
            Vehicle loaded_clip = null;
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("select * from vehicle where id=@id", connection);
                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    loaded_clip = new Vehicle(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), DateOnly.FromDateTime(reader.GetDateTime(4)), DateOnly.FromDateTime(reader.GetDateTime(5)), reader.GetBoolean(6), reader.GetBoolean(7), reader.GetInt32(8), reader.GetInt32(9), reader.GetInt32(10), reader.GetInt32(11),reader.GetString(13));
                }
                connection.Close();
                return loaded_clip;
            }
            catch (MySqlException e)
            {
                Work_with_expection.sql_exception_of_code(e.Number);
                return new Vehicle();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Došlo k neočekavané chybě: \n" + exc.ToString());
                return new Vehicle();
            }
        }
        public string load_file(List<Vehicle> list)
        {
            MySqlTransaction mySqlTransaction = null;
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                mySqlTransaction = connection.BeginTransaction();
                MySqlCommand insert_command = new MySqlCommand("SET FOREIGN_KEY_CHECKS=0; insert into vehicle (id,number_,vehicle_registration_plate,year_of_made,in_operation_from,in_operation_to,is_low_rise,have_air_conditioning,producer_id,mean_of_transport_id,subtype_mean_of_transport_id,owner_id,vehicle_id,direction_of_vehicle) values (@id,@number_,@vehicle_registration_plate,@year_of_made,@in_operation_from,@in_operation_to,@is_low_rise,@have_air_conditioning,@producer_id,@mean_of_transport_id,@subtype_mean_of_transport_id,@owner_id,@vehicle_id,@direction_of_vehicle)", connection);
                for (int i = 0; i < list.Count; i++)
                {
                    insert_command.Parameters.AddWithValue("@id", list[i].Id);
                    insert_command.Parameters.AddWithValue("@number_", list[i].Number_);
                    insert_command.Parameters.AddWithValue("@vehicle_registration_plate", list[i].Vehicle_registration_plate);
                    insert_command.Parameters.AddWithValue("@year_of_made", list[i].Year_of_made);
                    insert_command.Parameters.AddWithValue("@in_operation_from", list[i].In_operation_from.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
                    insert_command.Parameters.AddWithValue("@in_operation_to", list[i].In_operation_to.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
                    insert_command.Parameters.AddWithValue("@is_low_rise", list[i].Is_low_rise);
                    insert_command.Parameters.AddWithValue("@have_air_conditioning", list[i].Have_air_conditioning);
                    insert_command.Parameters.AddWithValue("@producer_id", list[i].Producer_id);
                    insert_command.Parameters.AddWithValue("@mean_of_transport_id", list[i].Mean_of_transport_id);
                    insert_command.Parameters.AddWithValue("@subtype_mean_of_transport_id", list[i].Subtype_mean_of_transport_id);
                    insert_command.Parameters.AddWithValue("@owner_id", list[i].Owner_id);
                    insert_command.Parameters.AddWithValue("@vehicle_id", list[i].Vehicle_id);
                    insert_command.Parameters.AddWithValue("@direction_of_vehicle", list[i].Direction_of_vehicle);
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
        public string new_vehicle(Vehicle vehicle)
        {
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                MySqlCommand insert_command = new MySqlCommand("insert into vehicle (number_,vehicle_registration_plate,year_of_made,in_operation_from,in_operation_to,is_low_rise,have_air_conditioning,producer_id,mean_of_transport_id,subtype_mean_of_transport_id,owner_id,direction_of_vehicle) values (@number_,@vehicle_registration_plate,@year_of_made,@in_operation_from,@in_operation_to,@is_low_rise,@have_air_conditioning,@producer_id,@mean_of_transport_id,@subtype_mean_of_transport_id,@owner_id,@direction_of_vehicle)", connection);
                insert_command.Parameters.AddWithValue("@number_", vehicle.Number_);
                insert_command.Parameters.AddWithValue("@vehicle_registration_plate", vehicle.Vehicle_registration_plate);
                insert_command.Parameters.AddWithValue("@year_of_made", vehicle.Year_of_made);
                insert_command.Parameters.AddWithValue("@in_operation_from", vehicle.In_operation_from.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
                insert_command.Parameters.AddWithValue("@in_operation_to", vehicle.In_operation_to.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
                insert_command.Parameters.AddWithValue("@is_low_rise", vehicle.Is_low_rise);
                insert_command.Parameters.AddWithValue("@have_air_conditioning", vehicle.Have_air_conditioning);
                insert_command.Parameters.AddWithValue("@producer_id", vehicle.Producer_id);
                insert_command.Parameters.AddWithValue("@mean_of_transport_id", vehicle.Mean_of_transport_id);
                insert_command.Parameters.AddWithValue("@subtype_mean_of_transport_id", vehicle.Subtype_mean_of_transport_id);
                insert_command.Parameters.AddWithValue("@owner_id", vehicle.Owner_id);
                insert_command.Parameters.AddWithValue("@direction_of_vehicle", vehicle.Direction_of_vehicle);
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
        public string new_vehicle_with_predecessor(Vehicle vehicle)
        {
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                MySqlCommand insert_command = new MySqlCommand("insert into vehicle (number_,vehicle_registration_plate,year_of_made,in_operation_from,in_operation_to,is_low_rise,have_air_conditioning,producer_id,mean_of_transport_id,subtype_mean_of_transport_id,owner_id,vehicle_id,direction_of_vehicle) values (@number_,@vehicle_registration_plate,@year_of_made,@in_operation_from,@in_operation_to,@is_low_rise,@have_air_conditioning,@producer_id,@mean_of_transport_id,@subtype_mean_of_transport_id,@owner_id,@vehicle_id,@direction_of_vehicle)", connection);
                insert_command.Parameters.AddWithValue("@number_", vehicle.Number_);
                insert_command.Parameters.AddWithValue("@vehicle_registration_plate", vehicle.Vehicle_registration_plate);
                insert_command.Parameters.AddWithValue("@year_of_made", vehicle.Year_of_made);
                insert_command.Parameters.AddWithValue("@in_operation_from", vehicle.In_operation_from.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
                insert_command.Parameters.AddWithValue("@in_operation_to", vehicle.In_operation_to.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
                insert_command.Parameters.AddWithValue("@is_low_rise", vehicle.Is_low_rise);
                insert_command.Parameters.AddWithValue("@have_air_conditioning", vehicle.Have_air_conditioning);
                insert_command.Parameters.AddWithValue("@producer_id", vehicle.Producer_id);
                insert_command.Parameters.AddWithValue("@mean_of_transport_id", vehicle.Mean_of_transport_id);
                insert_command.Parameters.AddWithValue("@subtype_mean_of_transport_id", vehicle.Subtype_mean_of_transport_id);
                insert_command.Parameters.AddWithValue("@owner_id", vehicle.Owner_id);
                insert_command.Parameters.AddWithValue("@vehicle_id", vehicle.Vehicle_id);
                insert_command.Parameters.AddWithValue("@direction_of_vehicle", vehicle.Direction_of_vehicle);
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
        public string update_vehicle(Vehicle vehicle)
        {
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                MySqlCommand update_command = new MySqlCommand("update vehicle set number_=@number_,vehicle_registration_plate=@vehicle_registration_plate,year_of_made=@year_of_made,in_operation_from=@in_operation_from,in_operation_to=@in_operation_to,is_low_rise=@is_low_rise,have_air_conditioning=@have_air_conditioning,producer_id=@producer_id,mean_of_transport_id=@mean_of_transport_id,subtype_mean_of_transport_id=@subtype_mean_of_transport_id,owner_id=@owner_id,vehicle_id=null,direction_of_vehicle=@direction_of_vehicle where id = @id", connection);
                update_command.Parameters.AddWithValue("@id", vehicle.Id);
                update_command.Parameters.AddWithValue("@number_", vehicle.Number_);
                update_command.Parameters.AddWithValue("@vehicle_registration_plate", vehicle.Vehicle_registration_plate);
                update_command.Parameters.AddWithValue("@year_of_made", vehicle.Year_of_made);
                update_command.Parameters.AddWithValue("@in_operation_from", vehicle.In_operation_from.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
                update_command.Parameters.AddWithValue("@in_operation_to", vehicle.In_operation_to.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
                update_command.Parameters.AddWithValue("@is_low_rise", vehicle.Is_low_rise);
                update_command.Parameters.AddWithValue("@have_air_conditioning", vehicle.Have_air_conditioning);
                update_command.Parameters.AddWithValue("@producer_id", vehicle.Producer_id);
                update_command.Parameters.AddWithValue("@mean_of_transport_id", vehicle.Mean_of_transport_id);
                update_command.Parameters.AddWithValue("@subtype_mean_of_transport_id", vehicle.Subtype_mean_of_transport_id);
                update_command.Parameters.AddWithValue("@owner_id", vehicle.Owner_id);
                update_command.Parameters.AddWithValue("@direction_of_vehicle", vehicle.Direction_of_vehicle);
                update_command.ExecuteNonQuery();
                connection.Close();
                return "Upraveno";
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
        public string update_vehicle_with_predecessor(Vehicle vehicle)
        {
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                MySqlCommand update_command = new MySqlCommand("update vehicle set number_=@number_,vehicle_registration_plate=@vehicle_registration_plate,year_of_made=@year_of_made,in_operation_from=@in_operation_from,in_operation_to=@in_operation_to,is_low_rise=@is_low_rise,have_air_conditioning=@have_air_conditioning,producer_id=@producer_id,mean_of_transport_id=@mean_of_transport_id,subtype_mean_of_transport_id=@subtype_mean_of_transport_id,owner_id=@owner_id,vehicle_id=@vehicle_id,direction_of_vehicle=@direction_of_vehicle where id = @id", connection);
                update_command.Parameters.AddWithValue("@id", vehicle.Id);
                update_command.Parameters.AddWithValue("@number_", vehicle.Number_);
                update_command.Parameters.AddWithValue("@vehicle_registration_plate", vehicle.Vehicle_registration_plate);
                update_command.Parameters.AddWithValue("@year_of_made", vehicle.Year_of_made);
                update_command.Parameters.AddWithValue("@in_operation_from", vehicle.In_operation_from.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
                update_command.Parameters.AddWithValue("@in_operation_to", vehicle.In_operation_to.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
                update_command.Parameters.AddWithValue("@is_low_rise", vehicle.Is_low_rise);
                update_command.Parameters.AddWithValue("@have_air_conditioning", vehicle.Have_air_conditioning);
                update_command.Parameters.AddWithValue("@producer_id", vehicle.Producer_id);
                update_command.Parameters.AddWithValue("@mean_of_transport_id", vehicle.Mean_of_transport_id);
                update_command.Parameters.AddWithValue("@subtype_mean_of_transport_id", vehicle.Subtype_mean_of_transport_id);
                update_command.Parameters.AddWithValue("@owner_id", vehicle.Owner_id);
                update_command.Parameters.AddWithValue("@vehicle_id", vehicle.Vehicle_id);
                update_command.Parameters.AddWithValue("@direction_of_vehicle", vehicle.Direction_of_vehicle);
                update_command.ExecuteNonQuery();
                connection.Close();
                return "Upraveno";
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
    }
}