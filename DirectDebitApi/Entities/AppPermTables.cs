using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DirectDebitApi.Entities
{
    [Table("app_perm_table")]
    public class AppPermTables : BaseEntity
    {
        public string perm { get; set; }
    }
}
