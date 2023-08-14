using Business.Abstract;
using DataAccess.Shared;
using Entities;

namespace Business.Concrete
{
    public class SalesManager : ISalesService
    {
        EfEntityRepository<Sales> _repository = new EfEntityRepository<Sales>();
        public void Add(Sales sales)
        {
            _repository.Add(sales);
        }

        public List<Sales> GetAll()
        {
            return _repository.GetAll();
        }
        public Sales GetById(int id)
        {
            return _repository.Get(id);
        }
        public void Delete(Sales sales)
        {
            _repository.Delete(sales);
        }
    }
}
