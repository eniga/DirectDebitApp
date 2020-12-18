using System;
using DirectDebitApi.Entities;
using DirectDebitApi.Repositories;
using MicroOrm.Dapper.Repositories;

namespace DirectDebitApi.Services.Collateral
{
    public class CollateralService : GenericRepository<Collaterals>, ICollateralService
    {
        public CollateralService(DapperRepository<Collaterals> repository): base(repository)
        {
        }
    }
}
