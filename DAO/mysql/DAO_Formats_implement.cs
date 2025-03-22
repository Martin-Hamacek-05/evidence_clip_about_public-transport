using evidence_clip_about_public_transport.Database_connection;
using evidence_clip_about_public_transport.Enums;
using evidence_clip_about_public_transport.Entits;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using evidence_clip_about_public_transport.exceptions;
/* author: Martin Hamacek, C4c, 2024/2025 */
namespace evidence_clip_about_public_transport.DAO.mysql.for_formats
{
    /// <summary>
    /// This class is implent of interface I_DAO_Formats
    /// </summary>
    public class DAO_Formats_implement : I_DAO_Formats
    {

        public string delete_format(int id)
        {
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                MySqlCommand insert_command = new MySqlCommand("delete from formats where id = @id", connection);
                insert_command.Parameters.AddWithValue("@id", id);


                insert_command.ExecuteNonQuery();
                connection.Close();
                return "Smazáno";
            }
            catch (Exception exc)
            {
                return exc.ToString();
            }
        }

        public CheckedListBox get_distict_format()
        {
            CheckedListBox distict_format = new CheckedListBox();
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("select distinct format_ from info_from_clip_for_filter order by format_", connection);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    distict_format.Items.Add(reader.GetString(0));

                }
                connection.Close();
                return distict_format;
            }
            catch (MySqlException mysql)
            {
                Work_with_expection.sql_exception_of_code(mysql.Number);
                return distict_format;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Došlo k neočekavané chybě: \n" + exc.Message);
                return distict_format;
            }
        }

        public DataSet get_all_formats()
        {
            try
            {
                MySqlDataAdapter adapterII = new MySqlDataAdapter("select * from formats ", Database_connect.myssql_connection());
                DataSet dataSet_of_formaats = new DataSet();
                adapterII.Fill(dataSet_of_formaats);
                return dataSet_of_formaats;
            }
            catch (MySqlException mysql)
            {
                Work_with_expection.sql_exception_of_code(mysql.Number);
                return new DataSet();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Došlo k neočekavané chybě: \n" + exc.Message);
                return new DataSet();
            }
        }

        public Formats get_format(int id)
        {
            Formats loaded_clip = null;
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("select * from formats where id = @id", connection);
                cmd.Parameters.AddWithValue("@id", id);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    loaded_clip = new Formats(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetInt32(4), reader.GetInt32(5), (Type_frame)Enum.Parse(typeof(Type_frame), reader.GetString(6)));

                }
                connection.Close();
                return loaded_clip;


            }
            catch (MySqlException mysql)
            {
                Work_with_expection.sql_exception_of_code(mysql.Number);
                return new Formats();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Došlo k neočekavané chybě: \n" + exc.Message);
                return new Formats();
            }
        }

        public string new_format(Formats format)
        {
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                MySqlCommand insert_command = new MySqlCommand("insert into formats(name_,height,width,fps,audio_counttrack,type_frame) values (@name_,@height,@width,@fps,@audio_counttrack,@type_frame)", connection);
                insert_command.Parameters.AddWithValue("@name_", format.Name_);
                insert_command.Parameters.AddWithValue("@height", format.Height);
                insert_command.Parameters.AddWithValue("@width", format.Width);
                insert_command.Parameters.AddWithValue("@fps", format.Fps);
                insert_command.Parameters.AddWithValue("@audio_counttrack", format.Audio_counttrack);
                insert_command.Parameters.AddWithValue("@type_frame", format.Type_Frame);


                insert_command.ExecuteNonQuery();
                connection.Close();
                return "Vloženo";
            }
            catch (MySqlException mysql)
            {
                Work_with_expection.sql_exception_of_code(mysql.Number);
                return "";
            }
            catch (Exception exc)
            {
                return "Došlo k neočekavané chybě: \n" + exc.Message;
            }
        }

        public string update_format(Formats format)
        {
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                MySqlCommand insert_command = new MySqlCommand("update formats set name_=@name_,height=@height,width=@width,fps=@fps,audio_counttrack=@audio_counttrack,type_frame=@type_frame where id = @id", connection);
                insert_command.Parameters.AddWithValue("@id", format.Id);
                insert_command.Parameters.AddWithValue("@name_", format.Name_);
                insert_command.Parameters.AddWithValue("@height", format.Height);
                insert_command.Parameters.AddWithValue("@width", format.Width);
                insert_command.Parameters.AddWithValue("@fps", format.Fps);
                insert_command.Parameters.AddWithValue("@audio_counttrack", format.Audio_counttrack);
                insert_command.Parameters.AddWithValue("@type_frame", format.Type_Frame);


                insert_command.ExecuteNonQuery();
                connection.Close();
                return "Upraveno";
            }
            catch (MySqlException mysql)
            {
                Work_with_expection.sql_exception_of_code(mysql.Number);
                return "";
            }
            catch (Exception exc)
            {
                return "Došlo k neočekavané chybě: \n" + exc.Message;
            }
        }

        public List<Formats> get_all_for_backup()
        {
            List<Formats> formats = new List<Formats>();
            Formats loaded_clip = null;
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("select * from formats", connection);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    formats.Add(new Formats(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetInt32(4), reader.GetInt32(5), (Type_frame)Enum.Parse(typeof(Type_frame), reader.GetString(6))));

                }
                connection.Close();
                return formats;


            }
            catch (MySqlException mysql)
            {
                Work_with_expection.sql_exception_of_code(mysql.Number);
                return formats;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Došlo k neočekavané chybě: \n" + exc.Message);
                return formats;
            }
        }

        public string load_file(List<Formats> formats)
        {
            MySqlTransaction mySqlTransaction = null;
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();

                connection.Open();

                mySqlTransaction = connection.BeginTransaction();
                MySqlCommand insert_command = new MySqlCommand("insert into formats(id,name_,height,width,fps,audio_counttrack,type_frame) values (@id,@name_,@height,@width,@fps,@audio_counttrack,@type_frame)", connection);

                for (int i = 0; i < formats.Count; i++)
                {
                    insert_command.Parameters.AddWithValue("@id", formats[i].Id);
                    insert_command.Parameters.AddWithValue("@name_", formats[i].Name_);
                    insert_command.Parameters.AddWithValue("@height", formats[i].Height);
                    insert_command.Parameters.AddWithValue("@width", formats[i].Width);
                    insert_command.Parameters.AddWithValue("@fps", formats[i].Fps);
                    insert_command.Parameters.AddWithValue("@audio_counttrack", formats[i].Audio_counttrack);
                    insert_command.Parameters.AddWithValue("@type_frame", formats[i].Type_Frame);

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
