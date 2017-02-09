using Project.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Project.Infra.Repository.Configurations
{
    public class PersonConfiguration : EntityTypeConfiguration<Person>
    {
        public PersonConfiguration()
        {
            #region ' PK '

            HasKey(p => p.Id);

            Property(p => p.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            #endregion

            #region ' Properties '

            Property(p => p.FirstName)
                .HasMaxLength(100)
                .IsRequired();

            Property(p => p.LastName)
                .HasMaxLength(100)
                .IsRequired();

            Property(p => p.BirthDate)
                .IsRequired();

            Property(p => p.Gender)
                .IsRequired();

            #endregion
        }
    }
}
