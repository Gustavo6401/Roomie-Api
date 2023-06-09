﻿using Microsoft.EntityFrameworkCore;
using Roomie_API.Contexto;
using Roomie_API.Entities;
using Roomie_API.Interfaces.Repositories;
using Roomie_API.Repositories.Base;

namespace Roomie_API.Repositories
{
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        private readonly RoomieContext _context;
        public UsuarioRepository(RoomieContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Usuario> FazerLoginAsync(string email, string senha)
        {
            var usuario = await _context.Usuario.FirstOrDefaultAsync(u => u.EMail.Equals(email)
                                                                     &&   u.Senha.Equals(senha));

            return usuario;
        }
    }
}
