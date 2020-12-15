using System;
using DirectDebitApi.Entities;
using DirectDebitApi.Repositories;
using MicroOrm.Dapper.Repositories;

namespace DirectDebitApi.Services.AppPermTable
{
    public class AppPermTableService : GenericRepository<AppPermTables>, IAppPermTableService
    {
        public AppPermTableService(DapperRepository<AppPermTables> repository): base(repository)
        {
        }
    }
}
