using Entities;

namespace Business.Abstract
{
    public interface IPurchaseService
    {
        List<Purchase> GetAll();
        void Add(Purchase purchase);
        void Delete(Purchase purchase);
        void Update(Purchase purchase);
        Purchase GetById(int id);
    }
}
