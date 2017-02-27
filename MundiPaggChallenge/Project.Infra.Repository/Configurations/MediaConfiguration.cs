using Project.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Project.Infra.Repository.Configurations
{
    public class MediaConfiguration //: EntityTypeConfiguration<Media>
    {
        public MediaConfiguration()
        {
            //#region ' PK '

            //HasKey(m => m.Id);

            //Property(m => m.Id)
            //    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            //#endregion

            //#region ' Properties '

            //Property(m => m.Title)
            //    .HasMaxLength(100)
            //    .IsRequired();

            //Property(m => m.RegisterDate)
            //    .IsRequired();

            //Property(m => m.ReleaseDate)
            //    .IsRequired();

            //Property(m => m.ItemType)
            //    .IsRequired();

            //Property(m => m.Genre)
            //    .IsRequired();

            //Property(m => m.MediaType)
            //    .IsRequired();

            //Property(m => m.LoanId)
            //    .IsRequired();

            //#endregion

            //#region ' Relationships '

            //HasRequired(m => m.Loan)
            //    .WithMany(l => l.Medias)
            //    .HasForeignKey(m => m.LoanId);

            //#endregion
        }
    }
}
