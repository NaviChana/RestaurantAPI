using System.ComponentModel.DataAnnotations;

namespace RestaurantAPI2.Models
{
    public class MenuItems
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public int? Price { get; set; }
    }
}
