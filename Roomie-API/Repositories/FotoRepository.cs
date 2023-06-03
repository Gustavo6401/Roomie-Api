using Roomie_API.Contexto;
using Roomie_API.Entities;
using Roomie_API.Interfaces.Repositories;
using Roomie_API.Repositories.Base;

namespace Roomie_API.Repositories
{
    public class FotoRepository : Repository<Foto>, IFotoRepository
    {
        private readonly RoomieContext _context;
        public FotoRepository(RoomieContext context) : base(context)
        {
            _context = context;
        }
    }
}
