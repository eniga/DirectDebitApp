using DirectDebitApi.Entities;
using DirectDebitApi.Repositories;
using MicroOrm.Dapper.Repositories;

namespace DirectDebitApi.Services.AppSettingsPreference
{
    public class AppSettingsPreferenceService : GenericRepository<AppSettingsPreferences>, IAppSettingsPreferenceService
    {
        public AppSettingsPreferenceService(DapperRepository<AppSettingsPreferences> repository): base(repository)
        {
        }
    }
}
