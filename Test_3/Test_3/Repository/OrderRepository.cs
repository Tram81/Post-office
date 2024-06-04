﻿using Test_3.Models;
using prj3.Models;
using Test_3.Repository;

namespace Test_3.Repository
{
    public interface IOrderRepository : IBaseRepository<Order>
    {

    }
    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        public OrderRepository(DataContext context, IHttpContextAccessor httpContextAccessor) : base(context, httpContextAccessor)
        {
        }
    }
}