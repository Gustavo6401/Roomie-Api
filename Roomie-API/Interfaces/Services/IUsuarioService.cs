using Roomie_API.DTOs;
using Roomie_API.Entities;
using Roomie_API.Interfaces.Services.Base;

namespace Roomie_API.Interfaces.Services
{
    public interface IUsuarioService : IServiceBase<UsuarioDTO, Usuario>
    {
        public Task<UsuarioDTO> FazerLoginAsync(string email, string senha);
    }
}
