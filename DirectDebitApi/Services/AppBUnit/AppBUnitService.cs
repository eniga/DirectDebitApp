using DirectDebitApi.Entities;
using DirectDebitApi.Repositories;
using MicroOrm.Dapper.Repositories;

namespace DirectDebitApi.Services.AppBUnit
{
    public class AppBUnitService : GenericRepository<AppBUnits>, IAppBUnitService
    {
        public AppBUnitService(DapperRepository<AppBUnits> repository) : base(repository)
        {
        }
    }
}
