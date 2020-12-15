using System;
using System.ComponentModel.DataAnnotations.Schema;
using MicroOrm.Dapper.Repositories.Attributes;

namespace DirectDebitApi.Entities
{
    [Table("accounts")]
    public class Accounts : BaseEntity
    {
        public string accountno { get; set; }
        public int customerid { get; set; }
        public int bankid { get; set; }
        public DateTime createdat { get; set; } = DateTime.Now;
        public int createdby { get; set; }
        [UpdatedAt]
        public DateTime modifiedat { get; set; }
        public int modifiedby { get; set; }
    }
}
