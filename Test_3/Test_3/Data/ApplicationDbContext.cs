using Test_3.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using prj3.Models;

namespace Test_3.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            this.initData();
        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Area> Areas { get; set; }
        public virtual DbSet<OrderDetails> OrderDetails { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Shipment> Shipments { get; set; }
        public virtual DbSet<User> Users {  get; set; }

        private void initData()
        {
            if (this.Products.Count() <= 0)
            {
                var p1 = new Product() { ProductName = "Letter" };
                var p2 = new Product() { ProductName = "Present" };
                var p3 = new Product() { ProductName = "Teddy bear" };

                this.Products.Add(p1);
                this.Products.Add(p2);
                this.Products.Add(p3);


                this.SaveChanges();

            }
        }
    }


}