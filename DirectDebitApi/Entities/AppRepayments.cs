using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DirectDebitApi.Entities
{
    [Table("app_repayments")]
    public class AppRepayments : BaseEntity
    {
        public string loanid { get; set; }
        public string clientid { get; set; }
        public string repaymentstatus { get; set; }
        public string repaymentamount { get; set; }
        public string repaymentdate { get; set; }
        public string repaymentcycle { get; set; }
        public string repaymentmode { get; set; }
        public string repaymentlog { get; set; }
    }
}
