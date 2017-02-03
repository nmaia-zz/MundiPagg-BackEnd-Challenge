using System;
using System.Collections.Generic;

namespace Project.Domain.Entities
{
    public class Localization
    {
        public Localization()
        {
            Persons = new HashSet<Person>();
        }

        #region ' Properties '

        public virtual Guid Id { get; set; }
        public virtual bool Loaned { get; set; }

        #endregion

        #region ' Relationships '

        public virtual Guid? PersonId { get; set; }
        public virtual Person Person { get; set; }
        public virtual ICollection<Person> Persons { get; set; }

        #endregion
    }
}