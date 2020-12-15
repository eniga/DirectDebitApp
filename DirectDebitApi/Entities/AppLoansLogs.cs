using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DirectDebitApi.Entities
{
    [Table("app_loans_logs")]
    public class AppLoansLogs : BaseEntity
    {
        public string loanbatchid { get; set; }
        public string loanid { get; set; }
        public string clientid { get; set; }
        public string logtype { get; set; }
        public string logdate { get; set; }
        public string logtime { get; set; }
        public string activity { get; set; }
        public string process_user { get; set; }
    }
}
