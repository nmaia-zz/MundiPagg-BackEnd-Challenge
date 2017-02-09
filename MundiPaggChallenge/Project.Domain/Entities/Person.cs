using Project.Domain.Entities.Types;
using System;
using System.Collections.Generic;

namespace Project.Domain.Entities
{
    public class Person
    {
        public Person()
        {
            this.Id = Guid.NewGuid();
        }

        #region ' Properties '

        public virtual Guid Id { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual DateTime BirthDate { get; set; }
        public virtual string Cellphone { get; set; }
        public virtual string Email { get; set; }

        #region ' Enums '

        public virtual Gender Gender { get; set; }

        #endregion

        #endregion

        #region ' Relationships '

        public virtual ICollection<Loan> Loans { get; set; }

        #endregion
    }
}