using Microsoft.EntityFrameworkCore;

namespace RestaurantAPI2.Models
{
    public class MenuItemsContext : DbContext
    {
        public MenuItemsContext(DbContextOptions<MenuItemsContext> options)
            : base(options)
        {
        }

        public DbSet<MenuItems> MenuItems { get; set; }
        
    }
}
