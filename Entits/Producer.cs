using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* author Martin Hamacek, C4c, 2024/2025*/
namespace evidence_clip_about_public_transport.Entits
{
    /// <summary>
    /// Reprezentation entit Producer in database
    /// </summary>
    public class Producer:I_Work_with_Csv
    {
        private int id;
        private string name_;
        private string headquarters;
        private string note;

        public Producer() 
        { 
        
        }
        public Producer(int id, string name_, string headquarters, string note)
        {
            if (name_.Length > 100)
            {
                throw new IndexOutOfRangeException("Délka názvu je větší než 100");
            }

            if (name_ == null)
            {
                throw new IndexOutOfRangeException("Název neobsahuje text");
            }

            if (headquarters.Length > 20)
            {
                throw new IndexOutOfRangeException("Délka sídla je větší než 100");
            }

            if (headquarters == null)
            {
                throw new IndexOutOfRangeException("Sídlo neobsahuje text");
            }

            this.Id = id;
            this.Name_ = name_;
            this.Headquarters = headquarters;
            this.Note = note;
        }

        public int Id { get => id; set => id = value; }
        public string Name_ { get => name_; set => name_ = value; }
        public string Headquarters { get => headquarters; set => headquarters = value; }
        public string Note { get => note; set => note = value; }

        public object from_csv(string row)
        {
            row = row.Trim();
            string[] splited = row.Split(';');

            return new Producer(Int32.Parse(splited[0]), splited[1], splited[2], splited[3]);
        }

        public string to_csv()
        {
            return id+";"+name_+";"+headquarters+";"+note;
        }
    }
}
