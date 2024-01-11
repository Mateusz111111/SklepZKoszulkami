using SklepZKoszulkami.Data;
using SklepZKoszulkami.Models;
using SklepZKoszulkami.Repository.IRepository;

namespace SklepZKoszulkami.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Product obj)
        {
            var objFromDb = _db.Products.FirstOrDefault(p => p.Id == obj.Id);

            if (objFromDb != null)
            {
                objFromDb.Name = obj.Name;
                objFromDb.Description = obj.Description;
                objFromDb.Club = obj.Club;
                objFromDb.Brand = obj.Brand;
                objFromDb.Size = obj.Size;
                objFromDb.Price = obj.Price;
                objFromDb.Season = obj.Season;
                if (objFromDb.ImageUrl != null)
                {
                    objFromDb.ImageUrl = objFromDb.ImageUrl;
                }
            }
        }
    }
}
