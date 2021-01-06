using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MicroOrm.Dapper.Repositories.Attributes;

namespace DirectDebitApi.Entities
{
    [Table("collaterals")]
    public class Collaterals : BaseEntity
    {
        [Required]
        public string description { get; set; }
        [Required]
        public string location { get; set; }
        [Required]
        public decimal value { get; set; }
        [Required]
        public int customerid { get; set; }
        public DateTime createdat { get; set; } = DateTime.Now;
        public int createdby { get; set; }
        [UpdatedAt]
        public DateTime? updatedat { get; set; }
        public int? updatedby { get; set; }
        public string status { get; set; }
    }
}
