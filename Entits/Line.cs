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
    /// Reprezentation entit line in database
    /// </summary>
    public class Line : I_Work_with_Csv
    {
        private int id;
        private int number_line;
        private string name_line;

        public Line() 
        { 
        
        }

        public Line(int id, int number_line, string name_line)
        {
            this.Id = id;

            if (name_line == null)
            {
                throw new IndexOutOfRangeException("název linky neobsahuje text");
            }

            if (name_line.Length> 50)
            {
                throw new IndexOutOfRangeException("délka názvu linky je větší než 50");
            }

            this.Number_line = number_line;
            this.Name_line = name_line;
        }

        public int Id { get => id; set => id = value; }
        public int Number_line { get => number_line; set => number_line = value; }
        public string Name_line { get => name_line; set => name_line = value; }

        /// <summary>
        /// Save instance to csv format
        /// </summary>
        /// <returns>string in csv format</returns>
        public string to_csv() 
        {
            return id+";"+number_line+";"+name_line;
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

            return new Line(Int32.Parse(splited[0]), Int32.Parse(splited[1]), splited[2]);
        }
    }
}
