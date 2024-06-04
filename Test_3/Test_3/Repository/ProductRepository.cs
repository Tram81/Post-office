using Test_3.Models;
using prj3.Models;
using Test_3.Repository;

namespace Test_3.Repository
{
    public interface IProductRepository : IBaseRepository<Product>
    {

    }
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(DataContext context, IHttpContextAccessor httpContextAccessor) : base(context, httpContextAccessor)
        {
        }
    }
}
