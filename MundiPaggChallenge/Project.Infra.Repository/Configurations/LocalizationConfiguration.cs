using Project.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Project.Infra.Repository.Configurations
{
    public class LocalizationConfiguration : EntityTypeConfiguration<Localization>
    {
        public LocalizationConfiguration()
        {
            #region ' PK '

            HasKey(l => l.Id);

            Property(l => l.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            #endregion

            #region ' Properties '

            Property(l => l.Loaned)
                .IsRequired();

            #endregion

            #region ' Relationships '

            HasOptional(l => l.Person)
                .WithMany(p => p.Localizations)
                .HasForeignKey(l => l.PersonId)
                .WillCascadeOnDelete(false);

            #endregion
        }
    }
}
