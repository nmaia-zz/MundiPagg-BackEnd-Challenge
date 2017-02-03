using Project.Domain.Entities.Types;
using System;

namespace Project.Domain.Entities
{
    public abstract class Item
    {
        #region ' Properties '

        public virtual Guid Id { get; set; }
        public virtual string Title { get; set; }
        public virtual DateTime RegisterDate { get; set; }
        public virtual DateTime ReleaseDate { get; set; }

        #region ' Enums '

        public virtual ItemType ItemType { get; set; }

        #endregion

        #endregion

        #region ' Relationships '

        public virtual Localization Localization { get; set; }

        #endregion
    }
}
