using System;
using DirectDebitApi.Entities;
using DirectDebitApi.Repositories;

namespace DirectDebitApi.Services.Contact
{
    public interface IContactService : IGenericRepository<Contacts>
    {
    }
}
