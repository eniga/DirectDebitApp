using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MicroOrm.Dapper.Repositories.Attributes;

namespace DirectDebitApi.Entities
{
    [Table("customers")]
    public class Customers : BaseEntity
    {
        [Required]
        public string firstname { get; set; }
        public string middlename { get; set; }
        [Required]
        public string lastname { get; set; }
        [ReadOnly(true)]
        public string fullname => string.Format("{0} {1}", firstname, lastname);
        [Required]
        public DateTime dob { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        [Phone, Required]
        public string phone { get; set; }
        [EmailAddress, Required]
        public string email { get; set; }
        [StringLength(11), Required]
        public string bvn { get; set; }
        public DateTime createdat { get; set; } = DateTime.Now;
        public int createdby { get; set; }
        [UpdatedAt]
        public DateTime? updatedat { get; set; }
        public int? updatedby { get; set; }
        public string sex { get; set; }
        public string maritalstatus { get; set; }
        public string workplace { get; set; }
        public string employeeno { get; set; }
        public string status { get; set; }
        public string imagepath { get; set; }
    }
}
