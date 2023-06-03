using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace CRUDAspNetNet6.Entities
{
    public class Usuario
    {
        public int Id { get; set; }

        public string? Nome { get; set; }

        public DateTime DataNascimento { get; set; }

        public string? Email { get; set; }
    }
}
