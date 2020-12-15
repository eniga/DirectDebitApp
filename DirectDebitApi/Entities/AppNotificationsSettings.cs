using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DirectDebitApi.Entities
{
    [Table("app_notifications_settings")]
    public class AppNotificationsSettings : BaseEntity
    {
        public string clientid { get; set; }
        public string notificationid { get; set; }
        public string emailsubject { get; set; }
        public string emailbody { get; set; }
        public string smsbody { get; set; }
    }
}
