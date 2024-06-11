using Test_3.Models;
using prj3.Models;
using Test_3.Repository;

namespace Test_3.Repository
{
    public interface IUserRepository : IBaseRepository<User>
    {
        Task GetUserByUsername(string username);
    }
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(DataContext context, IHttpContextAccessor httpContextAccessor) : base(context, httpContextAccessor)
        {
        }
    }
}
