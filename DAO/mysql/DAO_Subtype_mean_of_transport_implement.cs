using evidence_clip_about_public_transport.Database_connection;
using evidence_clip_about_public_transport.Entits;
using evidence_clip_about_public_transport.exceptions;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Author: Martin Hamacek
namespace evidence_clip_about_public_transport.DAO.mysql.for_subtype_mean_of_transport
{
    /// <summary>
    /// This class is implent of interface I_DAO_Subtype_mean_of_transport for MySQL server
    /// </summary>
    public class DAO_Subtype_mean_of_transport_implement : I_DAO_Subtype_mean_of_transport
    {

        public string delete_subtype_mean_of_transport(int id)
        {
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                MySqlCommand delete_command = new MySqlCommand("delete from subtype_mean_of_transport where id = @id", connection);
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

        public CheckedListBox get_distict_subtype_mean_of_public_transport()
        {
            CheckedListBox distict_subtype_mean_of_transport = new CheckedListBox();
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("select distinct subtype_mean_of_transport from info_from_clip_for_filter order by subtype_mean_of_transport", connection);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    distict_subtype_mean_of_transport.Items.Add(reader.GetString(0));

                }
                connection.Close();
                return distict_subtype_mean_of_transport;
            }
            catch (MySqlException e)
            {
                Work_with_expection.sql_exception_of_code(e.Number);
                return distict_subtype_mean_of_transport;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Došlo k neočekavané chybě: \n" + exc.ToString());
                return distict_subtype_mean_of_transport;
            }
        }

        public DataSet get_all_subtype_mean_of_transport()
        {
            try
            {
                MySqlDataAdapter adapterII = new MySqlDataAdapter("select main_.id,main_.name_,hiearch_.name_ as subtype\r\nfrom subtype_mean_of_transport as main_\r\nleft join subtype_mean_of_transport as hiearch_ on main_.subtype_mean_of_transport_id = hiearch_.id\r\norder by main_.name_;", Database_connect.myssql_connection());
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

        public Subtype_mean_of_transport get_subtype_mean_of_transport(int id)
        {
            Subtype_mean_of_transport subtype_mean_of_transport = null;
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("select * from subtype_mean_of_transport where id = @id", connection);
                cmd.Parameters.AddWithValue("@id", id);


                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    subtype_mean_of_transport = new Subtype_mean_of_transport(reader.GetInt32(0), reader.GetString(1), 0);

                }
                connection.Close();
                return subtype_mean_of_transport;


            }
            catch (MySqlException e)
            {
                Work_with_expection.sql_exception_of_code(e.Number);
                return new Subtype_mean_of_transport();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Došlo k neočekavané chybě: \n" + exc.ToString());
                return new Subtype_mean_of_transport();
            }
        }

        public string new_subtype_mean_of_transport(Subtype_mean_of_transport subtype_Mean_Of_Transport)
        {
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                MySqlCommand insert_command = new MySqlCommand("insert into subtype_mean_of_transport(name_) values (@name_)", connection);
                insert_command.Parameters.AddWithValue("@name_", subtype_Mean_Of_Transport.Name_);


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

        public string new_subtype_mean_of_transport_with_predecessor(Subtype_mean_of_transport subtype_Mean_Of_Transport)
        {
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                MySqlCommand insert_command = new MySqlCommand("insert into subtype_mean_of_transport(name_,subtype_mean_of_transport_id) values (@name_,@subtype_mean_of_transport_id)", connection);
                insert_command.Parameters.AddWithValue("@name_", subtype_Mean_Of_Transport.Name_);
                insert_command.Parameters.AddWithValue("@subtype_mean_of_transport_id", subtype_Mean_Of_Transport.Subtype_mean_of_transport_id);

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

        public string update_subtype_mean_of_transport(Subtype_mean_of_transport subtype_Mean_Of_Transport)
        {
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                MySqlCommand update_command = new MySqlCommand("update subtype_mean_of_transport set name_=@name_,subtype_mean_of_transport_id=null where id = @id", connection);
                update_command.Parameters.AddWithValue("@name_", subtype_Mean_Of_Transport.Name_);
                update_command.Parameters.AddWithValue("@id", subtype_Mean_Of_Transport.Id);

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

        public string update_subtype_mean_of_transport_with_predecessor(Subtype_mean_of_transport subtype_Mean_Of_Transport)
        {
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                MySqlCommand update_command = new MySqlCommand("update subtype_mean_of_transport set name_=@name_, subtype_mean_of_transport_id=@subtype_mean_of_transport_id where id = @id", connection);
                update_command.Parameters.AddWithValue("@name_", subtype_Mean_Of_Transport.Name_);
                update_command.Parameters.AddWithValue("@subtype_mean_of_transport_id", subtype_Mean_Of_Transport.Subtype_mean_of_transport_id);
                update_command.Parameters.AddWithValue("@id", subtype_Mean_Of_Transport.Id);

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

        public List<Subtype_mean_of_transport> get_all_for_backup()
        {
            List<Subtype_mean_of_transport> backup = new List<Subtype_mean_of_transport>();

            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("select * from subtype_mean_of_transport", connection);



                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (reader[2] == DBNull.Value)
                    {
                        backup.Add(new Subtype_mean_of_transport(reader.GetInt32(0), reader.GetString(1), 0));
                    }
                    else
                    {
                        backup.Add(new Subtype_mean_of_transport(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2)));
                    }


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

        public string load_file(List<Subtype_mean_of_transport> lines)
        {
            MySqlTransaction mySqlTransaction = null;
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();

                connection.Open();

                mySqlTransaction = connection.BeginTransaction();
                MySqlCommand insert_command = new MySqlCommand("SET FOREIGN_KEY_CHECKS=0;  insert into subtype_mean_of_transport(id,name_,subtype_mean_of_transport_id) values (@id,@name_,@subtype_mean_of_transport_id)", connection);

                for (int i = 0; i < lines.Count; i++)
                {
                    insert_command.Parameters.AddWithValue("@id", lines[i].Id);
                    insert_command.Parameters.AddWithValue("@name_", lines[i].Name_);
                    insert_command.Parameters.AddWithValue("@subtype_mean_of_transport_id", lines[i].Subtype_mean_of_transport_id);

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
