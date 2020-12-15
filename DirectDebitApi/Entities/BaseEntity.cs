using System;
using System.ComponentModel.DataAnnotations;

namespace DirectDebitApi.Entities
{
    public class BaseEntity
    {
        [Key]
        public int id { get; set; }
    }
}
