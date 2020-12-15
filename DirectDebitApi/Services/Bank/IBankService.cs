using System;
using DirectDebitApi.Entities;
using DirectDebitApi.Repositories;

namespace DirectDebitApi.Services.Bank
{
    public interface IBankService : IGenericRepository<Banks>
    {
    }
}
