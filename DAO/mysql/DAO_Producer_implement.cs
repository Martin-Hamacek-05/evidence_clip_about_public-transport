using evidence_clip_about_public_transport.Database_connection;
using evidence_clip_about_public_transport.Entits;
using evidence_clip_about_public_transport.exceptions;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* author: Martin Hamacek */
namespace evidence_clip_about_public_transport.DAO.mysql.for_producer
{

    /// <summary>
    /// This class is implent of interface I_DAO_Producer for MySQL server
    /// </summary>
    public class DAO_Producer_implement : I_DAO_Producer
    {
        public string delete_producer(int id)
        {
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                MySqlCommand delete_command = new MySqlCommand("delete from producer where id = @id", connection);
                delete_command.Parameters.AddWithValue("@id", id);


                delete_command.ExecuteNonQuery();
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

        public CheckedListBox get_distict_producers()
        {
            CheckedListBox distict_producers = new CheckedListBox();
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("select distinct producer from info_from_clip_for_filter order by producer", connection);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    distict_producers.Items.Add(reader.GetString(0));

                }
                connection.Close();
                return distict_producers;
            }
            catch (MySqlException e)
            {
                Work_with_expection.sql_exception_of_code(e.Number);
                return distict_producers;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Došlo k neočekavané chybě: \n" + exc.ToString());
                return distict_producers;
            }
        }

        public DataSet get_all_producers()
        {
            try
            {
                MySqlDataAdapter adapterII = new MySqlDataAdapter("select * from producer ", Database_connect.myssql_connection());
                DataSet dataSet_of_mean_of_onwer = new DataSet();
                adapterII.Fill(dataSet_of_mean_of_onwer);
                return dataSet_of_mean_of_onwer;
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

        public Producer get_producer(int id)
        {
            Producer producer = null;
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("select * from producer where id = @id", connection);
                cmd.Parameters.AddWithValue("@id", id);


                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    producer = new Producer(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
                }
                connection.Close();
                return producer;


            }
            catch (MySqlException e)
            {
                Work_with_expection.sql_exception_of_code(e.Number);
                return new Producer();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Došlo k neočekavané chybě: \n" + exc.ToString());
                return new Producer();
            }
        }

        public string new_producer(Producer producer)
        {
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                MySqlCommand insert_command = new MySqlCommand("insert into producer(name_,headquarters,note) values (@name_,@headquarters,@note)", connection);
                insert_command.Parameters.AddWithValue("@name_", producer.Name_);
                insert_command.Parameters.AddWithValue("@headquarters", producer.Headquarters);
                insert_command.Parameters.AddWithValue("@note", producer.Note);

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

        public string update_producer(Producer producer)
        {
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                MySqlCommand update_command = new MySqlCommand("update producer set name_=@name_,headquarters=@headquarters,note=@note where id=@id", connection);
                update_command.Parameters.AddWithValue("@id", producer.Id);
                update_command.Parameters.AddWithValue("@name_", producer.Name_);
                update_command.Parameters.AddWithValue("@headquarters", producer.Headquarters);
                update_command.Parameters.AddWithValue("@note", producer.Note);

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

        public List<Producer> get_all_for_backup()
        {
            List<Producer> backup = new List<Producer>();

            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("select * from producer", connection);



                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    backup.Add(new Producer(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3)));

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

        public string load_file(List<Producer> list)
        {
            MySqlTransaction mySqlTransaction = null;
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();

                connection.Open();

                mySqlTransaction = connection.BeginTransaction();
                MySqlCommand insert_command = new MySqlCommand("insert into producer(id,name_,headquarters,note) values (@id,@name_,@headquarters,@note)", connection);

                for (int i = 0; i < list.Count; i++)
                {
                    insert_command.Parameters.AddWithValue("@id", list[i].Id);
                    insert_command.Parameters.AddWithValue("@name_", list[i].Name_);
                    insert_command.Parameters.AddWithValue("@headquarters", list[i].Headquarters);
                    insert_command.Parameters.AddWithValue("@note", list[i].Note);

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
