using DirectDebitApi.Entities;
using DirectDebitApi.Repositories;
using MicroOrm.Dapper.Repositories;

namespace DirectDebitApi.Services.AppSetting
{
    public class AppSettingService : GenericRepository<AppSettings>, IAppSettingService
    {
        public AppSettingService(DapperRepository<AppSettings> repository): base(repository)
        {
        }
    }
}
