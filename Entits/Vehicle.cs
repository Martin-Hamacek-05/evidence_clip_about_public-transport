using ScottPlot.TickGenerators.Financial;
using ScottPlot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarfBuzzSharp;
using evidence_clip_about_public_transport.Enums;
/* author Martin Hamacek, C4c, 2024/2025*/
namespace evidence_clip_about_public_transport.Entits
{
    /// <summary>
    /// Reprezentation entit Vehicle in database
    /// </summary>
    public class Vehicle:I_Work_with_Csv
    {
        private int id;
        private string number_;
        private string vehicle_registration_plate;
        private int year_of_made;
        private DateOnly in_operation_from;
        private DateOnly in_operation_to;
        private bool is_low_rise;
        private bool have_air_conditioning;
        private int producer_id;
        private int mean_of_transport_id;
        private int subtype_mean_of_transport_id;
        private int owner_id;
        private int vehicle_id;
        private string direction_of_vehicle;

        public Vehicle() 
        { 
        
        }
        public Vehicle(int id, string number_, string vehicle_registration_plate, int year_of_made, DateOnly in_operation_from, DateOnly in_operation_to, bool is_low_rise, bool have_air_conditioning, int producer_id, int mean_of_transport_id, int subtype_mean_of_transport_id, int owner_id, string direction_of_vehicle)
        {
            if (number_.Length > 100) 
            {
                throw new IndexOutOfRangeException("Délka čísla je větší než 100");
            }

            if (vehicle_registration_plate.Length > 100) 
            {
                throw new IndexOutOfRangeException("Délka SPZ je větší než 100");
            }

            this.id = id;
            this.number_ = number_;
            this.vehicle_registration_plate = vehicle_registration_plate;
            this.year_of_made = year_of_made;
            this.in_operation_from = in_operation_from;
            this.in_operation_to = in_operation_to;
            this.is_low_rise = is_low_rise;
            this.have_air_conditioning = have_air_conditioning;
            this.producer_id = producer_id;
            this.mean_of_transport_id = mean_of_transport_id;
            this.subtype_mean_of_transport_id = subtype_mean_of_transport_id;
            this.owner_id = owner_id;
            this.direction_of_vehicle = direction_of_vehicle;
        }

        public Vehicle(int id, string number_, string vehicle_registration_plate, int year_of_made, DateOnly in_operation_from, DateOnly in_operation_to, bool is_low_rise, bool have_air_conditioning, int producer_id, int mean_of_transport_id, int subtype_mean_of_transport_id, int owner_id,int vehicle_id, string direction_of_vehicle)
        {
            this.id = id;
            this.number_ = number_;
            this.vehicle_registration_plate = vehicle_registration_plate;
            this.year_of_made = year_of_made;
            this.in_operation_from = in_operation_from;
            this.in_operation_to = in_operation_to;
            this.is_low_rise = is_low_rise;
            this.have_air_conditioning = have_air_conditioning;
            this.producer_id = producer_id;
            this.mean_of_transport_id = mean_of_transport_id;
            this.subtype_mean_of_transport_id = subtype_mean_of_transport_id;
            this.owner_id = owner_id;
            this.vehicle_id = vehicle_id;
            this.direction_of_vehicle = direction_of_vehicle;
        }

        public int Id { get => id; set => id = value; }
        public string Number_ { get => number_; set => number_ = value; }
        public string Vehicle_registration_plate { get => vehicle_registration_plate; set => vehicle_registration_plate = value; }
        public int Year_of_made { get => year_of_made; set => year_of_made = value; }
        public DateOnly In_operation_from { get => in_operation_from; set => in_operation_from = value; }
        public DateOnly In_operation_to { get => in_operation_to; set => in_operation_to = value; }
        public bool Is_low_rise { get => is_low_rise; set => is_low_rise = value; }
        public bool Have_air_conditioning { get => have_air_conditioning; set => have_air_conditioning = value; }
        public int Producer_id { get => producer_id; set => producer_id = value; }
        public int Mean_of_transport_id { get => mean_of_transport_id; set => mean_of_transport_id = value; }
        public int Subtype_mean_of_transport_id { get => subtype_mean_of_transport_id; set => subtype_mean_of_transport_id = value; }
        public int Owner_id { get => owner_id; set => owner_id = value; }
        public int Vehicle_id { get => vehicle_id; set => vehicle_id = value; }
        public string Direction_of_vehicle { get => direction_of_vehicle; set => direction_of_vehicle = value; }

        public object from_csv(string row)
        {
            row = row.Trim();
            string[] splited = row.Split(';');

            bool boolean_from_strring = false;

            if (splited[6].Equals("true"))
            {
                boolean_from_strring = true;
            }

            bool boolean_from_strringII = false;

            if (splited[7].Equals("true"))
            {
                boolean_from_strringII = true;
            }

            return new Vehicle(Int32.Parse(splited[0]), splited[1], splited[2], Int32.Parse(splited[3]), DateOnly.ParseExact(splited[4], "dd.MM.yyyy"), DateOnly.ParseExact(splited[5], "dd.MM.yyyy"), boolean_from_strring, boolean_from_strringII, Int32.Parse(splited[8]), Int32.Parse(splited[9]), Int32.Parse(splited[10]), Int32.Parse(splited[11]), Int32.Parse(splited[12]), splited[13]);
        }

        public string to_csv()
        {
            return id + ";" + number_ + ";" + vehicle_registration_plate + ";" + year_of_made + ";" + in_operation_from + ";" + in_operation_to + ";" + is_low_rise + ";" + have_air_conditioning + ";" + producer_id + ";" + mean_of_transport_id + ";" + subtype_mean_of_transport_id + ";" + owner_id + ";" + vehicle_id + ";"+ direction_of_vehicle;
        }
    }
}
