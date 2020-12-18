using System;
using DirectDebitApi.Entities;
using DirectDebitApi.Repositories;

namespace DirectDebitApi.Services.Merchant
{
    public interface IMerchantService : IGenericRepository<Merchants>
    {
    }
}
