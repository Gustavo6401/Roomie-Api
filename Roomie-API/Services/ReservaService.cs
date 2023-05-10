using AutoMapper;
using Roomie_API.DTOs;
using Roomie_API.Entities;
using Roomie_API.Interfaces.Repositories.Base;
using Roomie_API.Interfaces.Services;
using Roomie_API.Services.Base;

namespace Roomie_API.Services;

public class ReservaService : ServiceBase<ReservaDTO, Reserva>, IReservaService
{
    public ReservaService(IRepository<Reserva> repository, IMapper mapper) : base(repository, mapper)
    {
    }
}
