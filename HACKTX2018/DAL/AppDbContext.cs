using HACKTX2018.Models;
using Microsoft.EntityFrameworkCore;

namespace HACKTX2018.DAL
{
      public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    //You need one db set for each model class. For example:

        public DbSet<Funder> Funders { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Order> Orders { get; set; }
}
}