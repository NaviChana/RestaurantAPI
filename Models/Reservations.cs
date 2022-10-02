using Microsoft.Build.Framework;

namespace RestaurantAPI2.Models
{
    public class Reservations
    {
        public int Id { get; set; }
        [Required]
        public string? ReservationName { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public List<MenuItems>? Items { get; set; }
    }
}
