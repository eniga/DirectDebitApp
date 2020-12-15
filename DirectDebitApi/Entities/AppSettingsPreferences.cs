using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DirectDebitApi.Entities
{
    [Table("app_settings_preferences")]
    public class AppSettingsPreferences : BaseEntity
    {
        public string clientid { get; set; }
        public string singlewarehouse { get; set; }
        public string email_statement { get; set; }
        public string sms_alert { get; set; }
        public string email_expire { get; set; }
        public string email_depletion { get; set; }
        public string saleabovefixed { get; set; }
        public string saleoutofstock { get; set; }
        public string totalreversal { get; set; }
        public string sms_alert_self { get; set; }
    }
}
