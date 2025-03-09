using ScottPlot.Finance;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
/* author Martin Hamacek, C4c, 2024/2025*/
namespace evidence_clip_about_public_transport.Entits
{
    /// <summary>
    /// Reprezentation entit clip in database
    /// </summary>
    public class Clip : I_Work_with_Csv
    {
        private int id;
        private string name_of_clip;
        private DateOnly created;
        private int number_of_filming_day;
        private bool arrive_or_depart;
        private string order_on_the_line;
        private string file_url;
        private float lenght_of_clip;
        private int count_of_vehicles_on_clip;
        private int stop_id;
        private int formats_id;
        private int line_id;

        public Clip() 
        { 
        
        }
        public Clip(int id, string name_of_clip, DateOnly created, int number_of_filming_day, bool arrive_or_depart, string order_on_the_line, string file_url, float lenght_of_clip, int count_of_vehicles_on_clip, int stop_id, int formats_id, int line_id)
        {
            if (name_of_clip == null) 
            { 
                throw new IndexOutOfRangeException("Název klipu neobsahuje text");
            }

            if (name_of_clip.Length > 100)
            {
                throw new IndexOutOfRangeException("Název klipu je delší než 100");
            }

            if (order_on_the_line == null)
            {
                throw new IndexOutOfRangeException("pořadí na lince neobsahuje text");
            }

            if (order_on_the_line.Length > 20)
            {
                throw new IndexOutOfRangeException("délka pořadí na lince je delší než 20");
            }

            if (file_url == null)
            {
                throw new IndexOutOfRangeException("není zadána cesta k souboru");
            }

            if(lenght_of_clip < 0)
            {
                throw new IndexOutOfRangeException("délka klipu je menší než 0");
            }

            this.id = id;
            this.name_of_clip = name_of_clip;
            this.created = created;
            this.number_of_filming_day = number_of_filming_day;
            this.arrive_or_depart = arrive_or_depart;
            this.order_on_the_line = order_on_the_line;
            this.file_url = file_url;
            this.lenght_of_clip = lenght_of_clip;
            this.count_of_vehicles_on_clip = count_of_vehicles_on_clip;
            this.stop_id = stop_id;
            this.formats_id = formats_id;
            this.line_id = line_id;
        }

        public int Id { get => id; set => id = value; }
        public string Name_of_clip { get => name_of_clip; set => name_of_clip = value; }
        public DateOnly Created { get => created; set => created = value; }
        public int Number_of_filming_day { get => number_of_filming_day; set => number_of_filming_day = value; }
        public bool Arrive_or_depart { get => arrive_or_depart; set => arrive_or_depart = value; }
        public string Order_on_the_line { get => order_on_the_line; set => order_on_the_line = value; }
        public string File_url { get => file_url; set => file_url = value; }
        public float Lenght_of_clip { get => lenght_of_clip; set => lenght_of_clip = value; }
        public int Count_of_vehicles_on_clip { get => count_of_vehicles_on_clip; set => count_of_vehicles_on_clip = value; }
        public int Stop_id { get => stop_id; set => stop_id = value; }
        public int Formats_id { get => formats_id; set => formats_id = value; }
        public int Line_id { get => line_id; set => line_id = value; }

        public object from_csv(string row)
        {
            row = row.Trim();
            string[] splited = row.Split(';');
            bool boolean_from_strring = false;

            if (splited[4].Equals("true"))
            {
                boolean_from_strring = true;
            }

            return new Clip(Int32.Parse(splited[0]), splited[1], DateOnly.ParseExact(splited[2], "dd.MM.yyyy"), Int32.Parse(splited[3]), boolean_from_strring, splited[5], splited[6], float.Parse(splited[7], CultureInfo.InvariantCulture.NumberFormat), Int32.Parse(splited[8]), Int32.Parse(splited[9]), Int32.Parse(splited[10]), Int32.Parse(splited[11]));
        }


        public override string ToString()
        {
            return id + ";" + name_of_clip + ";" + created + ";" + number_of_filming_day + ";" + arrive_or_depart + ";" + order_on_the_line + ";" + file_url + ";" + lenght_of_clip + ";" + count_of_vehicles_on_clip + ";" + stop_id + ";" + formats_id + ";" + line_id;
        }
        public string to_csv()
        {
            return id + ";" + name_of_clip + ";" + created + ";" + number_of_filming_day + ";" + arrive_or_depart + ";" + order_on_the_line + ";" + file_url + ";" + lenght_of_clip + ";" + count_of_vehicles_on_clip + ";" + stop_id + ";" + formats_id + ";" + line_id;
        }
    }
}
