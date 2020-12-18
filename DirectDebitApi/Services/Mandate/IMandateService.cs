using System;
using DirectDebitApi.Entities;
using DirectDebitApi.Repositories;

namespace DirectDebitApi.Services.Mandate
{
    public interface IMandateService : IGenericRepository<Mandates>
    {
    }
}
