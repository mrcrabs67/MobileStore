using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileStore.Models
{
    public class MoblieContext : DbContext
    {

        public DbSet<Phone> Phones { get; set; }
        public DbSet<Order> Orders { get; set; }
        public MoblieContext(DbContextOptions<MoblieContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

    }
}
