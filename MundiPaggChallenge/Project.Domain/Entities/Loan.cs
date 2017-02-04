using System;
using System.Collections.Generic;

namespace Project.Domain.Entities
{
    public class Loan
    {
        #region ' Properties '

        public virtual Guid Id { get; set; }
        public virtual bool Loaned { get; set; }

        #endregion

        #region ' Relationships '

        public virtual ICollection<Book> Books { get; set; }
        public virtual ICollection<Media> Medias { get; set; }
        public virtual Guid? PersonId { get; set; }
        public virtual Person Person { get; set; }

        #endregion
    }
}