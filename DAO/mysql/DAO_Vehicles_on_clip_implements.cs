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
//Author: Martin Hamacek
namespace evidence_clip_about_public_transport.DAO.mysql.for_vehicles_on_clip
{

    /// <summary>
    /// This class is implent of interface I_DAO_Vehicles_on_clip for MySQL server
    /// </summary>
    public class DAO_Vehicles_on_clip_implements : I_DAO_Vehicles_on_clip
    {

        public string add_vehicles_to_clip(Vehicles_on_clip vehicles_On_Clip)
        {
            MySqlTransaction mySqlTransaction = null;
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();

                mySqlTransaction = connection.BeginTransaction();

                MySqlCommand insert_command = new MySqlCommand("insert into vehicles_on_clip(vehicle_id,clip_id) values (@vehicle_id,@clip_id)", connection);
                insert_command.Parameters.AddWithValue("@vehicle_id", vehicles_On_Clip.Vehicle_id);
                insert_command.Parameters.AddWithValue("@clip_id", vehicles_On_Clip.Clip_id);
                insert_command.ExecuteNonQuery();


                MySqlCommand update_command = new MySqlCommand("update clip set count_of_vehicles_on_clip = (select count(*) from vehicles_on_clip where clip_id = @id) where id = @id;", connection);
                update_command.Parameters.AddWithValue("@id", vehicles_On_Clip.Clip_id);

                update_command.ExecuteNonQuery();
                mySqlTransaction.Commit();
                connection.Close();
                return "Vloženo";
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

        public string delete_vehicle_from_clip(Vehicles_on_clip vehicles_On_Clip)
        {
            MySqlTransaction mySqlTransaction = null;
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();

                mySqlTransaction = connection.BeginTransaction();

                MySqlCommand insert_command = new MySqlCommand("delete from vehicles_on_clip where id=@id", connection);
                insert_command.Parameters.AddWithValue("@id", vehicles_On_Clip.Id);
                insert_command.ExecuteNonQuery();

                MySqlCommand update_command = new MySqlCommand("update clip set count_of_vehicles_on_clip = (select count(*) from vehicles_on_clip where clip_id = @id) where id = @id;", connection);
                update_command.Parameters.AddWithValue("@id", vehicles_On_Clip.Clip_id);
                update_command.ExecuteNonQuery();

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

        public List<Vehicles_on_clip> get_all_for_backup()
        {
            List<Vehicles_on_clip> backup = new List<Vehicles_on_clip>();

            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("select * from vehicles_on_clip", connection);



                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    backup.Add(new Vehicles_on_clip(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2)));

                }
                connection.Close();
                return backup;


            }
            catch (MySqlException e)
            {
                Work_with_expection.sql_exception_of_code(e.Number);
                return backup;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Došlo k neočekavané chybě: \n" + exc.ToString());
                return backup;
            }
        }

        public DataSet get_all_vehicles_from_list(int id)
        {
            try
            {
                string query = "select vehicles_on_clip.id,vehicle.number_, subtype_mean_of_transport.name_ as subtype,clip.name_of_clip,owner_.name_ as owner_ from vehicles_on_clip\r\n    inner join vehicle on vehicles_on_clip.vehicle_id = vehicle.id\r\n    inner join subtype_mean_of_transport on vehicle.subtype_mean_of_transport_id = subtype_mean_of_transport.id\r\n    inner join clip on vehicles_on_clip.clip_id = clip.id\r\n    inner join owner_ on vehicle.owner_id = owner_.id where clip.id=" + id;
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

        public string load_file(List<Vehicles_on_clip> list)
        {
            MySqlTransaction mySqlTransaction = null;
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                mySqlTransaction = connection.BeginTransaction();
                MySqlCommand insert_command = new MySqlCommand("insert into vehicles_on_clip(id,vehicle_id,clip_id) values (@id,@vehicle_id,@clip_id)", connection);
                for (int i = 0; i < list.Count; i++)
                {
                    insert_command.Parameters.AddWithValue("@id", list[i].Id);
                    insert_command.Parameters.AddWithValue("@vehicle_id", list[i].Vehicle_id);
                    insert_command.Parameters.AddWithValue("@clip_id", list[i].Clip_id);

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
