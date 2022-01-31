using System;
using Microsoft.EntityFrameworkCore;
using ShippingOrders.Models;

namespace ShippingOrders.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Items> Items { get; set; }
    }
}
