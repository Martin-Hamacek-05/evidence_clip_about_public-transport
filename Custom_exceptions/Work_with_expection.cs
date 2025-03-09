using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* author: Martin Hamacek, C4c, 2024/2025 */
namespace evidence_clip_about_public_transport.exceptions
{
    public class Work_with_expection
    {
        /// <summary>
        ///This class is desined for better info about error
        /// </summary>
        /// <param name="number_of_code">number of code</param>
        public static void sql_exception_of_code(int number_of_code) 
        {
            switch (number_of_code)
            {
                case 1040:
                    MessageBox.Show("Chyba " + number_of_code + ":\nDo databáze se nejde dostat, protože je připojeno mnoho clientů", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 1042:
                    MessageBox.Show("Chyba "+ number_of_code + ":\nNejde se připojit k databází", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 1045:
                    MessageBox.Show("Chyba "+ number_of_code + ":\nPřístup zamítnut - Neplatné přihlašovací údaje do databáze.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 1049:
                    MessageBox.Show("Chyba " + number_of_code + ":\nNeplatný název databáze.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                
                default:
                    MessageBox.Show("Chyba "+ number_of_code + ":\nNeočekavaná chyba při práci s databází", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
    }
}
