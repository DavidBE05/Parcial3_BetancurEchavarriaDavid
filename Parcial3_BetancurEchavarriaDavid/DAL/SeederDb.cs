using Parcial3_BetancurEchavarriaDavid.DAL;    
using Parcial3_BetancurEchavarriaDavid.DAL.Entities;

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
            SeederDb _seederDb= new SeederDb(_context);
            await _seederDb.SeedAsync();
            await _context.Database.EnsureCreatedAsync();
            await PopulateTicketsAsync();
            
        }

        private async Task PopulateTicketsAsync()
        {
            if (!_context.Tickets.Any())
            {
                for (int i = 0; i < 1000; i++)
                {
                    Guid newGuid = Guid.NewGuid();
                    _context.Tickets.Add(new Ticket { Id = newGuid, EntranceGate = null, IsUsed = false, UseDate = null });
                }

                await _context.SaveChangesAsync();
            }
        }
    }
}
