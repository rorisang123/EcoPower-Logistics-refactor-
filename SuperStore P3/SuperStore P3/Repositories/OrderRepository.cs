using Data;
using Models;

namespace EcoPower_Logistics.Repositories
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(SuperStoreContext context) : base(context)
        {
        }
        /*
        public Order GetMostRecentOrder()
        {
            return _context.Order.OrderByDescending(OrderRepository => OrderRepository.CreatedDate).FirstOrDefault();
        }*/
    }
}
