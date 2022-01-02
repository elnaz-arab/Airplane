using Microsoft.EntityFrameworkCore;

namespace Airplane
{
    public class connect : DbContext
    {
        public DbSet<Flight_name> Flight_Names { get; set; }
        public DbSet<Reservation_table> Reservation_Tables { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder db)
        {
            db.UseSqlServer("Data Source =.; Initial Catalog = Airline ; Integrated Security = True");
        }
    }
}
