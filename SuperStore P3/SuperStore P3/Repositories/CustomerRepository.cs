using Data;
using Models;

namespace EcoPower_Logistics.Repositories
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(SuperStoreContext context) : base(context)
        {
        }
        /*
        public Customer GetMostRecentCustomer()
        {
            return _context.Customer.OrderByDescending(CustomerRepository => CustomerRepository.CreatedDate).FirstOrDefault();
        }*/
    }
}
