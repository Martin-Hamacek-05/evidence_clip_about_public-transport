using evidence_clip_about_public_transport.DAO;
using evidence_clip_about_public_transport.DAO.mysql.for_clip;
using evidence_clip_about_public_transport.Enums;
using evidence_clip_about_public_transport.Entits;
using evidence_clip_about_public_transport.Other_classes;
using evidence_clip_about_public_transport.Win_forms_user_interface.for_vehicles_on_clip;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* author Martin Hamacek, C4c, 2024/2025*/
namespace evidence_clip_about_public_transport.Win_forms_user_interface.for_formats
{
    public partial class Edit_format : Form, I_Edit_data_in_table
    {
        public Edit_format()
        {
            InitializeComponent();
            type_frames_combobox.Items.Insert(0,Type_frame.progressive);
            type_frames_combobox.Items.Insert(1, Type_frame.interlaced);

            delete_button.Enabled = false;
            update_button.Enabled = false;
            create_button.Enabled = true;

        }

        public void set_selected_format(Formats formats)
        {
            this.Text = "Úprava formátu";

            delete_button.Enabled = true;
            update_button.Enabled = true;
            create_button.Enabled = false;
            name_.Text = formats.Name_;
            height.Value = formats.Height;
            width.Value = formats.Width;
            fps.Value = formats.Fps;
            audio_counttrack.Value = formats.Audio_counttrack;
            type_frames_combobox.SelectedIndex = ((int)formats.Type_Frame);
            id_of_format_label.Text = formats.Id.ToString();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            I_DAO_Formats delete = Database_server_switch.dAO_Formats();
            MessageBox.Show(delete.delete_format(Int32.Parse(id_of_format_label.Text)));

        }

        private void create_button_Click(object sender, EventArgs e)
        {
            I_DAO_Formats new_format = Database_server_switch.dAO_Formats();
            MessageBox.Show(new_format.new_format(new Formats(0,name_.Text,(int)height.Value, (int)width.Value, (int)fps.Value, (int)audio_counttrack.Value,(Type_frame)type_frames_combobox.SelectedItem+1)));
            
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            I_DAO_Formats update = Database_server_switch.dAO_Formats();
            MessageBox.Show(update.update_format(new Formats(Int32.Parse(id_of_format_label.Text), name_.Text, (int)height.Value, (int)width.Value, (int)fps.Value, (int)audio_counttrack.Value, (Type_frame)type_frames_combobox.SelectedItem + 1)));
            //update.update_format(new Clip(Int32.Parse(id_of_clip_label.Text), name_.Text, DateOnly.FromDateTime(created.Value), Int32.Parse(height.Text), arrive_or_depart.Checked, order_on_the_line.Text, file_url.Text, float.Parse(lenght_of_clip.Text), 0, Convert.ToInt32(stops_combobox.SelectedValue), 1, Convert.ToInt32(formats_combobox.SelectedValue), Convert.ToInt32(lines_combobox.SelectedValue)));
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
    }
}
