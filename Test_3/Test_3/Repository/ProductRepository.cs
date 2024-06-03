using Test_3.Data;
using Test_3.Models;
using prj3.Models;
using Test_3.Data;
using Test_3.Repository;

namespace Test_3.Repository
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
