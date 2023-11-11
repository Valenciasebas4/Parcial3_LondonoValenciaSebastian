using Microsoft.EntityFrameworkCore;
using Parcial3_LondonoValenciaSebastian.DAL.Entities;
using System.Diagnostics.Metrics;

namespace Parcial3_LondonoValenciaSebastian.DAL
{
    public class DataBaseContext :DbContext
    {

        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {

        }
        // Se mapea la identidad para convertirla en una tabla
        public DbSet<Ticket> Tickets { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            for (int i = 0; i < 30; i++)
            {
                modelBuilder.Entity<Ticket>().HasData(
                    new Ticket
                    {
                        Id = Guid.NewGuid(),
                        UseDate = null,
                        IsUsed = false,
                        EntranceGate = null
                    }
                );
            }
        }



    }
}
