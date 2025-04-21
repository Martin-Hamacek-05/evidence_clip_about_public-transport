using evidence_clip_about_public_transport.Database_connection;
using evidence_clip_about_public_transport.Entits;
using evidence_clip_about_public_transport.exceptions;
using MySql.Data.MySqlClient;
using ScottPlot.Colormaps;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* author: Martin Hamacek */
namespace evidence_clip_about_public_transport.DAO.mysql.for_pattern
{
    /// <summary>
    /// This class is implent of interface I_DAO_Pattern for MySQL server
    /// </summary>
    public class DAO_Pattern_implement : I_DAO_Pattern
    {

        public string delete_pattern(int id)
        {
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                MySqlCommand insert_command = new MySqlCommand("delete from pattern where id = @id", connection);
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

        public List<Pattern> get_all_for_backup()
        {
            List<Pattern> pattern = new List<Pattern>();
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("select * from pattern", connection);


                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    pattern.Add(new Pattern(reader.GetInt32(0), reader.GetString(1), reader.GetString(2)));
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

        public DataSet get_all_patterns()
        {
            try
            {
                MySqlDataAdapter adapterII = new MySqlDataAdapter("select * from pattern ", Database_connect.myssql_connection());
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

        public Pattern get_pattern(int id)
        {
            Pattern pattern = null;
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("select * from pattern where id = @id", connection);
                cmd.Parameters.AddWithValue("@id", id);


                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    pattern = new Pattern(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                }
                connection.Close();
                return pattern;


            }
            catch (MySqlException e)
            {
                Work_with_expection.sql_exception_of_code(e.Number);
                return new Pattern();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Došlo k neočekavané chybě: \n" + exc.ToString());
                return new Pattern();
            }
        }

        public string load_file(List<Pattern> list)
        {
            MySqlTransaction mySqlTransaction = null;
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();

                connection.Open();

                mySqlTransaction = connection.BeginTransaction();
                MySqlCommand insert_command = new MySqlCommand("insert into pattern(id,name_of_pattern,note) values (@id,@name_of_pattern,@note)", connection);

                for (int i = 0; i < list.Count; i++)
                {
                    insert_command.Parameters.AddWithValue("@id", list[i].Id);
                    insert_command.Parameters.AddWithValue("@name_of_pattern", list[i].Name_of_pattern);
                    insert_command.Parameters.AddWithValue("@note", list[i].Note);

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

        public string new_pattern(Pattern pattern)
        {
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                MySqlCommand insert_command = new MySqlCommand("insert into pattern(name_of_pattern,note) values (@name_of_pattern,@note)", connection);
                insert_command.Parameters.AddWithValue("@name_of_pattern", pattern.Name_of_pattern);
                insert_command.Parameters.AddWithValue("@note", pattern.Note);

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

        public string update_pattern(Pattern pattern)
        {
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                MySqlCommand update_command = new MySqlCommand("update pattern set name_of_pattern = @name_of_pattern,note = @note where id = @id", connection);
                update_command.Parameters.AddWithValue("@name_of_pattern", pattern.Name_of_pattern);
                update_command.Parameters.AddWithValue("@note", pattern.Note);
                update_command.Parameters.AddWithValue("@id", pattern.Id);

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
