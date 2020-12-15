using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MicroOrm.Dapper.Repositories.Attributes;

namespace DirectDebitApi.Entities
{
    [Table("merchants")]
    public class Merchants : BaseEntity
    {
        public string merchantname { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string cacnumber { get; set; }
        public string contactname { get; set; }
        [Phone]
        public string contactphone { get; set; }
        [EmailAddress]
        public string contactemail { get; set; }
        public DateTime createdat { get; set; } = DateTime.Now;
        public int createdby { get; set; }
        [UpdatedAt]
        public string modifiedby { get; set; }
        public string status { get; set; }
    }
}
