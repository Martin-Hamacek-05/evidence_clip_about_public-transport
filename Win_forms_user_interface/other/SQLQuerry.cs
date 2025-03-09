using evidence_clip_about_public_transport.Database_connection;
using MySql.Data.MySqlClient;
using ScottPlot.TickGenerators.TimeUnits;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace evidence_clip_about_public_transport.Win_forms_user_interface.other
{
    public partial class SQLQuerry : Form
    {
        public SQLQuerry()
        {
            InitializeComponent();
        }

        private void querryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var regex = @"^.*drop .*$|^.*create .*$|^.*alter .*$";

                var regexII = @"^.*author .*$";

                var match = Regex.Match(querry_input.Text, regex);
                var matchII = Regex.Match(querry_input.Text, regexII);

                if (match.Success)
                {
                    throw new ArgumentException("SQL injection");
                }

                if(matchII.Success)
                {
                    throw new UnauthorizedAccessException("provádět dotazy nad tabulkou author je zakazáno. ");
                }

                MySqlDataAdapter adapter = new MySqlDataAdapter(querry_input.Text, Database_connect.myssql_connection());
                DataSet dataSet_of_clip = new DataSet();
                adapter.Fill(dataSet_of_clip);
                data_from_select.DataSource = dataSet_of_clip.Tables[0];
                data_from_select.Update();
                status_label.Text = "OK | Počet nalezených záznamů: " + data_from_select.Rows.Count.ToString();
            }
            catch (IndexOutOfRangeException exc) 
            { 
                MessageBox.Show("byl proveden dotaz, který neobsahuje select");
                status_label.Text = "OK | Počet nalezených záznamů: 0";
            }

            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                status_label.Text = exc.Message;
            }
        }
    }
}
