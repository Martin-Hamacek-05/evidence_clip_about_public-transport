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
        private static string error = "chyba ";
        private static MessageBoxButtons ok_buttons = MessageBoxButtons.OK;
        private static MessageBoxIcon icon = MessageBoxIcon.Error;

        /// <summary>
        ///This class is desined for better info about error
        /// </summary>
        /// <param name="number_of_code">number of code</param>
        public static void sql_exception_of_code(int number_of_code) 
        {
            switch (number_of_code)
            {
                case 1040:
                    MessageBox.Show(error + number_of_code + ":\nDo databáze se nejde dostat, protože je připojeno mnoho clientů", error, ok_buttons, icon);
                    break;
                case 1042:
                    MessageBox.Show(error + number_of_code + ":\nNejde se připojit k databází", error, ok_buttons, icon);
                    break;
                case 1045:
                    MessageBox.Show(error + number_of_code + ":\nPřístup zamítnut - Neplatné přihlašovací údaje do databáze.", error, ok_buttons, icon);
                    break;
                case 1049:
                    MessageBox.Show(error + number_of_code + ":\nNeplatný název databáze.", error, ok_buttons, icon);
                    break;

                case 1062:
                    MessageBox.Show(error + number_of_code + ":\nMusíte zadat unikátní hodnotu.", error, ok_buttons, icon);
                    break;

                default:
                    MessageBox.Show(error + number_of_code + ":\nNeočekavaná chyba při práci s databází", error, ok_buttons, icon);
                    break;
            }
        }
    }
}
