using EcoCardio.Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace EcoCardio.Repository.EntityConfiguration
{
    internal class UtilizadorConfiguration : EntityTypeConfiguration<Utilizador>
    {
        public UtilizadorConfiguration()
        {
            HasKey(u => u.Id);

            Property(u => u.Nome)
                .IsRequired()
                .HasMaxLength(256);

            Property(u => u.Password)
                .IsRequired()
                .HasMaxLength(256);

            Property(u => u.Profile)
                .IsRequired();

            Property(u => u.Username)
                .IsRequired()
                .HasMaxLength(256)
                .HasColumnAnnotation(IndexAnnotation.AnnotationName,
                new IndexAnnotation(new IndexAttribute("IX_Username", 1) { IsUnique = true }));
        }
    }
}
