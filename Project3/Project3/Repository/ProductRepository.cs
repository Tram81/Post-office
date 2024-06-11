using Project3.Data;
using Project3.Models;

namespace Project3.Repository
{
    public interface IProductRepository : IBaseRepository<Product>
    {

    }
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor) : base(context, httpContextAccessor)
        {
        }
    }
}
