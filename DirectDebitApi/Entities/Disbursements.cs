using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MicroOrm.Dapper.Repositories.Attributes;

namespace DirectDebitApi.Entities
{
    [Table("disbursements")]
    public class Disbursements : BaseEntity
    {
        [Required]
        public decimal amount { get; set; }
        [Required]
        public int loanid { get; set; }
        [Required]
        public string transactionreference { get; set; }
        public DateTime createdat { get; set; } = DateTime.Now;
        public int createdby { get; set; }
        [UpdatedAt]
        public DateTime? updatedat { get; set; }
        public int? updatedby { get; set; }
        public string disbursementmode { get; set; }
        public string status { get; set; }
    }
}
