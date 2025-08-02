using ApiAuditoria.Dto.Login;
using ApiAuditoria.Dto.Usuario;
using ApiAuditoria.Models;

namespace ApiAuditoria.Services.Usuario
{
    public interface IUsuarioInterface
    {

        Task<ResponseModel<List<UsuarioModel>>> ListarUsuario();

        Task<ResponseModel<UsuarioModel>> BuscarUsuarioPorId(int id);

        Task<ResponseModel<UsuarioModel>> RemoverUsuario(int id);

        Task<ResponseModel<UsuarioModel>> RegistrarUsuario(UsuarioCriacaoDto  usuarioCriacaoDto);

        Task<ResponseModel<UsuarioModel>> EditarUsuario(UsuarioEdicaoDto usuarioEdicaoDto);

        Task<ResponseModel<UsuarioModel>> Login(UsuarioLoginDto usuarioLoginDto);





    }
}


