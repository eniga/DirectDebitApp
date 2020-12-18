using System;
using DirectDebitApi.Entities;
using DirectDebitApi.Repositories;

namespace DirectDebitApi.Services.Loan
{
    public interface ILoanService : IGenericRepository<Loans>
    {
    }
}
