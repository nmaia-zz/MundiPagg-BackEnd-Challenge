using Project.Application.Contracts;
using Project.Domain.Contracts.Services;
using Project.Domain.Entities;
using System;

namespace Project.Application.Services
{
    public class LoanApplicationService : BaseApplicationService<Loan, Guid>, ILoanApplicationService
    {
        private readonly ILoanDomainService domain;

        public LoanApplicationService(ILoanDomainService domain) : base(domain)
        {
            this.domain = domain;
        } 
    }
}
