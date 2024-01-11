namespace SklepZKoszulkami.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IProductRepository ProductRepository { get; }
        IShoppingCartRepository ShoppingCart { get; }
        void Save();
    }
}
