using ApiAuditoria.Models;

namespace ApiAuditoria.Services.Senha
{
    public interface ISenhaInterface
    {
        void CriarSenhaHash(string senha, out byte[] senhaHash, out byte[] senhaSalt);
        bool VerificaSenhaHash(string senha, byte[] senhaHash, byte[] senhaSalt);

        string CriarToken(UsuarioModel usuario);
    }
}
