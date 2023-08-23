using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography.X509Certificates;

namespace cp1_C.Persistence.model
{
    [Table("TB_C_HOSPEDE")]
    public class Hospede
    {
        [Key]
        public int HospedeId { get; set; }

        [Required(ErrorMessage = "Esse campo não pode ser nulo")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Esse campo não pode ser nulo")]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "Esse campo não pode ser nulo")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Esse campo não pode ser nulo")]
        public string Telefone { get; set; }


    }
}
