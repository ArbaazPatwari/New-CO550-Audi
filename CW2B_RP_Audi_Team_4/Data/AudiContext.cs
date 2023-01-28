using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CW2B_RP_Audi_Team_4.Models;

namespace CW2B_RP_Audi_Team_4.Data
{
    public class AudiContext : DbContext
    {
        public AudiContext (DbContextOptions<AudiContext> options)
            : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<OrderItem> OrderItems { get; set; }

        public DbSet<CW2B_RP_Audi_Team_4.Models.Order> Order { get; set; }

        public DbSet<CW2B_RP_Audi_Team_4.Models.CarImage> CarImage { get; set; }

        public DbSet<CW2B_RP_Audi_Team_4.Models.Wishlist> Wishlist { get; set; }
    }
}
