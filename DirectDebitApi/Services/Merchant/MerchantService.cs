using DirectDebitApi.Entities;
using DirectDebitApi.Repositories;
using MicroOrm.Dapper.Repositories;

namespace DirectDebitApi.Services.Merchant
{
    public class MerchantService : GenericRepository<Merchants>, IMerchantService
    {
        public MerchantService(DapperRepository<Merchants> repository): base(repository)
        {
        }
    }
}
