using Business.Abstract;
using DataAccess.Shared;
using Entities;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        EfEntityRepository<Category> _repository = new EfEntityRepository<Category>();
        public void Add(Category category)
        {
            _repository.Add(category);
        }

        public void Delete(Category category)
        {
            _repository.Delete(category);
        }

        public Category Get(int id)
        {
            return _repository.Get(id);
        }

        public List<Category> GetAll()
        {
            return _repository.GetAll();
        }

        public void Update(Category category)
        {
            _repository.Update(category);
        }
    }
}
