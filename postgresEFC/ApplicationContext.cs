using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace postgresEFC
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext()
        {
            Database.EnsureCreated();
        }
        // public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        // {            
        // }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        // использование Fluent API
            base.OnModelCreating(modelBuilder);
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=postgres");
        }
        public  DbSet<User> Users { get; set; }
        public  DbSet<Order> Orders { get; set; }

    }
}