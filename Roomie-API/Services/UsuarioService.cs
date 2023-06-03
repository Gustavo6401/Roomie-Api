using AutoMapper;
using Roomie_API.DTOs;
using Roomie_API.Entities;
using Roomie_API.Interfaces.Repositories;
using Roomie_API.Interfaces.Repositories.Base;
using Roomie_API.Interfaces.Services;
using Roomie_API.Services.Base;

namespace Roomie_API.Services;

public class UsuarioService : ServiceBase<UsuarioDTO, Usuario>, IUsuarioService
{
    private IMapper _mapper;
    private IUsuarioRepository _repository;
    public UsuarioService(IUsuarioRepository repository, IMapper mapper) : base(repository, mapper)
    {
        _mapper = mapper;
        _repository = repository;
    }
}