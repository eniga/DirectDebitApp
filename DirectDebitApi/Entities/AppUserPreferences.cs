using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DirectDebitApi.Entities
{
    [Table("app_user_preferences")]
    public class AppUserPreferences : BaseEntity
    {
        public string userid { get; set; }
        public string email_message { get; set; }
        public string email_statement { get; set; }
        public string sms_alert { get; set; }
        public string invoice_autopay { get; set; }
        public string wallet_autorefill { get; set; }
        public string api_access { get; set; }
        public string social_feeds { get; set; }
        public string wallet_transactions { get; set; }
        public string free_transactions { get; set; }
    }
}
