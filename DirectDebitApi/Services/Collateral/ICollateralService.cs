using System;
using DirectDebitApi.Entities;
using DirectDebitApi.Repositories;

namespace DirectDebitApi.Services.Collateral
{
    public interface ICollateralService : IGenericRepository<Collaterals>
    {
    }
}
