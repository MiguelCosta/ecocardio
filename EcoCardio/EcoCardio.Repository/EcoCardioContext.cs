using EcoCardio.Domain;
using EcoCardio.Repository.EntityConfiguration;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace EcoCardio.Repository
{
    public class EcoCardioContext : DbContext
    {
        public EcoCardioContext()
        {
            Configuration.AutoDetectChangesEnabled = true;
            Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Exame> Exames { get; set; }

        public DbSet<Responsavel> Responsaveis { get; set; }

        public DbSet<Servico> Servicos { get; set; }

        public DbSet<Template> Templates { get; set; }

        public DbSet<TransmissaoAcustica> TransmissoesAcusticas { get; set; }

        public DbSet<Utilizador> Utilizadores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Configurations.Add(new ExameConfiguration());
            modelBuilder.Configurations.Add(new ResponsavelConfiguration());
            modelBuilder.Configurations.Add(new ServicoConfiguration());
            modelBuilder.Configurations.Add(new TemplateConfiguration());
            modelBuilder.Configurations.Add(new TransmissaoAcusticaConfiguration());
            modelBuilder.Configurations.Add(new UtilizadorConfiguration());
        }
    }
}
