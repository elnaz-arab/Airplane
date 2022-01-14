using System;

namespace Airplane
{
    public class Vm_Flight_name
    {
        public int Id_Flight_name { get; set; }
        public string Company { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public DateTime Flight_date { get; set; }
        public TimeSpan Flight_time { get; set; }
        public int Duty { get; set; }
    }
}