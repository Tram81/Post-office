using Test_3.Data;
using Test_3.Models;
using prj3.Models;
using Test_3.Data;
using Test_3.Repository;

namespace Test_3.Repository
{
    public interface IAreaRepository : IBaseRepository<Area>
    {

    }
    public class AreaRepository : BaseRepository<Area>, IAreaRepository
    {
        public AreaRepository(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor) : base(context, httpContextAccessor)
        {
        }
    }
}
