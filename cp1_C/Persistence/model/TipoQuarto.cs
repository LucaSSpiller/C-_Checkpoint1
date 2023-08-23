using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cp1_C.Persistence.model
{
    [Table("TB_C_TIPO_QUARTO")]
    public class TipoQuarto
    {
        [Key]
        public int TipoQuartoId { get; set; }

        [Required]
        public string Descricao { get; set; }

        // N - N com Quarto
        public virtual ICollection<Quarto> QuartoId { get; set; }
    }
}
