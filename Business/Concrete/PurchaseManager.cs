using Business.Abstract;
using DataAccess.Shared;
using Entities;

namespace Business.Concrete
{
    public class PurchaseManager : IPurchaseService
    {
        EfEntityRepository<Purchase> _repository = new EfEntityRepository<Purchase>();
        public void Add(Purchase purchase)
        {
            _repository.Add(purchase);
        }

        public void Delete(Purchase purchase)
        {
            _repository.Delete(purchase);
        }

        public List<Purchase> GetAll()
        {
            return _repository.GetAll();
        }

        public Purchase GetById(int id)
        {
            return _repository.Get(id);
        }

        public void Update(Purchase purchase)
        {
            _repository.Update(purchase);
        }
    }
}
