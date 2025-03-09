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
/* author@ Martin Hamacek, C4c, 2024/2025 */
namespace evidence_clip_about_public_transport.DAO.mysql.for_owner
{
    public class DAO_Owner_implement : I_DAO_Owner
    {

        public string delete_owner(int id)
        {
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                MySqlCommand insert_command = new MySqlCommand("delete from owner_ where id = @id", connection);
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
                return "Došlo k neočekavané chybě@ \n" + exc.ToString();
            }

        }

        public CheckedListBox get_distict_owners()
        {
            CheckedListBox distict_onwers = new CheckedListBox();
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("select distinct owner_name from info_from_clip_for_filter order by owner_name", connection);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    distict_onwers.Items.Add(reader.GetString(0));

                }
                connection.Close();
                return distict_onwers;
            }
            catch (MySqlException e)
            {
                Work_with_expection.sql_exception_of_code(e.Number);
                return distict_onwers;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Došlo k neočekavané chybě@ \n" + exc.ToString());
                return distict_onwers;
            }
        }

        public DataSet get_all_owners()
        {
            try
            {
                MySqlDataAdapter adapterII = new MySqlDataAdapter("select * from owner_ ", Database_connect.myssql_connection());
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
                MessageBox.Show("Došlo k neočekavané chybě@ \n" + exc.ToString());
                return new DataSet();
            }
        }

        public Owner_ get_owner(int id)
        {
            Owner_ mean_of_transport = null;
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("select * from owner_ where id = @id", connection);
                cmd.Parameters.AddWithValue("@id", id);


                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    mean_of_transport = new Owner_(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
                }
                connection.Close();
                return mean_of_transport;


            }
            catch (MySqlException e)
            {
                Work_with_expection.sql_exception_of_code(e.Number);
                return new Owner_();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Došlo k neočekavané chybě@ \n" + exc.ToString());
                return new Owner_();
            }
        }

        public string new_owner(Owner_ owner)
        {
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                MySqlCommand insert_command = new MySqlCommand("insert into owner_(name_,headquarters,note) values (@name_,@headquarters,@note)", connection);
                insert_command.Parameters.AddWithValue("@name_", owner.Name_);
                insert_command.Parameters.AddWithValue("@headquarters", owner.Headquarters);
                insert_command.Parameters.AddWithValue("@note", owner.Note);

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
                return "Došlo k neočekavané chybě@ \n" + exc.ToString();
            }
        }

        public string update_owner(Owner_ owner)
        {
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                MySqlCommand update_command = new MySqlCommand("update owner_ set name_=@name_,headquarters=@headquarters,note=@note where id=@id", connection);

                update_command.Parameters.AddWithValue("@name_", owner.Name_);
                update_command.Parameters.AddWithValue("@headquarters", owner.Headquarters);
                update_command.Parameters.AddWithValue("@note", owner.Note);
                update_command.Parameters.AddWithValue("@id", owner.Id);

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
                return "Došlo k neočekavané chybě@ \n" + exc.ToString();
            }
        }

        public List<Owner_> get_all_for_backup()
        {
            List<Owner_> mean_of_transport = new List<Owner_>();
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("select * from owner_", connection);



                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    mean_of_transport.Add(new Owner_(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3)));
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
                MessageBox.Show("Došlo k neočekavané chybě@ \n" + exc.ToString());
                return mean_of_transport;
            }
        }

        public string load_file(List<Owner_> lines)
        {
            MySqlTransaction MySqlTransaction = null;
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();

                connection.Open();

                MySqlTransaction = connection.BeginTransaction();
                MySqlCommand insert_command = new MySqlCommand("insert into owner_(id,name_,headquarters,note) values (@id,@name_,@headquarters,@note)", connection);

                for (int i = 0; i < lines.Count; i++)
                {
                    insert_command.Parameters.AddWithValue("@id", lines[i].Id);
                    insert_command.Parameters.AddWithValue("@name_", lines[i].Name_);
                    insert_command.Parameters.AddWithValue("@headquarters",lines[i].Headquarters);
                    insert_command.Parameters.AddWithValue("@note",lines[i].Note);

                    insert_command.ExecuteNonQuery();
                    insert_command.Parameters.Clear();
                }
                MySqlTransaction.Commit();

                connection.Close();
                return "Nahráno";
            }
            catch (Exception exc)
            {
                try
                {
                    MySqlTransaction.Rollback();
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
