

using SklepZKoszulkami.Models;

namespace SklepZKoszulkami.Repository.IRepository
{
    public interface IShoppingCartRepository : IRepository<ShoppingCart>
    {
        void Update(ShoppingCart obj);
    }
}
