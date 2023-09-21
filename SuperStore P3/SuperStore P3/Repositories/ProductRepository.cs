using Data;
using Models;

namespace EcoPower_Logistics.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(SuperStoreContext context) : base(context)
        {
        }

        /*public Product GetMostRecentProduct()
        {
            return _context.Product.OrderByDescending(ProductRepository => ProductRepository.CreatedDate).FirstOrDefault();
        }*/
    }
}
