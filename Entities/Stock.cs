using Entities.Shared;

namespace Entities
{
    public class Stock : BaseEntity
    {
        public int? Product_Id { get; set; }
        public double? Quantity { get; set; }
        public DateTime? Date { get; set; }
    }
}
