using System;
using DirectDebitApi.Entities;
using DirectDebitApi.Repositories;
using MicroOrm.Dapper.Repositories;

namespace DirectDebitApi.Services.AppLoansLog
{
    public class AppLoansLogService : GenericRepository<AppLoansLogs>, IAppLoansLogService
    {
        public AppLoansLogService(DapperRepository<AppLoansLogs> repository) : base(repository)
        {
        }
    }
}
