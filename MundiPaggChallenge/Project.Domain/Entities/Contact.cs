using System;

namespace Project.Domain.Entities
{
    public class Contact
    {
        #region ' Properties '

        public virtual Guid Id { get; set; }
        public virtual string Cellphone { get; set; }
        public virtual string Email { get; set; }

        #endregion
    }
}