using Test_3.Data;
using Test_3.Models;
using prj3.Models;
using Test_3.Data;
using Test_3.Repository;

namespace Test_3.Repository
{
    public interface IShipmentRepository : IBaseRepository<Shipment>
    {

    }
    public class ShipmentRepository : BaseRepository<Shipment>, IShipmentRepository
    {
        public ShipmentRepository(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor) : base(context, httpContextAccessor)
        {
        }
    }
}
