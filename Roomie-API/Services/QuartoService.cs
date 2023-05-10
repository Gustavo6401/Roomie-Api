using AutoMapper;
using Roomie_API.DTOs;
using Roomie_API.Interfaces.Repositories.Base;
using Roomie_API.Interfaces.Services;
using Roomie_API.Services.Base;

namespace Roomie_API.Services;

public class QuartoService : ServiceBase<QuartoDTO, QuartoDTO>, IQuartoService
{
    public QuartoService(IRepository<QuartoDTO> repository, IMapper mapper) : base(repository, mapper)
    {
    }
}