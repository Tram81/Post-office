using Project3.Data;
using Project3.Models;

namespace Project3.Repository
{
    public interface IOderRepository : IBaseRepository<Order>
    {

    }
    public class OderRepository : BaseRepository<Order>, IOderRepository
    {
        public OderRepository(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor) : base(context, httpContextAccessor)
        {
        }
    }
}
