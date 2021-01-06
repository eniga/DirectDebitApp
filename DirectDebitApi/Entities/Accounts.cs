using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MicroOrm.Dapper.Repositories.Attributes;

namespace DirectDebitApi.Entities
{
    [Table("accounts")]
    public class Accounts : BaseEntity
    {
        [MaxLength(20), Required]
        public string accountno { get; set; }
        [Required]
        public int customerid { get; set; }
        [Required]
        public int bankid { get; set; }
        public DateTime createdat { get; set; } = DateTime.Now;
        public int createdby { get; set; }
        [UpdatedAt]
        public DateTime? updatedat { get; set; }
        public int? updatedby { get; set; }
        public bool status { get; set; } = true;
    }
}
