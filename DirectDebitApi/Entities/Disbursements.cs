using System;
using System.ComponentModel.DataAnnotations.Schema;
using MicroOrm.Dapper.Repositories.Attributes;

namespace DirectDebitApi.Entities
{
    [Table("disbursements")]
    public class Disbursements : BaseEntity
    {
        public decimal amount { get; set; }
        public int loanid { get; set; }
        public string transactionreference { get; set; }
        public DateTime createdat { get; set; } = DateTime.Now;
        public int createdby { get; set; }
        [UpdatedAt]
        public DateTime modifiedat { get; set; }
        public int modifiedby { get; set; }
        public string disbursementmode { get; set; }
        public string status { get; set; }
    }
}
