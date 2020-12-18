using System;
using DirectDebitApi.Entities;
using DirectDebitApi.Repositories;
using MicroOrm.Dapper.Repositories;

namespace DirectDebitApi.Services.Disbursement
{
    public class DisbursementService : GenericRepository<Disbursements>, IDisbursementService
    {
        public DisbursementService(DapperRepository<Disbursements> repository): base(repository)
        {
        }
    }
}
