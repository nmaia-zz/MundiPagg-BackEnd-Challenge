using Project.Domain.Entities.Types;
using System;
using System.Collections.Generic;

namespace Project.Domain.Entities
{
    public class Person
    {
        #region ' Properties '

        public virtual Guid Id { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual DateTime BirthDate { get; set; }

        #region ' Enums '

        public virtual Gender Gender { get; set; }

        #endregion

        #endregion

        #region ' Relationships '

        public virtual ICollection<Localization> Localizations { get; set; }
        public virtual Contact Contact { get; set; }

        #endregion
    }
}