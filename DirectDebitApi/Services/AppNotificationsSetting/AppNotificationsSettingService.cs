using System;
using DirectDebitApi.Entities;
using DirectDebitApi.Repositories;
using MicroOrm.Dapper.Repositories;

namespace DirectDebitApi.Services.AppNotificationsSetting
{
    public class AppNotificationsSettingService : GenericRepository<AppNotificationsSettings>, IAppNotificationsSettingService
    {
        public AppNotificationsSettingService(DapperRepository<AppNotificationsSettings> repository): base(repository)
        {
        }
    }
}
