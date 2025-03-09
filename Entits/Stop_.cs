using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
/* author Martin Hamacek, C4c, 2024/2025*/
namespace evidence_clip_about_public_transport.Entits
{
    /// <summary>
    /// Reprezentation entit Stop_ in database
    /// </summary>
    public class Stop_:I_Work_with_Csv
    {
        private int id;
        private string name_of_stop;
        private string number_of_stop;
        private string platform;
        private string direction;
        private bool is_operation;
        private bool is_low_rise;
        private string note;

        public Stop_() { }

        public Stop_(int id, string name_of_stop, string number_of_stop, string platform, string direction, bool is_operation, bool is_low_rise, string note)
        {
            if (name_of_stop == null)
            {
                throw new IndexOutOfRangeException("název zastávky neobsahuje text");
            }

            if (platform == null)
            {
                throw new IndexOutOfRangeException("nástupiště neobsahuje text");
            }

            if (direction == null)
            {
                throw new IndexOutOfRangeException("směr neobsahuje text");
            }

            if (name_of_stop.Length > 100)
            {
                throw new IndexOutOfRangeException("délka názvu zastávky je větší než 100");
            }

            if (number_of_stop.Length > 20)
            {
                throw new IndexOutOfRangeException("déla řísla zastávky je větší než 20");
            }

            if (platform.Length > 20)
            {
                throw new IndexOutOfRangeException("délka názvu nástupiště je délší než 20");
            }

            if (direction.Length > 50)
            {
                throw new IndexOutOfRangeException("délka názvu směru je délší než 50");
            }

            this.id = id;
            this.name_of_stop = name_of_stop;
            this.number_of_stop = number_of_stop;
            this.platform = platform;
            this.direction = direction;
            this.is_operation = is_operation;
            this.is_low_rise = is_low_rise;
            this.note = note;
        }

        public int Id { get => id; set => id = value; }
        public string Name_of_stop { get => name_of_stop; set => name_of_stop = value; }
        public string Number_of_stop { get => number_of_stop; set => number_of_stop = value; }
        public string Platform { get => platform; set => platform = value; }
        public string Direction { get => direction; set => direction = value; }
        public bool Is_operation { get => is_operation; set => is_operation = value; }
        public bool Is_low_rise { get => is_low_rise; set => is_low_rise = value; }
        public string Note { get => note; set => note = value; }
        /// <summary>
        /// Save instance to csv format
        /// </summary>
        /// <returns>string in csv format</returns>
        public string to_csv()
        {
            return id + ";" + name_of_stop + ";" + number_of_stop + ";" + platform + ";" + direction + ";" + is_operation + ";" + is_low_rise+";"+note ;
        }

        /// <summary>
        /// Parse data from csv format to new instance
        /// </summary>
        /// <param name="input">csv string</param>
        /// <returns>new instance</returns>
        public object from_csv(string row)
        {
            row = row.Trim();
            string[] splited = row.Split(';');
            bool boolean_from_strring = false;
            bool boolean_from_strring_II = false;

            if (splited[5].Equals("True"))
            {
                boolean_from_strring = true;
            }

            if (splited[6].Equals("True"))
            {
                boolean_from_strring_II = true;
            }

            return new Stop_(Int32.Parse(splited[0]), splited[1], splited[2], splited[3], splited[4], boolean_from_strring, boolean_from_strring_II, splited[7]);
        }
    }
}
