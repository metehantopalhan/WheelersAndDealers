﻿using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Reflection;
using System.Reflection.Emit;

namespace Data.DbContextLib
{
    public class SqlDbContext : DataDb
    {
        public SqlDbContext(IConfiguration configuration) : base(configuration)
        {
            ConnectionString = Database.GetDbConnection().ConnectionString;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string connectionString = Configuration.GetConnectionString("DefaultConnection");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PurchaseOrderDetail>().Ignore(c => c.PurchaseOrderDetailStatus);
            modelBuilder.Entity<Item>().Ignore(c => c.ItemType);
            modelBuilder.Entity<Notification>().Ignore(c => c.UserType);

        }
        public SqlDbContext()
        {

        }
    }
}
