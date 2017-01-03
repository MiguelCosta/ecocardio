using EcoCardio.Domain;
using System.Data.Entity.ModelConfiguration;

namespace EcoCardio.Repository.EntityConfiguration
{
    internal class ResponsavelConfiguration : EntityTypeConfiguration<Responsavel>
    {
        public ResponsavelConfiguration()
        {
            HasKey(u => u.Id);

            Property(u => u.Nome)
                .IsRequired()
                .HasMaxLength(1024);
        }
    }
}
