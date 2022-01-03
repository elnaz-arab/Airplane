using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Airplane
{
    public class Flight_name
    {
        [Key]
        public int Id_Flight_name { get; set; }
        public string Company { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        [Column("Flight_date", TypeName = "Date")]
        public DateTime Flight_date { get; set; }

        [Column("flight_time", TypeName = "Time")]
        public TimeSpan Flight_time { get; set; }
        public int Duty { get; set; }
    }
}