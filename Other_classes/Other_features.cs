using evidence_clip_about_public_transport.Win_forms_user_interface.for_formats;
using evidence_clip_about_public_transport.Win_forms_user_interface.for_lines;
using evidence_clip_about_public_transport.Win_forms_user_interface.for_mean_of_transport;
using evidence_clip_about_public_transport.Win_forms_user_interface.for_owner;
using evidence_clip_about_public_transport.Win_forms_user_interface.for_pattern;
using evidence_clip_about_public_transport.Win_forms_user_interface.for_producer;
using evidence_clip_about_public_transport.Win_forms_user_interface.for_stops;
using evidence_clip_about_public_transport.Win_forms_user_interface.for_subtype_mean_of_transport;
using evidence_clip_about_public_transport.Win_forms_user_interface.for_vehicle;
using evidence_clip_about_public_transport.Win_forms_user_interface.ftp_manager;
using evidence_clip_about_public_transport.Win_forms_user_interface.other;
using ScottPlot.Finance;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* author Martin Hamacek, C4c, 2024/2025*/
namespace evidence_clip_about_public_transport.Other_classes
{
    /// <summary>
    /// Other features
    /// </summary>
    public class Other_features
    {
        /// <summary>
        /// load of name stored procedure
        /// </summary>
        /// <param name="id"></param>
        /// <returns>selected procedure</returns>
        public static string procedure_convertor(int id)
        {
            List<string> list = new List<string>();
            list.Add("recalculation_clips_on_days");
            list.Add("recalculation_clips_on_month");
            list.Add("recalculation_clip_on_line");
            list.Add("recalculation_clip_to_stops");
            list.Add("recalculation_days_on_stop");
            list.Add("recalculation_on_subtype_mean_of_transport_from_clip");
            list.Add("recalculation_lines_on_stop_from_clip");
            list.Add("recalculation_subtypes_mean_of_transport_on_lines_from_clip");

            return list[id];
        }
        /// <summary>
        /// set names of statistic to toolstripcombobox
        /// </summary>
        /// <param name="name_of_statistic"></param>

        public static TreeNode[] list_of_statistics()
        {
            TreeNode[] list = new TreeNode[8];
            for (int i = 0; i < list.Length; i++)
            {
                list[i] = new TreeNode(name_of_statistics(i), 4, 4);
            }
            return list;
        }

        public static string name_of_statistics(int index)
        {
            string[] names = { "přepočet záběrů na dny (I)", "přepočet záběrů na měsíc (I)", "přepočet záběrů na jednotlivé linky (I)", "přepočet záběrů na jednotlivé zastávky (I)", "přepočet dnů na zastávky (I)", "přepočet záběrů na podtyp dopravních prostředků (II)", "přepočet linek na zastávku na základě klipů (II)", "přepočet linek na podtyp dopravních prostředků (III)" };
            return names[index];
        }

        public static Statistics[] load_statistics()
        {
            List<Statistics> list = new List<Statistics>();
            for (int i = 0; i < list_of_statistics().Length; i++)
            {
                list.Add(new Statistics(i));
            }
            return list.ToArray();
        }

        public static List<string[]> datagridview_convert(DataGridView data) 
        {
            string[]array = new string[data.ColumnCount];
            List<string[]> list = new List<string[]>();
            foreach (DataGridViewRow row in data.Rows)
            {
                for (int i = 0; i < data.ColumnCount; i++)
                {
                    if (!(data.Columns[i].HeaderText.ToString().Equals("id")))
                    {
                        array[i] = row.Cells[i].Value?.ToString();
                    }
                }   
                list.Add(array);
                Array.Clear(array);
            }
            return list;
        }

        public static Form load_tree_view(int a, int b)
        {
            switch (a, b)
            {
                case (0, 0):
                    return new Show_clips();
                    break;

                case (0, 1):
                    return new Show_stops();
                    break;

                case (0, 2):
                    return new Show_lines();
                    break;

                case (0, 3):
                    return new Show_formats();
                    break;

                case (1, 0):

                    return new Show_vehicles();
                    break;

                case (1, 1):
                    return new Show_owner();
                    break;

                case (1, 2):
                    return new Show_pattern();
                    break;

                case (1, 3):
                    return new Show_producer();
                    break;

                case (1, 4):
                    return new Show_mean_of_transport();
                    break;

                case (1, 5):
                    return new Show_subtype_mean_of_transport();
                    break;

                case (2, 0):
                    return new Statistics(b);
                    break;

                case (2, 1):
                    return new Statistics(b);
                    break;

                case (2, 2):

                    return new Statistics(b);
                    break;
                case (2, 3):
                    return new Statistics(b);
                    break;
                case (2, 4):
                    return new Statistics(b);
                    break;

                case (2, 5):
                    return new Statistics(b);
                    break;
                case (2, 6):
                    return new Statistics(b);
                    break;
                case (2, 7):
                    return new Statistics(b);
                    break;

                case (5, 0):
                    return new Ftp_manager();
                    break;

                case (5, 1):
                    return new Styles_for_html();
                    break;
                default:
                    return null;
                    break;
            }

        }

        public static Form load_tree_view(int a)
        {
            switch (a)
            {
                case 3:
                    return new evidence_clip_about_public_transport.Win_forms_user_interface.other.Filter();
                    break;

                case 4:
                    return new SQLQuerry();
                    break;

                default:
                    return null;
                    break;
            }

        }

        public static string[] set_header_in_czech(int index)
        {
            List<string[]> headers_in_czech = new List<string[]>();
            string[] recalculation_clips_on_days_or_month = { "vytvořeno", "počet" };
            string[] recalculation_clip_on_lines_or_stops_or_days_on_stop = { "název zastávky", "počet" };
            string[] recalculation_on_subtype_mean_of_transport_from_clip = { "dopravní prostředek", "podtyp", "počet" };
            string[] recalculation_on_subtypes_mean_of_transport_on_lines_from_clip = { "dopraavní prostředek", "podtyp", "název linky", "počet" };
            string[] recalculation_lines_on_stop_from_clip = { "název zastávky", "linka", "počet" };

            headers_in_czech.Add(recalculation_clips_on_days_or_month);
            headers_in_czech.Add(recalculation_clip_on_lines_or_stops_or_days_on_stop);
            headers_in_czech.Add(recalculation_on_subtype_mean_of_transport_from_clip);
            headers_in_czech.Add(recalculation_on_subtypes_mean_of_transport_on_lines_from_clip);
            headers_in_czech.Add(recalculation_lines_on_stop_from_clip);

            switch (index)
            {
                case 0:
                    return headers_in_czech[0];
                    break;

                case 1:
                    return headers_in_czech[0];
                    break;

                case 2:
                    return headers_in_czech[1];
                    break;

                case 3:
                    return headers_in_czech[1];
                    break;

                case 4:
                    return headers_in_czech[1];
                    break;
                case 5:
                    return headers_in_czech[2];
                    break;
                case 6:
                    return headers_in_czech[4];
                    break;
                case 7:
                    return headers_in_czech[3];
                    break;
                default:
                    return headers_in_czech[0];
                    break;
            }


        }

        public static string color_()
        {
            ColorDialog dialog = new ColorDialog();
            dialog.ShowDialog();
            return (dialog.Color.ToArgb() & 0x00FFFFFF).ToString("X6");
        }
    }
}
