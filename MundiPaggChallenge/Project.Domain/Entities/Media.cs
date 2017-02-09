using Project.Domain.Entities.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain.Entities
{
    public class Media : Item
    {
        #region ' Constructors '

        public Media()
        {
            this.Id = Guid.NewGuid();
            this.ItemType = ItemType.Media;
        }

        #endregion

        #region ' Properties '

        #region ' Enums '

        public virtual MediaType MediaType { get; set; }
        public virtual Genre Genre { get; set; }

        #endregion

        #endregion
    }
}
