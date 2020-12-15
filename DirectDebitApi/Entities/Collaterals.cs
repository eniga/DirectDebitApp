using System;
using System.ComponentModel.DataAnnotations.Schema;
using MicroOrm.Dapper.Repositories.Attributes;

namespace DirectDebitApi.Entities
{
    [Table("collaterals")]
    public class Collaterals : BaseEntity
    {
        public string description { get; set; }
        public string location { get; set; }
        public decimal value { get; set; }
        public int customerid { get; set; }
        public DateTime createdat { get; set; } = DateTime.Now;
        public int createdby { get; set; }
        [UpdatedAt]
        public DateTime modifiedat { get; set; }
        public int modifiedby { get; set; }
        public string status { get; set; }
    }
}
