using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DirectDebitApi.Entities
{
    [Table("app_log")]
    public class AppLogs : BaseEntity
    {
        public string clientid { get; set; }
        public string userid { get; set; }
        public string activity { get; set; }
        public string userip { get; set; }
        public string usertime { get; set; }
        public string userdate { get; set; }
    }
}
