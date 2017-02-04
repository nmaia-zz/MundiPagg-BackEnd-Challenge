using Project.Domain.Entities;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;


namespace Project.Infra.Repository.Configurations
{
    public class BookConfiguration : EntityTypeConfiguration<Book>
    {
        #region ' Constructor '

        public BookConfiguration()
        {
            #region ' PK '

            HasKey(b => b.Id);

            Property(b => b.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            #endregion

            #region ' Properties '

            Property(b => b.Title)
                .HasMaxLength(100)
                .IsRequired();

            Property(b => b.RegisterDate)
                .IsRequired();

            Property(b => b.ReleaseDate)
                .IsRequired();

            Property(b => b.ItemType)
                .IsRequired();

            Property(b => b.Author)
                .HasMaxLength(100)
                .IsRequired();

            Property(b => b.Pages)
                .IsRequired();

            Property(b => b.PublishingCompany)
                .HasMaxLength(100)
                .IsRequired();

            Property(b => b.Genre)
                .IsRequired();

            Property(b => b.LoanId)
                .IsRequired();

            #endregion

            #region ' Relationships '

            HasRequired(b => b.Loan)
                .WithMany(l => l.Books)
                .HasForeignKey(b => b.LoanId);

            #endregion
        }

        #endregion
    }
}
