using Roomie_API.Contexto;
using Roomie_API.Entities;
using Roomie_API.Interfaces.Repositories;
using Roomie_API.Repositories.Base;

namespace Roomie_API.Repositories
{
    public class QuartoRepository : Repository<Quarto>, IQuartoRepository
    {
        public QuartoRepository(RoomieContext context) : base(context)
        {
        }
    }
}
