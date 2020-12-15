using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DirectDebitApi.Entities
{
    [Table("app_bunits")]
    public class AppBUnits : BaseEntity
    {
        public string clientid { get; set; }
        public string bunitid { get; set; }
        public string unitname { get; set; }
        public string frontend { get; set; }
        public string location { get; set; }
        public string businessnature { get; set; }
        public string startupcapital { get; set; }
        public string env { get; set; }
        public string status { get; set; }
        public string mainbunit { get; set; }
        public string mod_fx { get; set; }
        public string mod_inv { get; set; }
        public string mod_hotelrooms { get; set; }
        public string mod_restaurant { get; set; }
        public string mod_sms { get; set; }
        public string mod_payroll { get; set; }
        public string policy_autoapproval { get; set; }
        public string policy_outstock { get; set; }
        public string policy_abovefixed { get; set; }
        public string policy_directsales { get; set; }
        public string policy_autocash { get; set; }
    }
}
