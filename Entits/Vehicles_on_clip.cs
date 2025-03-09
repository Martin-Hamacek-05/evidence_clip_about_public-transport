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
    /// Reprezentation entit Vehicles_on_clip in database
    /// </summary>
    public class Vehicles_on_clip:I_Work_with_Csv
    {
        private int id;
        private int vehicle_id;
        private int clip_id;

        public Vehicles_on_clip() 
        { 
        
        }
        public Vehicles_on_clip(int id, int vehicle_id, int clip_id)
        {
            this.id = id;

            this.vehicle_id = vehicle_id;
            this.clip_id = clip_id;
        }

        public int Id { get => id; set => id = value; }
        public int Vehicle_id { get => vehicle_id; set => vehicle_id = value; }
        public int Clip_id { get => clip_id; set => clip_id = value; }

        public object from_csv(string row)
        {
            row = row.Trim();
            string[]splited = row.Split(';');
            return new Vehicles_on_clip(Int32.Parse(splited[0]), Int32.Parse(splited[1]), Int32.Parse(splited[2]));
        }

        public string to_csv()
        {
            return id+";"+vehicle_id+";"+clip_id;
        }
    }
}