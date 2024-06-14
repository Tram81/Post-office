using Project3.Data;
using Project3.Models;

namespace Project3.Repository
{
    public interface IOderDetailsRepository : IBaseRepository<OrderDetails>
    {

    }
    public class OderDetailsRepository : BaseRepository<OrderDetails>, IOderDetailsRepository
    {
        public OderDetailsRepository(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor) : base(context, httpContextAccessor)
        {
        }
    }
}
