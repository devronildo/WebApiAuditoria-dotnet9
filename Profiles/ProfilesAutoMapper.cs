using ApiAuditoria.Dto.Usuario;
using ApiAuditoria.Models;
using AutoMapper;

namespace ApiAuditoria.Profiles
{
    public class ProfilesAutoMapper : Profile
    {
        public ProfilesAutoMapper()
        {
            CreateMap<UsuarioCriacaoDto, UsuarioModel>().ReverseMap();
            
        }
    }
}
