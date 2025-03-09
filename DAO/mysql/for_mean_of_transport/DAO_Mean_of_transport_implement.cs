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
using evidence_clip_about_public_transport.exceptions;
/* author: Martin Hamacek, C4c, 2024/2025 */
namespace evidence_clip_about_public_transport.DAO.mysql.for_mean_of_transport
{
    public class DAO_Mean_of_transport_implement : I_DAO_Mean_of_transport
    {
        public string delete_mean_of_transport(int id)
        {
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                MySqlCommand insert_command = new MySqlCommand("delete from mean_of_transport where id = @id", connection);
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

        public CheckedListBox get_distict_mean_of_public_transport()
        {
            CheckedListBox distict_mean_of_transport = new CheckedListBox();
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("select distinct mean_of_transport from info_from_clip_for_filter order by mean_of_transport", connection);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    distict_mean_of_transport.Items.Add(reader.GetString(0));

                }
                connection.Close();
                return distict_mean_of_transport;
            }
            catch (MySqlException e)
            {
                Work_with_expection.sql_exception_of_code(e.Number);
                return distict_mean_of_transport;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Došlo k neočekavané chybě: \n" + exc.ToString());
                return distict_mean_of_transport;
            }
        }

        public DataSet get_all_mean_of_transport()
        {
            try
            {
                MySqlDataAdapter adapterII = new MySqlDataAdapter("select * from mean_of_transport ", Database_connect.myssql_connection());
                DataSet dataSet_of_mean_of_transport = new DataSet();
                adapterII.Fill(dataSet_of_mean_of_transport);
                return dataSet_of_mean_of_transport;
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

        public Mean_of_transport get_mean_of_transport(int id)
        {
            Mean_of_transport mean_of_transport = null;
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("select * from mean_of_transport where id = @id", connection);
                cmd.Parameters.AddWithValue("@id", id);


                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    mean_of_transport = new Mean_of_transport(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                }
                connection.Close();
                return mean_of_transport;


            }
            catch (MySqlException e)
            {
                Work_with_expection.sql_exception_of_code(e.Number);
                return new Mean_of_transport();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Došlo k neočekavané chybě: \n" + exc.ToString());
                return new Mean_of_transport();
            }
        }

        public string new_mean_of_transport(Mean_of_transport mean_of_transport)
        {
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                MySqlCommand insert_command = new MySqlCommand("insert into mean_of_transport(name_,short_name) values (@name_,@short_name)", connection);
                insert_command.Parameters.AddWithValue("@name_", mean_of_transport.Name_);
                insert_command.Parameters.AddWithValue("@short_name", mean_of_transport.Short_name);

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

        public string update_mean_of_transport(Mean_of_transport mean_of_transport)
        {
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                MySqlCommand update_command = new MySqlCommand("update mean_of_transport set name_=@name_,short_name=@short_name where id=@id", connection);
                update_command.Parameters.AddWithValue("@id", mean_of_transport.Id);
                update_command.Parameters.AddWithValue("@name_", mean_of_transport.Name_);
                update_command.Parameters.AddWithValue("@short_name", mean_of_transport.Short_name);

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

        public List<Mean_of_transport> get_all_for_backup()
        {
            List<Mean_of_transport> mean_of_transport = new List<Mean_of_transport>();
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("select * from mean_of_transport", connection);


                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    mean_of_transport.Add(new Mean_of_transport(reader.GetInt32(0), reader.GetString(1), reader.GetString(2)));
                }
                connection.Close();
                return mean_of_transport;


            }
            catch (MySqlException e)
            {
                Work_with_expection.sql_exception_of_code(e.Number);
                return mean_of_transport;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Došlo k neočekavané chybě: \n" + exc.ToString());
                return mean_of_transport;
            }
        }

        public string load_file(List<Mean_of_transport> lines)
        {
            MySqlTransaction mySqlTransaction = null;
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();

                connection.Open();

                mySqlTransaction = connection.BeginTransaction();
                MySqlCommand insert_command = new MySqlCommand("insert into mean_of_transport(id,name_,short_name) values (@id,@name_,@short_name)", connection);

                for (int i = 0; i < lines.Count; i++)
                {
                    insert_command.Parameters.AddWithValue("@id", lines[i].Id);
                    insert_command.Parameters.AddWithValue("@name_", lines[i].Name_);
                    insert_command.Parameters.AddWithValue("@short_name", lines[i].Short_name);

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
