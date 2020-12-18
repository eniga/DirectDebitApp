using System;
using DirectDebitApi.Entities;
using DirectDebitApi.Repositories;
using MicroOrm.Dapper.Repositories;

namespace DirectDebitApi.Services.Invoice
{
    public class InvoiceService : GenericRepository<Invoices>, IInvoiceService
    {
        public InvoiceService(DapperRepository<Invoices> repository): base(repository)
        {
        }
    }
}
