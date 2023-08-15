using DataAccess.Abstract;
using DataAccess.Shared;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete
{
    public class EfStockDal : EfEntityRepository<Stock>, IStockDal
    {
        AppDbContext context = new AppDbContext();
        DbSet<Stock> _object;

        public EfStockDal()
        {
            _object = context.Set<Stock>();
        }
        public Stock GetStockByProductId(int productId)
        {
            return _object.SingleOrDefault(x => x.Product_Id == productId);
        }
    }
}
