using Entities;

namespace Business.Abstract
{
    public interface IStockService
    {
        List<Stock> GetAll();
        void Add(Stock stock);
        void Update(Stock stock);
        Stock GetById(int id);
        Stock GetByProductId(int productId);
    }
}
