using evidence_clip_about_public_transport.Database_connection;
using evidence_clip_about_public_transport.Enums;
using evidence_clip_about_public_transport.Entits;
using MySql.Data.MySqlClient;
using ScottPlot;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using evidence_clip_about_public_transport.exceptions;
/* author: Martin Hamacek */
namespace evidence_clip_about_public_transport.DAO.mysql.for_line
{
    /// <summary>
    /// This class is implent of interface I_DAO_Line for MySQL server
    /// </summary>
    public class DAO_Line_implement : I_DAO_Line
    {


        public string delete_line(int id)
        {
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                MySqlCommand insert_command = new MySqlCommand("delete from line where id = @id", connection);
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

        public CheckedListBox get_distict_name_of_lines()
        {
            CheckedListBox distict_line = new CheckedListBox();
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("select distinct name_line from info_from_clip_for_filter order by length(name_line),name_line", connection);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    distict_line.Items.Add(reader.GetString(0));

                }
                connection.Close();
                return distict_line;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
                return distict_line;
            }
        }

        public DataSet get_all_line()
        {
            try
            {
                MySqlDataAdapter adapterII = new MySqlDataAdapter("select * from line", Database_connect.myssql_connection());
                DataSet dataSet_of_formaats = new DataSet();
                adapterII.Fill(dataSet_of_formaats);
                return dataSet_of_formaats;
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

        public Entits.Line get_line(int id)
        {
            Entits.Line loaded_clip = null;
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("select * from line where id=@id", connection);
                cmd.Parameters.AddWithValue("@id", id);


                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    loaded_clip = new Entits.Line(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2));

                }
                connection.Close();
                return loaded_clip;


            }
            catch (MySqlException e)
            {
                Work_with_expection.sql_exception_of_code(e.Number);
                return new Entits.Line();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Došlo k neočekavané chybě: \n" + exc.ToString());
                return new Entits.Line();
            }
        }

        public string new_line(Entits.Line line)
        {
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                MySqlCommand insert_command = new MySqlCommand("insert into line(name_line,number_line) values (@name_line,@number_line)", connection);
                insert_command.Parameters.AddWithValue("@name_line", line.Name_line);
                insert_command.Parameters.AddWithValue("@number_line", line.Number_line);


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

        public string update_line(Entits.Line line)
        {
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                MySqlCommand update = new MySqlCommand("update line set name_line=@name_line,number_line = @number_line where id = @id", connection);
                update.Parameters.AddWithValue("@id", line.Id);
                update.Parameters.AddWithValue("@name_line", line.Name_line);
                update.Parameters.AddWithValue("@number_line", line.Number_line);


                update.ExecuteNonQuery();
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

        public List<Entits.Line> get_all_for_backup()
        {
            List<Entits.Line> backup = new List<Entits.Line>();

            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("select * from line", connection);



                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    backup.Add(new Entits.Line(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2)));

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

        public string load_file(List<Entits.Line> lines)
        {
            MySqlTransaction mySqlTransaction = null;
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();

                connection.Open();

                mySqlTransaction = connection.BeginTransaction();
                MySqlCommand insert_command = new MySqlCommand("insert into line(id,name_line,number_line) values (@id,@name_line,@number_line)", connection);

                for (int i = 0; i < lines.Count; i++)
                {
                    insert_command.Parameters.AddWithValue("@id", lines[i].Id);
                    insert_command.Parameters.AddWithValue("@name_line", lines[i].Name_line);
                    insert_command.Parameters.AddWithValue("@number_line", lines[i].Number_line);

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

        public string sequence_of_lines(int from, int to, int distance)
        {
            MySqlTransaction mySqlTransaction = null;
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();

                connection.Open();

                mySqlTransaction = connection.BeginTransaction();
                MySqlCommand insert_command = new MySqlCommand("insert into line(name_line,number_line) values (@name_line,@number_line)", connection);

                for (int i = from; i <= to; i = i + distance)
                {
                    insert_command.Parameters.AddWithValue("@name_line", i.ToString());
                    insert_command.Parameters.AddWithValue("@number_line", i.ToString());

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
