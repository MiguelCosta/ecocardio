using EcoCardio.Domain;
using System.Data.Entity.ModelConfiguration;

namespace EcoCardio.Repository.EntityConfiguration
{
    internal class TemplateConfiguration : EntityTypeConfiguration<Template>
    {
        public TemplateConfiguration()
        {
            HasKey(u => u.Id);

            Property(u => u.Nome)
                .IsRequired()
                .HasMaxLength(1024);

            Property(u => u.Texto)
                .HasMaxLength(4096);
        }
    }
}
