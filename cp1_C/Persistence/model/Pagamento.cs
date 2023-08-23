using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cp1_C.Persistence.model
{
    [Table("TB_C_PAGAMENTO")]
    public class Pagamento
    {
        [Key]
        public int PagamentoId { get; set; }

        // FK -> Reserva
        [ForeignKey("ReservaId")]
        public int ReservaId { get; set; }
        public virtual Reserva Reserva { get; set; }


        [Required]
        public DateTime DataPagamento { get; set; }

        [Required]
        public decimal Valor { get; set; }




    }
}
