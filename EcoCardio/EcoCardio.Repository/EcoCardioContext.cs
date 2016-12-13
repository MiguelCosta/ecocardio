using EcoCardio.Domain;
using System.Data.Entity;

namespace EcoCardio.Repository
{
    public class EcoCardioContext : DbContext
    {
        public DbSet<Servico> Servicos { get; set; }
    }
}
