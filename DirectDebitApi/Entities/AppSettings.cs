using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DirectDebitApi.Entities
{
    [Table("AppSettings")]
    public class AppSettings : BaseEntity
    {
        public int clientid { get; set; }
        public string clientalias { get; set; }
        public string clientstatus { get; set; }
        public string company { get; set; }
        public string industry { get; set; }
        public string compslogan { get; set; }
        public string currency { get; set; }
        public string add1 { get; set; }
        public string add2 { get; set; }
        [Phone]
        public string tel { get; set; }
        [EmailAddress]
        public string email { get; set; }
        [Url]
        public string url { get; set; }
        public string country { get; set; }
        public string state { get; set; }
        public string logo { get; set; }
        public string startdate { get; set; }
        public string summary { get; set; }
        public string env { get; set; }
        public string smsid { get; set; }
        public string masterpin { get; set; }
        public string applogo { get; set; }
        public string appname { get; set; }
        public string appcolor1 { get; set; }
        public string appcolor2 { get; set; }
        public string appdomainstatus { get; set; }
        [Url]
        public string appdomain { get; set; }
        public string bpmprice { get; set; }
        public string agentmarkup { get; set; }
        public string agentphone { get; set; }
        [Url]
        public string agenturl { get; set; }
        public string agentcompany { get; set; }
    }
}
