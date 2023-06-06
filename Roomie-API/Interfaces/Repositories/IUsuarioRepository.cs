﻿using Roomie_API.Entities;
using Roomie_API.Interfaces.Repositories.Base;

namespace Roomie_API.Interfaces.Repositories
{
    public interface IUsuarioRepository : IRepository<Usuario>
    {
        public Task<Usuario> FazerLoginAsync(string email, string senha);
    }
}
