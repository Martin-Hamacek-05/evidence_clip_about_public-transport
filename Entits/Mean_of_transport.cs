using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* author Martin Hamacek, C4c, 2024/2025*/
namespace evidence_clip_about_public_transport.Entits
{
    /// <summary>
    /// Reprezentation entit Mean_of_transport in database
    /// </summary>
    public class Mean_of_transport:I_Work_with_Csv
    {
        private int id;
        private string name_;
        private string short_name;

        public Mean_of_transport() 
        {  
        
        }

        public Mean_of_transport(int id, string name_, string short_name)
        {
            this.id = id;

            if (name_.Length > 100) 
            {
                throw new IndexOutOfRangeException("Délka názvu je delší než 100");
            }

            if (name_ == null) 
            {
                throw new IndexOutOfRangeException("Název neobsahuje text");
            }

            this.name_ = name_;

            if (short_name.Length > 10)
            {
                throw new IndexOutOfRangeException("Zkrácený názen je delší než 10");
            }

            if (short_name == null)
            {
                throw new IndexOutOfRangeException("Zkrácený název neobsahuje text");
            }

            this.short_name = short_name;
        }

        public int Id { get => id; set => id = value; }
        public string Name_ { get => name_; set => name_ = value; }
        public string Short_name { get => short_name; set => short_name = value; }

        public object from_csv(string row)
        {
            row = row.Trim();
            string[] splited = row.Split(';');

            return new Mean_of_transport(Int32.Parse(splited[0]),splited[1], splited[2]);
        }

        public string to_csv()
        {
            return id+";"+name_+";"+short_name;
        }
    }
}
