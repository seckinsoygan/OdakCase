using Business.Abstract;
using DataAccess.Shared;
using Entities;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        EfEntityRepository<Customer> _repository = new EfEntityRepository<Customer>();
        public void Add(Customer customer)
        {
            _repository.Add(customer);
        }

        public void Delete(Customer customer)
        {
            _repository.Delete(customer);
        }

        public List<Customer> GetAll()
        {
            return _repository.GetAll();
        }

        public Customer GetById(int id)
        {
            return _repository.Get(id);
        }

        public void Update(Customer customer)
        {
            _repository.Update(customer);
        }
    }
}
