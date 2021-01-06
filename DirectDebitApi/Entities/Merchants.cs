using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MicroOrm.Dapper.Repositories.Attributes;

namespace DirectDebitApi.Entities
{
    [Table("merchants")]
    public class Merchants : BaseEntity
    {
        [Required]
        public string merchantname { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string cacnumber { get; set; }
        [Required]
        public string contactname { get; set; }
        [Phone, Required]
        public string contactphone { get; set; }
        [EmailAddress, Required]
        public string contactemail { get; set; }
        public DateTime createdat { get; set; } = DateTime.Now;
        public int createdby { get; set; }
        [UpdatedAt]
        public DateTime? updatedat { get; set; }
        public int? updatedby { get; set; }
        public string status { get; set; }
    }
}
