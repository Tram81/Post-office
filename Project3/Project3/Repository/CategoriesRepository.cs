using Project3.Data;
using Project3.Models;

namespace Project3.Repository
{
    public interface ICategoriesRepository : IBaseRepository<Categries>
    {

    }
    public class CategoriesRepository : BaseRepository<Categries>, ICategoriesRepository
    {
        public CategoriesRepository(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor) : base(context, httpContextAccessor)
        {
        }
    }
}
