using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DirectDebitApi.Entities
{
    [Table("app_user_privileges")]
    public class AppUserPrivileges : BaseEntity
    {
        public string userid { get; set; }
        public string perms { get; set; }
    }
}
