using Project.Domain.Contracts.Repositories;
using Project.Domain.Entities;
using System;

namespace Project.Infra.Repository.Repositories
{
    public class PersonRepository : BaseRepository<Person, Guid>, IPersonRepository
    {

    }
}
