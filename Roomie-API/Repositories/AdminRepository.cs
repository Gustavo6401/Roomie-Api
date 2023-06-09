﻿using Roomie_API.Contexto;
using Roomie_API.Entities;
using Roomie_API.Interfaces.Repositories;
using Roomie_API.Repositories.Base;

namespace Roomie_API.Repositories
{
    public class AdminRepository : Repository<Admin>, IAdminRepository
    {
        private readonly RoomieContext _context;
        public AdminRepository(RoomieContext context) : base(context)
        {
            _context = context;
        }
    }
}
