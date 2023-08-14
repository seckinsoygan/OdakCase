namespace DataAccess.Shared
{
    public interface IEntityRepository<T> where T : class
    {
        List<T> GetAll();
        T Get(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
