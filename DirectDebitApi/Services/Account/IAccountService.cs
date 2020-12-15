using DirectDebitApi.Entities;
using DirectDebitApi.Repositories;

namespace DirectDebitApi.Services.Account
{
    public interface IAccountService : IGenericRepository<Accounts>
    {
    }
}
