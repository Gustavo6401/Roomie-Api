using Roomie_API.Contexto;
using Roomie_API.Entities;
using Roomie_API.Interfaces.Repositories;
using Roomie_API.Repositories.Base;

namespace Roomie_API.Repositories
{
    public class ReservaRepository : Repository<Reserva>, IReservaRepository
    {
        private readonly RoomieContext _context;
        public ReservaRepository(RoomieContext context) : base(context)
        {
            _context = context;
        }
    }
}
