using System;
using DirectDebitApi.Entities;
using DirectDebitApi.Repositories;
using MicroOrm.Dapper.Repositories;

namespace DirectDebitApi.Services.AppLoan
{
    public class AppLoanService : GenericRepository<AppLoans>, IAppLoanService
    {
        public AppLoanService(DapperRepository<AppLoans> repository) : base(repository)
        {
        }
    }
}
