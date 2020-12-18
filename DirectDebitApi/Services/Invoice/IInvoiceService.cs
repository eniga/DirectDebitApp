using System;
using DirectDebitApi.Entities;
using DirectDebitApi.Repositories;

namespace DirectDebitApi.Services.Invoice
{
    public interface IInvoiceService : IGenericRepository<Invoices>
    {
    }
}
