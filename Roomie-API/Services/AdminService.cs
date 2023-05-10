using AutoMapper;
using Roomie_API.DTOs;
using Roomie_API.Entities;
using Roomie_API.Interfaces.Repositories.Base;
using Roomie_API.Interfaces.Services;
using Roomie_API.Services.Base;

namespace Roomie_API.Services;

public class AdminService : ServiceBase<AdminDTO, Admin>, IAdminService
{
    public AdminService(IRepository<Admin> repository, IMapper mapper) : base(repository, mapper)
    {
    }
}
