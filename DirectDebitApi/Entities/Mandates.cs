﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MicroOrm.Dapper.Repositories.Attributes;

namespace DirectDebitApi.Entities
{
    [Table("mandates")]
    public class Mandates : BaseEntity
    {
        [Required]
        public int customerid { get; set; }
        [Required]
        public decimal amount { get; set; }
        [Required]
        public string mandatereference { get; set; }
        public int accountid { get; set; }
        public DateTime createdat { get; set; } = DateTime.Now;
        public int createdby { get; set; }
        [UpdatedAt]
        public DateTime? updatedat { get; set; }
        public int? updatedby { get; set; }
        public string status { get; set; }
    }
}
