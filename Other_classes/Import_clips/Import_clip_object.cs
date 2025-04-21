using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Author: Martin Hamacek
namespace evidence_clip_about_public_transport.Other_classes.Import_clips
{
    /// <summary>
    /// simplified format for clips
    /// </summary>
    public class Import_clip_object
    {
        private string name_of_clip;
        private string file_path;
        private DateOnly DateOnly;
        private int number_of_filming_day;
        private string order_on_line;
        private bool arrive_or_depart;
        private int number_line;
        private string name_of_stop;
        private List<string> vehicles;
        private string formats;
        public Import_clip_object() 
        { 
        
        }
        public Import_clip_object(string name_of_clip, string file_path, DateOnly dateOnly, int number_of_filming_day, string order_on_line, bool arrive_or_depart, int number_line, string name_of_stop, List<string> vehicles, string formats)
        {
            this.name_of_clip = name_of_clip;
            this.file_path = file_path;
            DateOnly = dateOnly;
            this.number_of_filming_day = number_of_filming_day;
            this.order_on_line = order_on_line;
            this.arrive_or_depart = arrive_or_depart;
            this.number_line = number_line;
            this.name_of_stop = name_of_stop;
            this.vehicles = vehicles;
            this.formats = formats;
        }

        public string Name_of_clip { get => name_of_clip; set => name_of_clip = value; }
        public string File_path { get => file_path; set => file_path = value; }
        public DateOnly DateOnly1 { get => DateOnly; set => DateOnly = value; }
        public int Number_of_filming_day { get => number_of_filming_day; set => number_of_filming_day = value; }
        public string Order_on_line { get => order_on_line; set => order_on_line = value; }
        public bool Arrive_or_depart { get => arrive_or_depart; set => arrive_or_depart = value; }
        public int Number_line { get => number_line; set => number_line = value; }
        public string Name_of_stop { get => name_of_stop; set => name_of_stop = value; }
        public List<string> Vehicles { get => vehicles; set => vehicles = value; }
        public string Formats { get => formats; set => formats = value; }

        public static void set_propeties_to_object(Import_clip_object import_Clip_Object, int count_of_column,string value) 
        {
            try
            {
                switch (count_of_column)
                {
                    case 1:
                        import_Clip_Object.DateOnly1 = DateOnly.FromDateTime(DateTime.Parse(value));
                        break;

                    case 2:
                        import_Clip_Object.number_of_filming_day = Int32.Parse(value);
                        break;

                    case 3:

                        if (value.Equals("p"))
                        {
                            import_Clip_Object.arrive_or_depart = false;
                        }
                        else
                        {
                            import_Clip_Object.arrive_or_depart = true;
                        }

                        break;

                    case 4:

                        import_Clip_Object.number_line = Int32.Parse(value);

                        break;

                    case 5:
                        import_Clip_Object.order_on_line = value;
                        break;

                    case 6:
                        import_Clip_Object.name_of_stop = value;
                        break;

                    case 7:
                        import_Clip_Object.vehicles = null;
                        break;

                    case 8:
                        import_Clip_Object.formats = value;
                        break;


                    default:

                        break;
                }
            }
            catch (Exception exc) 
            {
                MessageBox.Show(exc.Message);
            }
        }

        public static void set_name_of_clip(Import_clip_object import_Clip_Object, string name) 
        { 
            import_Clip_Object.name_of_clip = name;
        }

        public override string ToString()
        {
            string vehicless = "";

            if (vehicles != null)
            {
                for (int i = 0; i < vehicles.Count; i++)
                {
                    vehicless = vehicless + vehicles[i].ToString()+",";
                }
            }

            return "name_of_clip:"+name_of_clip + ",file_path:" + file_path+ ",DateOnly1:" + DateOnly1.ToString()+ ",number_of_filming_day:" + number_of_filming_day+ ",order_on_line:" + order_on_line+ ",arrive_or_depart:" + arrive_or_depart+ ",number_line:" + number_line+ ",name_of_stop:" + name_of_stop+ ",vehicless:[" + vehicless+ "],formats:" + formats;
        }

    }

}
