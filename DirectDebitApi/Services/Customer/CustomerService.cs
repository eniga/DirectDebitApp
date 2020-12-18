using System;
using DirectDebitApi.Entities;
using DirectDebitApi.Repositories;
using MicroOrm.Dapper.Repositories;

namespace DirectDebitApi.Services.Customer
{
    public class CustomerService : GenericRepository<Customers>, ICustomerService
    {
        public CustomerService(DapperRepository<Customers> repository): base(repository)
        {
        }
    }
}
