using System;
using DirectDebitApi.Entities;
using DirectDebitApi.Repositories;

namespace DirectDebitApi.Services.Payment
{
    public interface IPaymentService : IGenericRepository<Payments>
    {
    }
}
