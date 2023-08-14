using Entities;

namespace Business.Abstract
{
    public interface ISalesService
    {
        List<Sales> GetAll();
        void Add(Sales sales);
        Sales GetById(int id);
        void Delete(Sales sales);
    }
}
