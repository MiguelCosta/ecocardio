using EcoCardio.Domain;
using System.Data.Entity.ModelConfiguration;

namespace EcoCardio.Repository.EntityConfiguration
{
    internal class ExameConfiguration : EntityTypeConfiguration<Exame>
    {
        public ExameConfiguration()
        {
            HasKey(e => e.Id);

            Property(e => e.CavidadesCardiacas).IsOptional().HasMaxLength(4096);
            Property(e => e.Conclusao).IsOptional().HasMaxLength(4096);
            Property(e => e.Data).IsRequired();
            Property(e => e.DataNascimento).IsOptional();
            Property(e => e.DiametroAorta).IsOptional();
            Property(e => e.DiametroAuriculaEsquerda).IsOptional();
            Property(e => e.DiametroParedePosterior).IsOptional();
            Property(e => e.DiametroSepto).IsOptional();
            Property(e => e.DiametroVETeleadiastole).IsOptional();
            Property(e => e.DiametroVETelessistole).IsOptional();
            Property(e => e.Email).IsOptional().HasMaxLength(4096);
            Property(e => e.EspessuraParedesVentriculares).HasMaxLength(4096);
            Property(e => e.EstruturasValvulares).HasMaxLength(4096);
            Property(e => e.FirstName).IsOptional().HasMaxLength(4096);
            Property(e => e.FracaoEjecao).IsOptional();
            Property(e => e.FracaoEncurtamento).IsOptional();
            Property(e => e.FuncaoVentricular).HasMaxLength(4096);
            Property(e => e.Idade).IsOptional();
            Property(e => e.InfoClinica).IsOptional().HasMaxLength(4096);
            Property(e => e.LastName).IsOptional().HasMaxLength(4096);
            Property(e => e.MassasIntracavitarias).HasMaxLength(4096);
            Property(e => e.Morada).HasMaxLength(4096);
            Property(e => e.Nome).HasMaxLength(4096);
            Property(e => e.Numero).IsRequired();
            Property(e => e.NumeroProcesso).IsOptional();
            Property(e => e.NumeroSNS).IsOptional();
            Property(e => e.Observacao).IsOptional().HasMaxLength(4096);
            Property(e => e.Telefone).IsOptional().HasMaxLength(4096);
            Property(e => e.Telemovel).IsOptional().HasMaxLength(4096);
        }
    }
}
