using System;
using System.ComponentModel.DataAnnotations.Schema;
using MicroOrm.Dapper.Repositories.Attributes;

namespace DirectDebitApi.Entities
{
    [Table("invoices")]
    public class Invoices : BaseEntity
    {
        public decimal amount { get; set; }
        public int customerid { get; set; }
        public int accountid { get; set; }
        public DateTime createdat { get; set; } = DateTime.Now;
        public int createdby { get; set; }
        [UpdatedAt]
        public DateTime modifiedat { get; set; }
        public int modifiedby { get; set; }
    }
}
