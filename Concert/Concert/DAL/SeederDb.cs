using Parcial3_LondonoValenciaSebastian.DAL;
using Parcial3_LondonoValenciaSebastian.DAL.Entities;

namespace Concert.DAL
{
    public class SeederDb
    {

        private readonly DataBaseContext _context;

        public SeederDb(DataBaseContext context)
        {
            _context = context;


        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await PopulateTicketsAsync();
            await _context.SaveChangesAsync();
        }

        private async Task PopulateTicketsAsync()
        {
            if (!_context.Tickets.Any())
            {
                for (int i = 0; i < 1000; i++)
                {
                    Guid newGuid = Guid.NewGuid();
                    _context.Tickets.Add(new Ticket { Id = newGuid, EntranceGate = null, IsUsed = false, UseDate = DateTime.Now });
                }

                await _context.SaveChangesAsync();
            }
        }
    }
}
