using AutoMapper;
using Roomie_API.Entities;

namespace Roomie_API.DTOs.Mapper;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Usuario, UsuarioDTO>().ReverseMap();
        CreateMap<Quarto, QuartoDTO>().ReverseMap();
        CreateMap<Reserva, ReservaDTO>().ReverseMap();
        CreateMap<Admin, AdminDTO>().ReverseMap();
        CreateMap<Foto, FotoDTO>().ReverseMap();
    }
}