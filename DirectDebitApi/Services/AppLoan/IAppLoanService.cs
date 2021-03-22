using System.Collections.Generic;
using System.Threading.Tasks;
using DirectDebitApi.Entities;
using DirectDebitApi.Repositories;

namespace DirectDebitApi.Services.AppLoan
{
    public interface IAppLoanService : IGenericRepository<AppLoans>
    {
        Task<int> AddRepayments(AppLoans items);
    }
}
