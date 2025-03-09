using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* author Martin Hamacek, C4c, 2024/2025*/
namespace evidence_clip_about_public_transport.Win_forms_user_interface
{
    public interface I_List_from_table
    {
        private void new_record_Click(object sender, EventArgs e) { }
        private void load_button_Click(object sender, EventArgs e) { }
        private void data_from_select_CellClick(object sender, DataGridViewCellEventArgs e) { }
        private void save_as_button_on_top_menu_trip_Click(object sender, EventArgs e) { }
        private void search_button_Click(object sender, EventArgs e) { }

    }
}
