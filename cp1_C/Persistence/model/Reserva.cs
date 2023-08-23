using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cp1_C.Persistence.model
{
    [Table("TB_C_RESERVA")]
    public class Reserva
    {
        [Key]
        public int ReservaId { get; set; }

        // FK -> Hospede
        // Relaçã 1 para 1 com Hospede
        [ForeignKey("HospedeId")]
        public int HospedeId { get; set; }
        public virtual Hospede Hospede { get; set; }

        // FK -> Quarto
        [ForeignKey("QuartoId")]
        public int QuartoId { get; set; }
        public virtual Quarto Quarto { get; set; }

        [Required]
        public DateTime DataEntrada { get; set; }

        [Required]
        public DateTime DataSaida { get; set; }

        [Required]
        public decimal ValorTotal { get; set; }

        // 1 - N com Pagamento
        public virtual ICollection<Pagamento> Pagamentos { get; set; }

    }
}
