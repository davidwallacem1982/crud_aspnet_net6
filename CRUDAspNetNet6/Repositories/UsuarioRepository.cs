using CRUDAspNetNet6.Data;
using CRUDAspNetNet6.Entities;
using CRUDAspNetNet6.Models;
using CRUDAspNetNet6.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CRUDAspNetNet6.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly SistemaDBContext _dbContext;
        public UsuarioRepository(SistemaDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IList<Usuario>> SelectAllUsuariosAsync() => await _dbContext.Usuarios.ToListAsync();

        public async Task<Usuario> SelectUsuarioByIdAsync(int Id) => await _dbContext.Usuarios.FirstOrDefaultAsync(x => x.Id == Id);

        public async Task<Usuario> InsertUsuarioAsync(Usuario usuario)
        {
            await _dbContext.Usuarios.AddAsync(usuario);
            await _dbContext.SaveChangesAsync();

            return usuario;
        }

        public async Task<Usuario> UpdateUsuarioAsync(int Id, UsuarioModel usuario)
        {
            var result = await SelectUsuarioByIdAsync(Id) ?? throw new Exception($"Usuário com o Id {Id} não foi encontrado!");

            result.Nome = usuario.Nome;
            result.DataNascimento = usuario.DataNascimento;
            result.Email = usuario.Email;

            _dbContext.Usuarios.Update(result);
            await _dbContext.SaveChangesAsync();

            return result;
        }

        public async Task<bool> DeleteUsuarioAsync(int Id)
        {
            var usuarioId = await SelectUsuarioByIdAsync(Id);

            if (usuarioId == null)
            {
                throw new Exception($"Usuário com o Id {Id} não foi encontrado!");
            }

            _dbContext.Usuarios.Remove(usuarioId);
            await _dbContext.SaveChangesAsync();

            return true;
        }
    }
}
