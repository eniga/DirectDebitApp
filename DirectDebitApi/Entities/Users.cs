using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using AutoMapper;
using MicroOrm.Dapper.Repositories.Attributes;

namespace DirectDebitApi.Entities
{
    [Table("users")]
    public class Users : BaseEntity
    {
        [EmailAddress, Required]
        public string email { get; set; }
        [IgnoreMap]
        public string password { get; set; }
        [MaxLength(50), Required]
        public string firstname { get; set; }
        public string middlename { get; set; }
        [MaxLength(50), Required]
        public string lastname { get; set; }
        [ReadOnly(true)]
        public string fullname => string.Format("{0} {1}", firstname, lastname);
        public string usertype { get; set; }
        public string merchantid { get; set; }
        public DateTime createdat { get; set; } = DateTime.Now;
        public int createdby { get; set; }
        [UpdatedAt]
        public DateTime? updatedat { get; set; }
        public int? updatedby { get; set; }
        public string status { get; set; } = "Active";
        public DateTime? lastlogindate { get; set; }
        public string role { get; set; }
        [AllowNull]
        public string imagepath { get; set; }
        [NotMapped]
        public string token { get; set; }
    }

    public class UserDTO : BaseEntity
    {
        public string email { get; set; }
        public string firstname { get; set; }
        public string middlename { get; set; }
        public string lastname { get; set; }
        public string fullname => string.Format("{0} {1}", firstname, lastname);
        public string usertype { get; set; }
        public string merchantid { get; set; }
        public DateTime createdat { get; set; } = DateTime.Now;
        public int createdby { get; set; }
        public DateTime? updatedat { get; set; }
        public int? updatedby { get; set; }
        public string status { get; set; } = "Active";
        public DateTime? lastlogindate { get; set; }
        public string role { get; set; }
        public string imagepath { get; set; }
        public string token { get; set; }
    }
}
