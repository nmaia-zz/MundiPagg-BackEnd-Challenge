using Project.Domain.Contracts.Repositories;
using Project.Domain.Contracts.Services;
using Project.Domain.Entities;
using System;

namespace Project.Domain.Services
{
    public class LoanDomainService : BaseDomainService<Loan, Guid>, ILoanDomainService
    {
        private readonly ILoanRepository repository;

        public LoanDomainService(ILoanRepository repository) : base(repository)
        {
            this.repository = repository;
        }
    }
}
