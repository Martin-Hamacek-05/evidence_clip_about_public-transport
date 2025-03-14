using evidence_clip_about_public_transport.Entits;
using evidence_clip_about_public_transport.Database_connection;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using evidence_clip_about_public_transport.exceptions;

namespace evidence_clip_about_public_transport.DAO.mysql.for_author
{
    public class DAO_Author_implement : I_DAO_Author
    {
        public void delete_author(int id)
        {

            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("delete from author where id=@id", connection);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Smazáno");

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());

            }
        }

        public DataSet get_all_authors()
        {
            try
            {
                MySqlDataAdapter adapterII = new MySqlDataAdapter("select id,login_name,is_admin,message,email,date_created,count_of_access,'************' as user_password from author", Database_connect.myssql_connection());
                DataSet dataSet_of_formaats = new DataSet();
                adapterII.Fill(dataSet_of_formaats);
                return dataSet_of_formaats;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                return null;
            }
        }

        public Author set_author_for_login(Author author)
        {
            Author loaded_author = null;
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("select * from author where login_name=@login_name and user_password=@password", connection);
                cmd.Parameters.AddWithValue("@login_name", author.Login_name);
                cmd.Parameters.AddWithValue("@password", author.User_password);


                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    loaded_author = new Author(reader.GetInt32(0), reader.GetString(1), reader.GetBoolean(2), reader.GetString(3), reader.GetString(4), DateOnly.FromDateTime(reader.GetDateTime(5)), reader.GetInt32(6), reader.GetString(7));

                }
                connection.Close();
                return loaded_author;


            }
            catch (MySqlException exce)
            {
                Work_with_expection.sql_exception_of_code(exce.Number);
                return null;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
                return null;
            }
        }

        public Author get_author(int id)
        {
            Author loaded_author = null;
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("select * from author where id=@id", connection);
                cmd.Parameters.AddWithValue("@id", id);



                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    loaded_author = new Author(reader.GetInt32(0), reader.GetString(1), reader.GetBoolean(2), reader.GetString(3), reader.GetString(4), DateOnly.FromDateTime(reader.GetDateTime(5)), reader.GetInt32(6), reader.GetString(7));

                }
                connection.Close();
                return loaded_author;


            }
            catch (MySqlException exce)
            {
                Work_with_expection.sql_exception_of_code(exce.Number);
                return null;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
                return null;
            }
        }
        public void new_author(Author author)
        {
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("insert into author (login_name,is_admin,message,email,date_created,count_of_access,user_password)values(@login_name,@is_admin,@message,@email,@date_created,@count_of_access,@user_password)", connection);
                cmd.Parameters.AddWithValue("@id", author.Id);
                cmd.Parameters.AddWithValue("@login_name", author.Login_name);
                cmd.Parameters.AddWithValue("@is_admin", author.Is_admin);
                cmd.Parameters.AddWithValue("@message", author.Message);
                cmd.Parameters.AddWithValue("@email", author.Email);
                cmd.Parameters.AddWithValue("@date_created", author.Date_create.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
                cmd.Parameters.AddWithValue("@count_of_access", author.Count_of_access);
                cmd.Parameters.AddWithValue("@user_password", author.User_password);

                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Vytvořeno");
            }
            catch (MySqlException exce) 
            {
                Work_with_expection.sql_exception_of_code(exce.Number);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        public void update_author(Author author)
        {
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("update author set login_name=@login_name,is_admin=@is_admin,message=@message,email=@email,date_created=@date_created,count_of_access=@count_of_access,user_password=@user_password  where id=@id", connection);
                cmd.Parameters.AddWithValue("@id", author.Id);
                cmd.Parameters.AddWithValue("@login_name", author.Login_name);
                cmd.Parameters.AddWithValue("@is_admin", author.Is_admin);
                cmd.Parameters.AddWithValue("@message", author.Message);
                cmd.Parameters.AddWithValue("@email", author.Email);
                cmd.Parameters.AddWithValue("@date_created", author.Date_create.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
                cmd.Parameters.AddWithValue("@count_of_access", author.Count_of_access);
                cmd.Parameters.AddWithValue("@user_password", author.User_password);

                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Upraveno");
            }
            catch (MySqlException exce)
            {
                Work_with_expection.sql_exception_of_code(exce.Number);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        public void change_count_of_access(int id)
        {
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("update author set count_of_access = count_of_access+1  where id=@id", connection);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (MySqlException exce)
            {
                Work_with_expection.sql_exception_of_code(exce.Number);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        public CheckedListBox distict_author()
        {
            CheckedListBox distict_authors = new CheckedListBox();
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("select distinct author from info_from_clip_for_filter order by author", connection);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    distict_authors.Items.Add(reader.GetString(0));

                }
                connection.Close();
                return distict_authors;
            }
            catch (MySqlException exce)
            {
                Work_with_expection.sql_exception_of_code(exce.Number);
                return distict_authors;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
                return distict_authors;
            }
        }

        public List<Author> get_all_for_backup()
        {
            List<Author> backup = new List<Author>();

            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("select * from author", connection);



                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    backup.Add(new Author(reader.GetInt32(0), reader.GetString(1), reader.GetBoolean(2), reader.GetString(3), reader.GetString(4), DateOnly.FromDateTime(reader.GetDateTime(5)), reader.GetInt32(6), reader.GetString(7)));

                }
                connection.Close();
                return backup;


            }
            catch (MySqlException exce)
            {
                Work_with_expection.sql_exception_of_code(exce.Number);
                return null;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
                return null;
            }
        }

        public string load_file(List<Author> list)
        {
            MySqlTransaction mySqlTransaction = null;
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();

                connection.Open();

                mySqlTransaction = connection.BeginTransaction();
                MySqlCommand insert_command = new MySqlCommand("insert into author(id,login_name,is_admin,message,email,date_created,count_of_access,user_password) values (@id,@login_name,@is_admin,@message,@email,@date_created,@count_of_access,@user_password)", connection);

                for (int i = 0; i < list.Count; i++)
                {
                    insert_command.Parameters.AddWithValue("@id", list[i].Id);
                    insert_command.Parameters.AddWithValue("@login_name", list[i].Login_name);
                    insert_command.Parameters.AddWithValue("@is_admin", list[i].Is_admin);
                    insert_command.Parameters.AddWithValue("@message", list[i].Message);
                    insert_command.Parameters.AddWithValue("@email", list[i].Email);
                    insert_command.Parameters.AddWithValue("@date_created", list[i].Date_create.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
                    insert_command.Parameters.AddWithValue("@count_of_access", list[i].Count_of_access);
                    insert_command.Parameters.AddWithValue("@user_password", list[i].User_password);

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
