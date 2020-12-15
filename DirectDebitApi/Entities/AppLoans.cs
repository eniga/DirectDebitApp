using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DirectDebitApi.Entities
{
    [Table("app_loans")]
    public class AppLoans : BaseEntity
    {
        public string loanbatchid { get; set; }
        public string loanid { get; set; }
        public string clientid { get; set; }
        public int bvn { get; set; }
        public string tel { get; set; }
        public string email { get; set; }
        public string fullname { get; set; }
        public string loanstatus { get; set; }
        public string loanamount { get; set; }
        public string loanapplydate { get; set; }
        public string loanduedate { get; set; }
        public string loaninterest { get; set; }
        public string loanrepaycycle { get; set; }
        public string loantotal { get; set; }
        public string loanapprovedate { get; set; }
        public string process_status { get; set; }
        public string process_date { get; set; }
        public string process_time { get; set; }
        public string process_user { get; set; }
    }
}
