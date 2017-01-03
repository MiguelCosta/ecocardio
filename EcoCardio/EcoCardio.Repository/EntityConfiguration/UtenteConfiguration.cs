using EcoCardio.Domain;
using System.Data.Entity.ModelConfiguration;

namespace EcoCardio.Repository.EntityConfiguration
{
    internal class UtenteConfiguration : EntityTypeConfiguration<Utente>
    {
        public UtenteConfiguration()
        {
            HasKey(u => u.Id);

            Property(u => u.DataNascimento).IsOptional();
            Property(u => u.Email).IsOptional().HasMaxLength(1024);
            Property(u => u.FirstName).IsOptional().HasMaxLength(1024);
            Property(u => u.LastName).IsOptional().HasMaxLength(1024);
            Property(u => u.Morada).IsOptional().HasMaxLength(4096);
            Property(u => u.Nome).IsRequired().HasMaxLength(4096);
            Property(u => u.NumeroProcesso).IsOptional();
            Property(u => u.NumeroSNS).IsOptional().HasMaxLength(1024);
            Property(u => u.Telefone).IsOptional().HasMaxLength(1024);
            Property(u => u.Telemovel).IsOptional().HasMaxLength(1024);
        }
    }
}
