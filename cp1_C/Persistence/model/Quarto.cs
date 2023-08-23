using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cp1_C.Persistence.model
{
    [Table("TB_C_QUARTO")]
    public class Quarto
    {

        [Key]
        public int QuartoId { get; set; }

        [Required]
        public string NumeroQuarto { get; set; }

        [Required]
        public decimal PrecoPorNoite { get; set; }

        // N - N com TipoQuarto
        public virtual ICollection<TipoQuarto> TipoQuartoId { get; set; }

    }
}
