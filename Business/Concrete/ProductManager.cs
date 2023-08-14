using Business.Abstract;
using DataAccess.Shared;
using Entities;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        EfEntityRepository<Product> _repository = new EfEntityRepository<Product>();

        public void Add(Product product)
        {
            _repository.Add(product);
        }

        public void Delete(Product product)
        {
            _repository.Delete(product);
        }

        public List<Product> GetAll()
        {
            return _repository.GetAll();
        }

        public void Update(Product product)
        {
            _repository.Update(product);
        }
    }
}
