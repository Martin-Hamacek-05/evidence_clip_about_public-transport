using ScottPlot.TickGenerators.Financial;
using ScottPlot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* author Martin Hamacek, C4c, 2024/2025*/
namespace evidence_clip_about_public_transport.Entits
{
    /// <summary>
    /// Reprezentation entit Subtype_mean_of_transport in database
    /// </summary>
    public class Subtype_mean_of_transport:I_Work_with_Csv
    {
        private int id;
        private string name_;
        private int subtype_mean_of_transport_id;

        public Subtype_mean_of_transport() 
        { 
        
        }
        public Subtype_mean_of_transport(int id, string name_)
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

        }

        public Subtype_mean_of_transport(int id, string name_, int subtype_mean_of_transport_id)
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
            this.subtype_mean_of_transport_id = subtype_mean_of_transport_id;

        }

        public int Id { get => id; set => id = value; }
        public string Name_ { get => name_; set => name_ = value; }
        public int Subtype_mean_of_transport_id { get => subtype_mean_of_transport_id; set => subtype_mean_of_transport_id = value; }

        public object from_csv(string row)
        {
            row = row.Trim();
            string[] splited = row.Split(';');

            return new Subtype_mean_of_transport(Int32.Parse(splited[0]), splited[1], Int32.Parse(splited[2]));
        }

        public string to_csv()
        {
            return id+";"+name_+";"+subtype_mean_of_transport_id;
        }
    }
}
