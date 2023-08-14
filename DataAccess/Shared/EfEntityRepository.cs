using Microsoft.EntityFrameworkCore;

namespace DataAccess.Shared
{
    public class EfEntityRepository<T> : IEntityRepository<T> where T : class
    {
        AppDbContext context = new AppDbContext();
        DbSet<T> _object;

        public EfEntityRepository()
        {
            _object = context.Set<T>();
        }

        public void Add(T entity)
        {
            _object.Add(entity);
            context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _object.Remove(entity);
            context.SaveChanges();
        }

        public T Get(int id)
        {
            return _object.Find(id);
        }

        public List<T> GetAll()
        {
            return _object.ToList();
        }

        public void Update(T entity)
        {
            _object.Update(entity);
            context.SaveChanges();
        }
    }
}
