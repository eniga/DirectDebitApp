using System;
using DirectDebitApi.Entities;
using DirectDebitApi.Repositories;
using MicroOrm.Dapper.Repositories;

namespace DirectDebitApi.Services.AppUserPreference
{
    public class AppUserPreferenceService : GenericRepository<AppUserPreferences>, IAppUserPreferenceService
    {
        public AppUserPreferenceService(DapperRepository<AppUserPreferences> repository): base(repository)
        {
        }
    }
}
