using System.ComponentModel.DataAnnotations;

namespace Airplane
{
    public class Flight_name
    {
        [Key]
        public int Id_Flight_name { get; set; }
        public string Company { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public string Flight_date { get; set; }
        public string flight_time { get; set; }
        public string Duty { get; set; }
    }
}