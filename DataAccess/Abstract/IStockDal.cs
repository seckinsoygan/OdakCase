using DataAccess.Shared;
using Entities;

namespace DataAccess.Abstract
{
    public interface IStockDal : IEntityRepository<Stock>
    {
        Stock GetStockByProductId(int productId);
    }
}
