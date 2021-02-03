using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exchange.Api.Models.Context
{
   public class AppDbContext:DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {

        }
      
        public DbSet<CurrencyModel> CurrencyModels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CurrencyModel>()
                  .Property(e => e.ForexBuying)
                  .HasPrecision(18, 5);
        }
    }
}
