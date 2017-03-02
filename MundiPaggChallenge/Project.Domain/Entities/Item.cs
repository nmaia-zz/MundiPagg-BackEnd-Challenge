using Project.Domain.Entities.Types;
using System;

namespace Project.Domain.Entities
{
    public class Item
    {
        #region ' Properties '

        public virtual Guid Id { get; set; }
        public virtual string Title { get; set; }
        public virtual DateTime RegisterDate { get; set; }
        public virtual DateTime ReleaseDate { get; set; }
        public virtual bool Loaned { get; set; }

        #region ' Enums '

        public virtual ItemType ItemType { get; set; }
        public virtual Genre Genre { get; set; }

        #endregion

        #region ' Book Properties '

        public virtual string Author { get; set; }
        public virtual int Pages { get; set; }
        public virtual string Publisher { get; set; }

        #endregion

        #endregion

        #region ' Relationships '

        //ToDo: put these properties as protected in order to be changed by the SetLoan method
        //public virtual Guid LoanId { get; set; }
        //public virtual Loan Loan { get; set; }

        //public void SetLoan(Loan loan)
        //{
        //    if (loan == null) throw new ArgumentNullException(nameof(loan));
        //    if (loan.Id == Guid.Empty) throw new ArgumentNullException(nameof(loan));

        //    Loan = loan;
        //    LoanId = loan.Id;
        //}

        public virtual Person Person { get; set; }

        #endregion
    }
}
