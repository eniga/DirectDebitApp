using System;
using DirectDebitApi.Entities;
using DirectDebitApi.Repositories;

namespace DirectDebitApi.Services.Customer
{
    public interface ICustomerService : IGenericRepository<Customers>
    {
    }
}
