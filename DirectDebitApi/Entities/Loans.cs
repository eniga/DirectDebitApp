using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MicroOrm.Dapper.Repositories.Attributes;

namespace DirectDebitApi.Entities
{
    [Table("loans")]
    public class Loans : BaseEntity
    {
        [Required]
        public string loanid { get; set; }
        [Required]
        public decimal amount { get; set; }
        [Required]
        public int customerid { get; set; }
        [Required]
        public int accountid { get; set; }
        [Required]
        public decimal interestrate { get; set; }
        public DateTime createdat { get; set; } = DateTime.Now;
        public int createdby { get; set; }
        [UpdatedAt]
        public DateTime? updatedat { get; set; }
        public int? updatedby { get; set; }
        public string merchantid { get; set; }
        public DateTime lastpaymentdate { get; set; }
        public DateTime nextpaymentdate { get; set; }
        public decimal? amountpaid { get; set; }
        public decimal? amountleft { get; set; }
        public string status { get; set; }
    }
}
