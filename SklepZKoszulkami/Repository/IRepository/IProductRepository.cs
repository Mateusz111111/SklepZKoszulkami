using SklepZKoszulkami.Models;

namespace SklepZKoszulkami.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product obj);
    }
}
