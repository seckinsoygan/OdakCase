using Business.Abstract;
using DataAccess.Concrete;
using DataAccess.Shared;
using Entities;

namespace Business.Concrete
{
    public class StockManager : IStockService
    {
        EfEntityRepository<Stock> _repository = new EfEntityRepository<Stock>();
        EfStockDal efstockDal = new EfStockDal();
        public void Add(Stock stock)
        {
            _repository.Add(stock);
        }

        public List<Stock> GetAll()
        {
            return _repository.GetAll();
        }

        public Stock GetById(int id)
        {
            return _repository.Get(id);
        }

        public Stock GetByProductId(int productId)
        {
            return efstockDal.GetStockByProductId(productId);
        }

        public void Update(Stock stock)
        {
            _repository.Update(stock);
        }
    }
}
