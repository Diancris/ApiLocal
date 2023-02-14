using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ServiceContext : DbContext
    {
        public ServiceContext(DbContextOptions<ServiceContext> options) : base(options) { }
        public DbSet<ProductItem> Products { get; set; }
        //public DbSet<OrderItem> Orders { get; set; }
        //public DbSet<RolesItem> Roles { get; set; }
        public DbSet<UserItem> Users { get; set; }
        //public DbSet<BrandItem> Brands { get; set; }
        //public DbSet<DeliveredStatusItem> DeliveredStatuses { get; set; }
        //public DbSet<StatusPaidItem> StatusPaids { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ProductItem>()
            .ToTable("Products");

            //builder.Entity<OrderItem>()
            //.ToTable("Orders")
            //.HasOne<ProductItem>()
            //.WithMany()
            //.HasForeignKey(o => o.ProductId);                      

            builder.Entity<UserItem>()
            .ToTable("Users");

            //builder.Entity<RolesItem>()
            //.ToTable("Roles");

            //builder.Entity<BrandItem>()
            //.ToTable("Brands");

            //builder.Entity<DeliveredStatusItem>()
            //.ToTable("DeliveredStatuses");

            //builder.Entity<StatusPaidItem>()
            //    .ToTable("StatusPaids");            
        }
    }
    public class ServiceContextFactory : IDesignTimeDbContextFactory<ServiceContext>
    {
        public ServiceContext CreateDbContext(string[] args)
        {
            var builder = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json", false, true);
            var config = builder.Build();
            var connectionString = config.GetConnectionString("ServiceContext");
            var optionsBuilder = new DbContextOptionsBuilder<ServiceContext>();
            optionsBuilder.UseSqlServer(config.GetConnectionString("ServiceContext"));

            return new ServiceContext(optionsBuilder.Options);
        }
    }
}
