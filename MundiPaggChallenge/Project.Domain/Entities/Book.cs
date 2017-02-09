using Project.Domain.Entities.Types;
using System;

namespace Project.Domain.Entities
{
    public class Book : Item
    {
        #region ' Constructors '

        public Book()
        {
            this.Id = Guid.NewGuid();
            this.ItemType = ItemType.Book;
        }

        #endregion

        #region ' Properties '

        public virtual string Author { get; set; }
        public virtual int Pages { get; set; }
        public virtual string PublishingCompany { get; set; }

        #region ' Enums '

        public virtual Genre Genre { get; set; }

        #endregion

        #endregion
    }
}
