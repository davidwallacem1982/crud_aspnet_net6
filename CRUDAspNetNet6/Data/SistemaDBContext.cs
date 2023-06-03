using CRUDAspNetNet6.Entities;
using CRUDAspNetNet6.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDAspNetNet6.Data
{
    public class SistemaDBContext : DbContext
    {
        public SistemaDBContext(DbContextOptions<SistemaDBContext> options) : base(options) {}

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Tarefa> Tarefas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new TarefaMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
