using System.ComponentModel.DataAnnotations;

namespace CRUDAspNetNet6.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Preencher campo Nome")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "Preencher campo Data de Nascimento")]
        [Display(Name = "Data de Nascimento")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        public DateTime DataNascimento { get; set; }

        public string? Email { get; set; }
    }
}
