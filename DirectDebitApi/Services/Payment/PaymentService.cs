using System;
using DirectDebitApi.Entities;
using DirectDebitApi.Repositories;
using MicroOrm.Dapper.Repositories;

namespace DirectDebitApi.Services.Payment
{
    public class PaymentService : GenericRepository<Payments>, IPaymentService
    {
        public PaymentService(DapperRepository<Payments> repository): base(repository)
        {
        }
    }
}
