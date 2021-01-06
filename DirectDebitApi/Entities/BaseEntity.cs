using System;
using System.ComponentModel.DataAnnotations;
using MicroOrm.Dapper.Repositories.Attributes;

namespace DirectDebitApi.Entities
{
    public class BaseEntity
    {
        [Key, Identity]
        public int id { get; set; }
    }
}
