using System;
using DirectDebitApi.Entities;
using DirectDebitApi.Repositories;
using MicroOrm.Dapper.Repositories;

namespace DirectDebitApi.Services.Mandate
{
    public class MandateService : GenericRepository<Mandates>, IMandateService
    {
        public MandateService(DapperRepository<Mandates> repository): base(repository)
        {
        }
    }
}
