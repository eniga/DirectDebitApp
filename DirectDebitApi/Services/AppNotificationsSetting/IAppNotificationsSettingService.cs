using System;
using DirectDebitApi.Entities;
using DirectDebitApi.Repositories;

namespace DirectDebitApi.Services.AppNotificationsSetting
{
    public interface IAppNotificationsSettingService : IGenericRepository<AppNotificationsSettings>
    {
    }
}
