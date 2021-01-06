using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MicroOrm.Dapper.Repositories.Attributes;

namespace DirectDebitApi.Entities
{
    [Table("contacts")]
    public class Contacts : BaseEntity
    {
        [Required]
        public string firstname { get; set; }
        public string middlename { get; set; }
        [Required]
        public string lastname { get; set; }
        [ReadOnly(true)]
        public string fullname => string.Format("{0} {1}", firstname, lastname);
        [Phone, Required]
        public string phone { get; set; }
        [EmailAddress, Required]
        public string email { get; set; }
        public string category { get; set; }
        public DateTime createdat { get; set; } = DateTime.Now;
        public int createdby { get; set; }
        [UpdatedAt]
        public DateTime? updatedat { get; set; }
        public int? updatedby { get; set; }
        public string status { get; set; }
    }
}
