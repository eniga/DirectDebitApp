using System;
using DirectDebitApi.Entities;
using DirectDebitApi.Repositories;

namespace DirectDebitApi.Services.Disbursement
{
    public interface IDisbursementService : IGenericRepository<Disbursements>
    {
    }
}
