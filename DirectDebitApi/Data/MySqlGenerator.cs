using System;
using MicroOrm.Dapper.Repositories.SqlGenerator;

namespace DirectDebitApi.Data
{
    public class MySqlGenerator<T> : SqlGenerator<T> where T : class
    {
        // intialize new class
        public MySqlGenerator() : base(SqlProvider.MySQL) { }
    }
}
