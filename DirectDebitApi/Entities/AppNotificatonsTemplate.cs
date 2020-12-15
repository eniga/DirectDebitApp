using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DirectDebitApi.Entities
{
    [Table("app_notifications_templates")]
    public class AppNotificatonsTemplate : BaseEntity
    {
        public string notification { get; set; }
        public string emailsubject { get; set; }
        public string emailbody { get; set; }
        public string smsbody { get; set; }
    }
}
