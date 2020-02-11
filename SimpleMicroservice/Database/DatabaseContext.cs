using Microsoft.EntityFrameworkCore;
using SimpleMicroservice.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleMicroservice.Database
{
    public class DatabaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-DPCC3SS\\MUSTAFA;Database=Microservice;Trusted_Connection=true");
            //  base.OnConfiguring(optionsBuilder);

            // for migration : add-migration initial ;  update-database -verbose

        }
    }
}
