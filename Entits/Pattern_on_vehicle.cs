using ScottPlot.TickGenerators.Financial;
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
    /// Reprezentation entit Pattern_on_vehicle in database
    /// </summary>
    public class Pattern_on_vehicle:I_Work_with_Csv
    {
        private int id;
        private DateOnly from_;
        private DateOnly to_;
        private int vehicle_id;
        private int pattern_id;

        public Pattern_on_vehicle() 
        { 
        
        }
        public Pattern_on_vehicle(int id, DateOnly from_, DateOnly to_, int vehicle_id, int pattern_id)
        {
            this.id = id;
            this.from_ = from_;
            this.to_ = to_;
            this.vehicle_id = vehicle_id;
            this.pattern_id = pattern_id;
        }

        public int Id { get => id; set => id = value; }
        public DateOnly From_ { get => from_; set => from_ = value; }
        public DateOnly To_ { get => to_; set => to_ = value; }
        public int Vehicle_id { get => vehicle_id; set => vehicle_id = value; }
        public int Pattern_id { get => pattern_id; set => pattern_id = value; }

        public object from_csv(string row)
        {
            row = row.Trim();
            string[] splited = row.Split(';');

            return new Pattern_on_vehicle(Int32.Parse(splited[0]), DateOnly.ParseExact(splited[1], "dd.MM.yyyy"), DateOnly.ParseExact(splited[2], "dd.MM.yyyy"), Int32.Parse(splited[3]), Int32.Parse(splited[4]));
        }

        public string to_csv()
        {
            return id+";"+from_+";"+to_+";"+vehicle_id+";"+pattern_id;
        }
    }
}
