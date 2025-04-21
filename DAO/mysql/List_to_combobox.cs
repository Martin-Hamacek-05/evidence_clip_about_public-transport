using evidence_clip_about_public_transport.Database_connection;
using evidence_clip_about_public_transport.exceptions;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* author Martin Hamacek*/
namespace evidence_clip_about_public_transport.DAO.mysql.other_features
{
    /// <summary>
    /// Generate combobox from sql querry for MySQL server
    /// </summary>
    public class List_to_combobox : I_List_to_combobox
    {
        
        public void selects_I(string sql_querry, string value_, string id, ComboBox combobox)
        {
            DataTable dataTable = new DataTable();
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                if (connection != null)
                {
                    using (connection)
                    {
                        using (MySqlCommand cmd = new MySqlCommand(sql_querry, connection))
                        {
                            connection.Open();
                            MySqlDataAdapter adapter = new MySqlDataAdapter(sql_querry, connection);
                            adapter.Fill(dataTable);
                        }

                        foreach (DataRow row in dataTable.Rows)
                        {
                            combobox.DataSource = dataTable;
                            combobox.DisplayMember = value_;
                            combobox.ValueMember = id;
                        }

                        connection.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Nejde pracovat s databází", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (MySqlException exce)
            {
                Work_with_expection.sql_exception_of_code(exce.Number);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Někde se stala chyba: \n" + exc.ToString(), "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
     
        public void selects_II(string sql_querry, string value_, string id, ComboBox combobox)
        {
            MySqlConnection connection = Database_connect.myssql_connection();
            DataTable dataTable = new DataTable();
            try
            {
                if (connection != null)
                {
                    using (connection)
                    {
                        using (MySqlCommand cmd = new MySqlCommand(sql_querry, connection))
                        {
                            connection.Open();
                            MySqlDataAdapter adapter = new MySqlDataAdapter(sql_querry, connection);
                            adapter.Fill(dataTable);

                        }

                        dataTable.Columns.Add("newcolumn", typeof(string), value_);

                        foreach (DataRow row in dataTable.Rows)
                        {
                            combobox.DataSource = dataTable;
                            combobox.DisplayMember = "newcolumn";
                            combobox.ValueMember = id;
                        }

                        connection.Close();
                    }

                }
                else
                {
                    throw new Exception("Nejde pracovat s databází");
                }
            }
            catch (MySqlException exce)
            {
                Work_with_expection.sql_exception_of_code(exce.Number);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Někde sse stala chyba: \n" + exc.ToString(), "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void selects_III(string sql_querry,string value_, ComboBox combobox)
        {
            DataTable dataTable = new DataTable();
            try
            {
                MySqlConnection connection = Database_connect.myssql_connection();
                if (connection != null)
                {
                    using (connection)
                    {
                        using (MySqlCommand cmd = new MySqlCommand(sql_querry, connection))
                        {
                            connection.Open();
                            MySqlDataAdapter adapter = new MySqlDataAdapter(sql_querry, connection);
                            adapter.Fill(dataTable);
                        }

                        foreach (DataRow row in dataTable.Rows)
                        {
                            combobox.DataSource = dataTable;
                            combobox.DisplayMember = value_;

                        }

                        connection.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Nejde pracovat s databází", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (MySqlException exce)
            {
                Work_with_expection.sql_exception_of_code(exce.Number);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Někde se stala chyba: \n" + exc.ToString(), "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void yers_to_combobox(string query, ToolStripComboBox combobox)
        {
            try
            {
                MySqlConnection mySqlConnection = Database_connect.myssql_connection();
                mySqlConnection.Open();
                MySqlCommand command = new MySqlCommand(query, mySqlConnection);


                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    combobox.Items.Add(reader.GetInt32(0));
                }
            }
            catch (MySqlException exce)
            {
                Work_with_expection.sql_exception_of_code(exce.Number);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Někde sse stala chyba: \n" + exc.ToString(), "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
