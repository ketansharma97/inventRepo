using Microsoft.EntityFrameworkCore;
using NSubstitute.ReceivedExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Invent.Models
{
    public class InventDbContext : DbContext
    {
        public InventDbContext()
        {
        }

        public InventDbContext( DbContextOptions options) : base(options)
        {
        }
        public DbSet<Shopkeeper> Shopkeeper { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Shopkeeper>().HasData
                (
                new Shopkeeper
                {ProductId = 1, ProductName = "Usha Celling Fan", ProductPrice = "550", Quantity = "10", Date = "22/04/2020" },
                 new Shopkeeper
                 { ProductId = 2, ProductName = "Usha Mixer Grinder", ProductPrice = "800", Quantity = "10" , Date = "22/04/2020" }
                );
        }
    }
}
