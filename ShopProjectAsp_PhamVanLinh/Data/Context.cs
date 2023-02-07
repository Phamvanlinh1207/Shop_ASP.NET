using Microsoft.EntityFrameworkCore;
using ShopProjectAsp_PhamVanLinh.Models;

namespace ShopProjectAsp_PhamVanLinh.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }
        public DbSet<User> users { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<OrderDetail> orderDetails { get; set; }

    }
}
