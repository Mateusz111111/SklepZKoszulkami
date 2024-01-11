using SklepZKoszulkami.Data;
using SklepZKoszulkami.Models;
using SklepZKoszulkami.Repository.IRepository;

namespace SklepZKoszulkami.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _db;

        public IProductRepository ProductRepository { get; private set; }
        public IShoppingCartRepository ShoppingCart { get; private set; }

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            ProductRepository = new ProductRepository(_db);
            ShoppingCart = new ShoppingCartRepository(_db);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
