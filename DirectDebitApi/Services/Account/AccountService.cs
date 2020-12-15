using System;
using DirectDebitApi.Entities;
using DirectDebitApi.Repositories;
using MicroOrm.Dapper.Repositories;

namespace DirectDebitApi.Services.Account
{
    public class AccountService : GenericRepository<Accounts>, IAccountService
    {
        public AccountService(DapperRepository<Accounts> repository) : base(repository)
        {
        }
    }
}
