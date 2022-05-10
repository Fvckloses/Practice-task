using Microsoft.EntityFrameworkCore;
using task1.DataBase;

namespace ApplicationContextDB
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Tours> Tours { get; set; }
        public DbSet<Seasons> Seasons { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<Tourists> Tourists { get; set; }
        public DbSet<TouristsInfo> TouristsInfo { get; set; }
        public DbSet<Vouchers> Vouchers{ get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }
    }
}