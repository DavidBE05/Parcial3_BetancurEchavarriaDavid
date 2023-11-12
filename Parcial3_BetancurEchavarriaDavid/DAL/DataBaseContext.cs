using Microsoft.EntityFrameworkCore;
using Parcial3_BetancurEchavarriaDavid.DAL.Entities;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Reflection.Emit;

namespace Parcial3_BetancurEchavarriaDavid.DAL
{
    public class DataBaseContext : DbContext
    {

        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {

        }
        // Se mapea la identidad para convertirla en una tabla
        public DbSet<Ticket> Tickets { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Ticket>().HasIndex(c => c.Id).IsUnique();

        }


    }
}
