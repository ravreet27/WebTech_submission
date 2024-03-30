using Microsoft.EntityFrameworkCore;
using WebTech_submission.Models;

namespace WebTech_submission.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Cart> Cart { get; set; }
        public DbSet<CartItem> cartItem { get; set; }
        public DbSet<Order> Orders { get; set; }





    }
}
