using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using MicroOrm.Dapper.Repositories.Attributes;

namespace DirectDebitApi.Entities
{
    [Table("users")]
    public class Users : BaseEntity
    {
        public string email { get; set; }
        public string password { get; set; }
        public string firstname { get; set; }
        public string middlename { get; set; }
        public string lastname { get; set; }
        [ReadOnly(true)]
        public string fullname => string.Format("{0} {1}", firstname, lastname);
        public string usertype { get; set; }
        public string merchantid { get; set; }
        public DateTime createdat { get; set; } = DateTime.Now;
        public int createdby { get; set; }
        [UpdatedAt]
        public DateTime modifiedat { get; set; }
        public int modifiedby { get; set; }
        public string status { get; set; }
        public DateTime lastlogindate { get; set; }
        public string role { get; set; }
        public string imagepath { get; set; }
    }
}
