using DirectDebitApi.Entities;
using DirectDebitApi.Repositories;
using MicroOrm.Dapper.Repositories;

namespace DirectDebitApi.Services.User
{
    public class UserService : GenericRepository<Users>, IUserService
    {
        public UserService(DapperRepository<Users> repository) : base(repository)
        {
        }
    }
}
