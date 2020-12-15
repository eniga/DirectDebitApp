using System;
using DirectDebitApi.Entities;
using DirectDebitApi.Repositories;
using MicroOrm.Dapper.Repositories;

namespace DirectDebitApi.Services.Bank
{
    public class BankService : GenericRepository<Banks>, IBankService
    {
        public BankService(DapperRepository<Banks> repository): base(repository)
        {
        }
    }
}
