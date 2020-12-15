using System;
using DirectDebitApi.Entities;
using DirectDebitApi.Repositories;
using MicroOrm.Dapper.Repositories;

namespace DirectDebitApi.Services.AppLog
{
    public class AppLogService : GenericRepository<AppLogs>, IAppLogService
    {
        public AppLogService(DapperRepository<AppLogs> repository): base(repository)
        {
        }
    }
}
