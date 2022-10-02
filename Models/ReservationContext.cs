using Microsoft.EntityFrameworkCore;

namespace RestaurantAPI2.Models
{
    public class ReservationContext : DbContext
    {
        public ReservationContext(DbContextOptions<ReservationContext> options)
            : base(options)
        {
        }

        public DbSet<Reservations> Reservations { get; set; }
    }
}
