using CRUDAspNetNet6.Enum;

namespace CRUDAspNetNet6.Entities
{
    public class Tarefa
    {
        public int Id { get; set; }

        public string? Nome { get; set; }

        public string? Descricao { get; set; }

        public StatusTarefa Status { get; set; }
    }
}
