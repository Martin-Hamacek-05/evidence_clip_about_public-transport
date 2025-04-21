using DocumentFormat.OpenXml.Office2010.ExcelAc;
using DocumentFormat.OpenXml.Office2013.Excel;
using evidence_clip_about_public_transport.DAO.mysql.for_formats;
using evidence_clip_about_public_transport.Database_connection;
using evidence_clip_about_public_transport.Entits;
using evidence_clip_about_public_transport.exceptions;
using evidence_clip_about_public_transport.Other_classes.Import_clips;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* author: Martin Hamacek */
namespace evidence_clip_about_public_transport.DAO.mysql.for_clip
{
    /// <summary>
    /// This class is implent of interface I_DAO_Clip for MySQL server
    /// </summary>
    public class DAO_Clip_implement : I_DAO_Clip
    {
        public string delete_clip(int id)
        {
            MySqlTransaction mySqlTransaction = null;
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                mySqlTransaction = connection.BeginTransaction();

                MySqlCommand delete_command = new MySqlCommand("delete from vehicles_on_clip where clip_id= @id", connection);
                delete_command.Parameters.AddWithValue("@id", id);
                delete_command.ExecuteNonQuery();

                delete_command = new MySqlCommand("delete from clip where id= @id", connection);
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

        public DataSet get_all_clip_for_filter()
        {
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter("select * from info_from_clip_for_filter", Database_connect.myssql_connection());
                DataSet dataSet_of_clip = new DataSet();
                adapter.Fill(dataSet_of_clip);
                return dataSet_of_clip;

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

        public DataSet get_all_clip_from_year(int year)
        {
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter("select * from info_from_clip_match_vehicles_II where year(created) = " + year, Database_connect.myssql_connection());
                DataSet dataSet_of_clip = new DataSet();
                adapter.Fill(dataSet_of_clip);
                return dataSet_of_clip;
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

        public List<Clip> get_all_for_backup()
        {
            List<Clip> backup = new List<Clip>();

            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("select * from clip", connection);



                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    backup.Add(new Clip(reader.GetInt32(0), reader.GetString(1), DateOnly.FromDateTime(reader.GetDateTime(2)), reader.GetInt32(3), reader.GetBoolean(4), reader.GetString(5), reader.GetString(6), reader.GetFloat(7), reader.GetInt32(8), reader.GetInt32(9), reader.GetInt32(10), reader.GetInt32(11)));

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

        public Clip get_clip(int id)
        {
            Clip loaded_clip = new Clip();
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("select * from clip where id=@id", connection);
                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    loaded_clip = new Clip(reader.GetInt32(0), reader.GetString(1), DateOnly.FromDateTime(reader.GetDateTime(2)), reader.GetInt32(3), reader.GetBoolean(4), reader.GetString(5), reader.GetString(6), reader.GetFloat(7), reader.GetInt32(8), reader.GetInt32(9), reader.GetInt32(10), reader.GetInt32(11));
                }
                connection.Close();
                return loaded_clip;
            }
            catch (MySqlException mysql)
            {
                Work_with_expection.sql_exception_of_code(mysql.Number);
                return new Clip();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Došlo k neočekavané chybě: \n" + exc.Message);
                return new Clip();
            }
        }
        public string new_clip(Clip clip, List<int> list_id_of_vehicles)
        {
            MySqlTransaction mySqlTransaction = null;

            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                mySqlTransaction = connection.BeginTransaction();
                MySqlCommand insert_command = new MySqlCommand("insert into clip (name_of_clip,created,number_of_filming_day,arrive_or_depart,order_on_the_line,file_url,lenght_of_clip,count_of_vehicles_on_clip,stop_id,formats_id,line_id) values (@name_of_clip,@created,@number_of_filming_day,@arrive_or_depart,@order_on_the_line,@file_url,@lenght_of_clip,@count_of_vehicles_on_clip,@stop_id,@format_id,@line_id)", connection);
                insert_command.Parameters.AddWithValue("@name_of_clip", clip.Name_of_clip);
                insert_command.Parameters.AddWithValue("@created", clip.Created.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
                insert_command.Parameters.AddWithValue("@number_of_filming_day", clip.Number_of_filming_day);
                insert_command.Parameters.AddWithValue("@arrive_or_depart", clip.Arrive_or_depart);
                insert_command.Parameters.AddWithValue("@order_on_the_line", clip.Order_on_the_line);
                insert_command.Parameters.AddWithValue("@file_url", clip.File_url);
                insert_command.Parameters.AddWithValue("@lenght_of_clip", clip.Lenght_of_clip);
                insert_command.Parameters.AddWithValue("@count_of_vehicles_on_clip", list_id_of_vehicles.Count);
                insert_command.Parameters.AddWithValue("@stop_id", clip.Stop_id);
                insert_command.Parameters.AddWithValue("@format_id", clip.Formats_id);
                insert_command.Parameters.AddWithValue("@line_id", clip.Line_id);
                insert_command.ExecuteNonQuery();
                MySqlCommand insert_command_II = new MySqlCommand("insert into vehicles_on_clip (vehicle_id,clip_id) values (@vehicle,(select id from clip where name_of_clip=@name_of_clip and created = @created))", connection);
                for (int i = 0; i < list_id_of_vehicles.Count; i++)
                {
                    insert_command_II.Parameters.AddWithValue("@name_of_clip", clip.Name_of_clip);
                    insert_command_II.Parameters.AddWithValue("@created", clip.Created.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
                    insert_command_II.Parameters.AddWithValue("@vehicle", list_id_of_vehicles[i]);
                    insert_command_II.ExecuteNonQuery();
                    insert_command_II.Parameters.Clear();
                }
                mySqlTransaction.Commit();
                connection.Close();
                return "Vytvořeno";
            }
            catch (Exception exc)
            {
                try
                {
                    mySqlTransaction.Rollback();

                    return exc.ToString();
                }
                catch (MySqlException exc2)
                {
                    Work_with_expection.sql_exception_of_code(exc2.Number);
                    return "";
                }
                return exc.ToString();
            }
        }
        public string update_clip(Clip clip)
        {
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                MySqlCommand insert_command = new MySqlCommand("update clip set name_of_clip=@name_of_clip,created=@created,number_of_filming_day=@number_of_filming_day,arrive_or_depart=@arrive_or_depart,order_on_the_line=@order_on_the_line,file_url=@file_url,lenght_of_clip=@lenght_of_clip,stop_id=@stop_id,formats_id=@format_id,line_id=@line_id where id= @id", connection);
                insert_command.Parameters.AddWithValue("@id", clip.Id);
                insert_command.Parameters.AddWithValue("@name_of_clip", clip.Name_of_clip);
                insert_command.Parameters.AddWithValue("@created", clip.Created.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
                insert_command.Parameters.AddWithValue("@number_of_filming_day", clip.Number_of_filming_day);
                insert_command.Parameters.AddWithValue("@arrive_or_depart", clip.Arrive_or_depart);
                insert_command.Parameters.AddWithValue("@order_on_the_line", clip.Order_on_the_line);
                insert_command.Parameters.AddWithValue("@file_url", clip.File_url);
                insert_command.Parameters.AddWithValue("@lenght_of_clip", clip.Lenght_of_clip);
                insert_command.Parameters.AddWithValue("@stop_id", clip.Stop_id);
                insert_command.Parameters.AddWithValue("@format_id", clip.Formats_id);
                insert_command.Parameters.AddWithValue("@line_id", clip.Line_id);
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
        public string load_file(List<Clip> list)
        {
            MySqlTransaction mySqlTransaction = null;
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                mySqlTransaction = connection.BeginTransaction();
                MySqlCommand insert_command = new MySqlCommand("insert into clip (id,name_of_clip,created,number_of_filming_day,arrive_or_depart,order_on_the_line,file_url,lenght_of_clip,count_of_vehicles_on_clip,stop_id,formats_id,line_id) values (@id,@name_of_clip,@created,@number_of_filming_day,@arrive_or_depart,@order_on_the_line,@file_url,@lenght_of_clip,@count_of_vehicles_on_clip,@stop_id,@format_id,@line_id)", connection);
                for (int i = 0; i < list.Count; i++)
                {
                    insert_command.Parameters.AddWithValue("@id", list[i].Id);
                    insert_command.Parameters.AddWithValue("@name_of_clip", list[i].Name_of_clip);
                    insert_command.Parameters.AddWithValue("@created", list[i].Created.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
                    insert_command.Parameters.AddWithValue("@number_of_filming_day", list[i].Number_of_filming_day);
                    insert_command.Parameters.AddWithValue("@arrive_or_depart", list[i].Arrive_or_depart);
                    insert_command.Parameters.AddWithValue("@order_on_the_line", list[i].Order_on_the_line);
                    insert_command.Parameters.AddWithValue("@file_url", list[i].File_url);
                    insert_command.Parameters.AddWithValue("@lenght_of_clip", list[i].Lenght_of_clip);
                    insert_command.Parameters.AddWithValue("@count_of_vehicles_on_clip", list[i].Count_of_vehicles_on_clip);
                    insert_command.Parameters.AddWithValue("@stop_id", list[i].Stop_id);
                    insert_command.Parameters.AddWithValue("@format_id", list[i].Formats_id);
                    insert_command.Parameters.AddWithValue("@line_id", list[i].Line_id);
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

        public string load_record_from_file(List<Import_clip_object>to_upload)
        {
            MySqlTransaction mySqlTransaction = null;
            
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                mySqlTransaction = connection.BeginTransaction();
                MySqlCommand insert_command = new MySqlCommand("" +
                    "insert into clip (name_of_clip,created,number_of_filming_day,arrive_or_depart,order_on_the_line,file_url,lenght_of_clip,count_of_vehicles_on_clip,stop_id,formats_id,line_id) " +
                    "values " +
                    "(@name_of_clip,@created,@number_of_filming_day,@arrive_or_depart,@order_on_the_line,@file_url,0,0,(select id from stop_ where name_of_stop = @stop_id limit 1)," +
                    "(select id from formats where name_ = @format_id limit 1),(select id from line where number_line = @line_id limit 1))", connection);
                
                
                for (int i = 0; i < to_upload.Count; i++) 
                {
                    insert_command.Parameters.AddWithValue("@name_of_clip", to_upload[i].Name_of_clip);
                    insert_command.Parameters.AddWithValue("@created", to_upload[i].DateOnly1.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
                    insert_command.Parameters.AddWithValue("@number_of_filming_day", to_upload[i].Number_of_filming_day);
                    insert_command.Parameters.AddWithValue("@arrive_or_depart", to_upload[i].Arrive_or_depart);
                    insert_command.Parameters.AddWithValue("@order_on_the_line", to_upload[i].Order_on_line.Replace('"', '\0'));
                    insert_command.Parameters.AddWithValue("@file_url", to_upload[i].File_path);
                    insert_command.Parameters.AddWithValue("@count_of_vehicles_on_clip", 0);
                    insert_command.Parameters.AddWithValue("@stop_id", to_upload[i].Name_of_stop);
                    insert_command.Parameters.AddWithValue("@format_id", to_upload[i].Formats);
                    insert_command.Parameters.AddWithValue("@line_id", to_upload[i].Number_line);

                    insert_command.ExecuteNonQuery();
                    insert_command.Parameters.Clear();

                    for (int j = 0; j < to_upload[i].Vehicles.Count; j++)
                    {
                        MySqlCommand insert_command_II = new MySqlCommand("insert into vehicles_on_clip (vehicle_id,clip_id) values ((select id from vehicle where number_=@vehicle limit 1),(select id from clip where name_of_clip = @name_of_clip and created = @created))", connection);
                        insert_command_II.Parameters.AddWithValue("@name_of_clip", to_upload[i].Name_of_clip);
                        insert_command_II.Parameters.AddWithValue("@created", to_upload[i].DateOnly1.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
                        insert_command_II.Parameters.AddWithValue("@vehicle", to_upload[i].Vehicles[j]);
                        insert_command_II.ExecuteNonQuery();
                        insert_command_II.Parameters.Clear();
                    }
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
                catch (MySqlException exc2)
                {
                    return exc2.ToString();
                }
                catch (Exception exce) 
                {
                    return exce.ToString();
                }
            }

            
        }
    }
}