using System;
using DirectDebitApi.Entities;
using DirectDebitApi.Repositories;

namespace DirectDebitApi.Services.AppRepayment
{
    public interface IAppRepaymentService : IGenericRepository<AppRepayments>
    {
    }
}
