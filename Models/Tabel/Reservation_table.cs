using System.ComponentModel.DataAnnotations;

namespace Airplane
{
    public class Reservation_table
    {
        [Key]
        public int Id { get; set; }
        public int Id_Flight_name  { get; set; }
        public int Id_User { get; set; }
    }
}