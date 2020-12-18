using System;
using DirectDebitApi.Entities;
using DirectDebitApi.Repositories;
using MicroOrm.Dapper.Repositories;

namespace DirectDebitApi.Services.Loan
{
    public class LoanService : GenericRepository<Loans>, ILoanService
    {
        public LoanService(DapperRepository<Loans> repository): base(repository)
        {
        }
    }
}
