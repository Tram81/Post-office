using Test_3.Models;
using prj3.Models;
using Test_3.Repository;

namespace Test_3.Repository
{
    public interface IAdminRepository : IBaseRepository<Admin>
    {

    }
    public class AdminRepository : BaseRepository<Admin>, IAdminRepository
    {
        public AdminRepository(DataContext context, IHttpContextAccessor httpContextAccessor) : base(context, httpContextAccessor)
        {
        }
    }
}
