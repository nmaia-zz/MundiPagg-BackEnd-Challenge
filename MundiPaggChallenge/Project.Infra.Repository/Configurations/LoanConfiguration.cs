using Project.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Project.Infra.Repository.Configurations
{
    public class LoanConfiguration : EntityTypeConfiguration<Loan>
    {
        public LoanConfiguration()
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
                .WithMany(p => p.Loans)
                .HasForeignKey(l => l.PersonId);

            #endregion
        }
    }
}
