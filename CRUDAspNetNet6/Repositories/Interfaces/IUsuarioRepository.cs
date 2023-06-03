using CRUDAspNetNet6.Entities;
using CRUDAspNetNet6.Models;

namespace CRUDAspNetNet6.Repositories.Interfaces
{
    public interface IUsuarioRepository
    {
        Task<IList<Usuario>> SelectAllUsuariosAsync();
        Task<Usuario> SelectUsuarioByIdAsync(int Id);
        Task<Usuario> InsertUsuarioAsync(Usuario usuario);
        Task<Usuario> UpdateUsuarioAsync(int Id, UsuarioModel usuario);
        Task<bool> DeleteUsuarioAsync(int Id);
    }
}
