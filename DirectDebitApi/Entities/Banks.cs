using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MicroOrm.Dapper.Repositories.Attributes;

namespace DirectDebitApi.Entities
{
    [Table("banks")]
    public class Banks : BaseEntity
    {
        public string bankname { get; set; }
        public string cbncode { get; set; }
        public string routingno { get; set; }
        public string sortcode { get; set; }
        public DateTime createdat { get; set; } = DateTime.Now;
        public int createdby { get; set; }
        [UpdatedAt]
        public DateTime updatedat { get; set; }
        public int updatedby { get; set; }
        public string contactname { get; set; }
        [Phone]
        public string contactphone { get; set; }
        [EmailAddress]
        public string contactemail { get; set; }
        public string status { get; set; }
    }
}
