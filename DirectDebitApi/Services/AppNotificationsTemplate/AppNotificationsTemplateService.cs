using System;
using DirectDebitApi.Entities;
using DirectDebitApi.Repositories;
using MicroOrm.Dapper.Repositories;

namespace DirectDebitApi.Services.AppNotificationsTemplate
{
    public class AppNotificationsTemplateService : GenericRepository<AppNotificatonsTemplate>, IAppNotificationsTemplateService
    {
        public AppNotificationsTemplateService(DapperRepository<AppNotificatonsTemplate> repository): base(repository)
        {
        }
    }
}
