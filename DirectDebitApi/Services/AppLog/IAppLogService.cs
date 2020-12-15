using System;
using DirectDebitApi.Entities;
using DirectDebitApi.Repositories;

namespace DirectDebitApi.Services.AppLog
{
    public interface IAppLogService : IGenericRepository<AppLogs>
    {
    }
}
