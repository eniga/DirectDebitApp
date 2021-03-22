using System;
using System.ComponentModel.DataAnnotations;

namespace DirectDebitApi.Models
{
    public class UpdateStatusRequest
    {
        [Required]
        public string loanid { get; set; }
        [Required]
        public string status { get; set; }
    }
}
