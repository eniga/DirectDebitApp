using System;
using DirectDebitApi.Entities;
using DirectDebitApi.Repositories;
using MicroOrm.Dapper.Repositories;

namespace DirectDebitApi.Services.Contact
{
    public class ContactService : GenericRepository<Contacts>, IContactService
    {
        public ContactService(DapperRepository<Contacts> repository): base(repository)
        {
        }
    }
}
