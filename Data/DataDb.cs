using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
namespace Data.DbContextLib
{
    public class DataDb : DbContext
    {
        protected readonly IConfiguration Configuration;
        protected static string ConnectionString = string.Empty;
        public DataDb(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }
        public DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<SupplierItem> SupplierItems { get; set; }
        public DbSet<Notification> Notifications { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


        }

        public DataDb()
        {

        }

    }
}
