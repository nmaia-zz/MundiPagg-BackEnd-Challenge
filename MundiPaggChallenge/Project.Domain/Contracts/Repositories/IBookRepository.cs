using Project.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain.Contracts.Repositories
{
    public interface IBookRepository : IBaseRepository<Book, Guid>
    {

    }
}
