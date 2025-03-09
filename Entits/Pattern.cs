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
    /// Reprezentation entit Pattern in database
    /// </summary>
    public class Pattern:I_Work_with_Csv
    {
        private int id;
        private string name_of_pattern;
        private string note;

        public Pattern() 
        { 
        
        }
        public Pattern(int id, string name_of_pattern, string note)
        {
            if (name_of_pattern.Length > 100)
            {
                throw new IndexOutOfRangeException("Délka názvu je větší než 100");
            }

            if (name_of_pattern == null)
            {
                throw new IndexOutOfRangeException("Název neobsahuje text");
            }

            this.Id = id;
            this.Name_of_pattern = name_of_pattern;
            
            this.Note = note;
        }

        public int Id { get => id; set => id = value; }
        public string Name_of_pattern { get => name_of_pattern; set => name_of_pattern = value; }
        public string Note { get => note; set => note = value; }

        public object from_csv(string row)
        {
            row = row.Trim();
            string[] splited = row.Split(';');

            return new Pattern(Int32.Parse(splited[0]), splited[1], splited[2]);
        }

        public string to_csv()
        {
            return id+";"+name_of_pattern+";"+note;
        }
    }
}
