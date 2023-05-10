using AutoMapper;
using Roomie_API.DTOs;
using Roomie_API.Entities;
using Roomie_API.Interfaces.Repositories.Base;
using Roomie_API.Interfaces.Services;
using Roomie_API.Services.Base;

namespace Roomie_API.Services;

public class UsuarioService : ServiceBase<UsuarioDTO, Usuario>, IUsuarioService
{
    public UsuarioService(IRepository<Usuario> repository, IMapper mapper) : base(repository, mapper)
    {
    }
}