using SistemaDeTarefas.Models;

namespace SistemaDeTarefas.Repositorios.Interfaces
{
    public interface IUsuarioRepositorio
    {
        Task<List<Models.UsuarioModel>> BuscarTodosUsuarios();

        Task<Models.UsuarioModel> BuscarPorId(int id);
        Task<Models.UsuarioModel> Adicionar(Models.UsuarioModel usuario);
        Task<Models.UsuarioModel> Atualizar(UsuarioModel usuario, int id);
        Task<bool> Apagar(int id);
    }
}
