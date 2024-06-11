using Project3.Data;
using Project3.Models;

namespace Project3.Repository
{
    public interface ICustomerRepository : IBaseRepository<Customer>
    {

    }
    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor) : base(context, httpContextAccessor)
        {
        }
    }
}
