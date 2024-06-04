using Test_3.Models;
using prj3.Models;
using Test_3.Repository;

namespace Test_3.Repository
{
    public interface IOrderDetailsRepository : IBaseRepository<OrderDetails>
    {

    }
    public class OrderDetailsRepository : BaseRepository<OrderDetails>, IOrderDetailsRepository
    {
        public OrderDetailsRepository(DataContext context, IHttpContextAccessor httpContextAccessor) : base(context, httpContextAccessor)
        {
        }
    }
}
