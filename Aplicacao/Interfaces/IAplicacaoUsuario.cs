using System.Threading.Tasks;

namespace Aplicacao.Interfaces
{
    public interface IAplicacaoUsuario
    {
        Task<bool> AdicionaUsuario(string email, string senha);
        Task<bool> ExisteUsuario(string email, string senha);

        Task<string> RetornaIdUsuario(string email);
    }
}
