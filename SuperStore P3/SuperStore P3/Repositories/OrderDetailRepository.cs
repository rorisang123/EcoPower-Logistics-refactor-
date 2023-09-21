using Data;
using Models;

namespace EcoPower_Logistics.Repositories
{
    public class OrderDetailRepository : GenericRepository<OrderDetail>, IOrderDetailRepository
    {
        public OrderDetailRepository(SuperStoreContext context) : base(context)
        {
        }
        /*
        public OrderDetail GetMostRecentOrderDetail()
        {
            return _context.OrderDetail.OrderByDescending(OrderDetailRepository => OrderDetailRepository.CreatedDate).FirstOrDefault();
        }*/
    }
}
