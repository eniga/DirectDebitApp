using System;
using DirectDebitApi.Entities;
using DirectDebitApi.Repositories;
using MicroOrm.Dapper.Repositories;

namespace DirectDebitApi.Services.AppRepayment
{
    public class AppRepaymentService : GenericRepository<AppRepayments>, IAppRepaymentService
    {
        public AppRepaymentService(DapperRepository<AppRepayments> repository): base(repository)
        {
        }
    }
}
