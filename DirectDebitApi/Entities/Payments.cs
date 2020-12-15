using System;
using System.ComponentModel.DataAnnotations.Schema;
using MicroOrm.Dapper.Repositories.Attributes;

namespace DirectDebitApi.Entities
{
    [Table("payments")]
    public class Payments : BaseEntity
    {
        public int loanid { get; set; }
        public string paymentreference { get; set; }
        public decimal amount { get; set; }
        public DateTime createdat { get; set; } = DateTime.Now;
        public int createdby { get; set; }
        [UpdatedAt]
        public DateTime modifiedat { get; set; }
        public int modifiedby { get; set; }
        public string status { get; set; }
        public string paymentmode { get; set; }
    }
}
