using evidence_clip_about_public_transport.Database_connection;
using evidence_clip_about_public_transport.Enums;
using evidence_clip_about_public_transport.Entits;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using evidence_clip_about_public_transport.exceptions;

namespace evidence_clip_about_public_transport.DAO.mysql.for_stop
{
    public class DAO_Stop_implement : I_DAO_Stop
    {


        public string delete_stop(int id)
        {
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                MySqlCommand insert_command = new MySqlCommand("delete from stop_ where id = @id", connection);
                insert_command.Parameters.AddWithValue("@id", id);


                insert_command.ExecuteNonQuery();
                connection.Close();
                return "Smazáno";
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

        public CheckedListBox get_distict_stop()
        {
            CheckedListBox distict_stop = new CheckedListBox();
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("select distinct name_of_stop from info_from_clip_for_filter order by name_of_stop", connection);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    distict_stop.Items.Add(reader.GetString(0));

                }
                connection.Close();
                return distict_stop;
            }
            catch (MySqlException e)
            {
                Work_with_expection.sql_exception_of_code(e.Number);
                return distict_stop;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Došlo k neočekavané chybě: \n" + exc.ToString());
                return distict_stop;
            }
        }

        public DataSet get_all_stops()
        {
            try
            {
                MySqlDataAdapter adapterII = new MySqlDataAdapter("select * from stop_ order by name_of_stop", Database_connect.myssql_connection());
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

        public Stop_ get_stop(int id)
        {
            Stop_ loaded_stop = null;
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("select * from stop_ where id = @id", connection);
                cmd.Parameters.AddWithValue("@id", id);


                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    loaded_stop = new Stop_(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetBoolean(5), reader.GetBoolean(6), reader.GetString(7));
                }
                connection.Close();
                return loaded_stop;


            }
            catch (MySqlException e)
            {
                Work_with_expection.sql_exception_of_code(e.Number);
                return new Stop_();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Došlo k neočekavané chybě: \n" + exc.ToString());
                return new Stop_();
            }
        }

        public string new_stop(Stop_ stop)
        {
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                MySqlCommand insert_command = new MySqlCommand("insert into stop_(name_of_stop,number_of_stop,platform,direction,is_operation,is_low_rise,note) values (@name_of_stop,@number_of_stop,@platform,@direction,@is_operation,@is_low_rise,@note)", connection);
                insert_command.Parameters.AddWithValue("@name_of_stop", stop.Name_of_stop);
                insert_command.Parameters.AddWithValue("@number_of_stop", stop.Number_of_stop);
                insert_command.Parameters.AddWithValue("@platform", stop.Platform);
                insert_command.Parameters.AddWithValue("@direction", stop.Direction);
                insert_command.Parameters.AddWithValue("@is_operation", stop.Is_operation);
                insert_command.Parameters.AddWithValue("@is_low_rise", stop.Is_low_rise);
                insert_command.Parameters.AddWithValue("@note", stop.Note);

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

        public string update_stop(Stop_ stop)
        {
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                MySqlCommand insert_command = new MySqlCommand("update stop_ set name_of_stop=@name_of_stop,number_of_stop=@number_of_stop,platform=@platform,direction=@direction,is_operation=@is_operation,is_low_rise=@is_low_rise,note = @note where id = @id", connection);
                insert_command.Parameters.AddWithValue("@id", stop.Id);
                insert_command.Parameters.AddWithValue("@name_of_stop", stop.Name_of_stop);
                insert_command.Parameters.AddWithValue("@number_of_stop", stop.Number_of_stop);
                insert_command.Parameters.AddWithValue("@platform", stop.Platform);
                insert_command.Parameters.AddWithValue("@direction", stop.Direction);
                insert_command.Parameters.AddWithValue("@is_operation", stop.Is_operation);
                insert_command.Parameters.AddWithValue("@is_low_rise", stop.Is_low_rise);
                insert_command.Parameters.AddWithValue("@note", stop.Note);

                insert_command.ExecuteNonQuery();
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

        public List<Stop_> get_all_for_backup()
        {
            List<Stop_> backup = new List<Stop_>();

            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("select * from stop_", connection);



                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    backup.Add(new Stop_(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetBoolean(5), reader.GetBoolean(6), reader.GetString(7)));

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

        public string mass_rename_stop(string previours_name, string new_name)
        {
            List<int> loaded_id = new List<int>();
            MySqlTransaction mySqlTransaction = null;
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();


                MySqlCommand select_id_of_selected_stop = new MySqlCommand("select id from stop_ where name_of_stop=@name_", connection);
                select_id_of_selected_stop.Parameters.AddWithValue("@name_", previours_name);


                MySqlDataReader reader = select_id_of_selected_stop.ExecuteReader();

                while (reader.Read())
                {
                    loaded_id.Add(reader.GetInt32(0));
                }
                connection.Close();
                connection.Open();

                mySqlTransaction = connection.BeginTransaction();
                MySqlCommand update_command = new MySqlCommand("update stop_ set name_of_stop=@name_ where id = @id", connection);

                for (int i = 0; i < loaded_id.Count; i++)
                {
                    update_command.Parameters.AddWithValue("@name_", new_name);
                    update_command.Parameters.AddWithValue("@id", loaded_id[i]);
                    update_command.ExecuteNonQuery();
                    update_command.Parameters.Clear();
                    //MessageBox.Show("Upsáno");
                }

                mySqlTransaction.Commit();

                connection.Close();
                return "Přejmenováno";
            }
            catch (Exception exc)
            {
                loaded_id = null;
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

        public string load_file(List<Stop_> stops)
        {
            MySqlTransaction mySqlTransaction = null;
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();

                connection.Open();

                mySqlTransaction = connection.BeginTransaction();
                MySqlCommand insert_command = new MySqlCommand("insert into stop_(id,name_of_stop,number_of_stop,platform,direction,is_operation,is_low_rise,note) values (@id,@name_of_stop,@number_of_stop,@platform,@direction,@is_operation,@is_low_rise,@note)", connection);

                for (int i = 0; i < stops.Count; i++)
                {
                    insert_command.Parameters.AddWithValue("@id", stops[i].Id);
                    insert_command.Parameters.AddWithValue("@name_of_stop", stops[i].Name_of_stop);
                    insert_command.Parameters.AddWithValue("@number_of_stop", stops[i].Number_of_stop);
                    insert_command.Parameters.AddWithValue("@platform", stops[i].Platform);
                    insert_command.Parameters.AddWithValue("@direction", stops[i].Direction);
                    insert_command.Parameters.AddWithValue("@is_operation", stops[i].Is_operation);
                    insert_command.Parameters.AddWithValue("@is_low_rise", stops[i].Is_low_rise);
                    insert_command.Parameters.AddWithValue("@note", stops[i].Note);
                    insert_command.ExecuteNonQuery();
                    insert_command.Parameters.Clear();
                    //MessageBox.Show("Upsáno");

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
