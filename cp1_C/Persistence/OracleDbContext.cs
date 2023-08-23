using cp1_C.Persistence.model;
using Microsoft.EntityFrameworkCore;

namespace cp1_C.Persistence
{
    public class OracleDbContext : DbContext

    {
        public DbSet<Hospede> Hospedes { get; set; }
        public DbSet<Pagamento> Pagamentos { get; set; } 
        public DbSet<Quarto> Quartos { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<TipoQuarto> TiposQuartos { get; set; }

        public OracleDbContext(DbContextOptions<OracleDbContext> options) : base(options) { }
    }
}
