using Entities.Shared;

namespace Entities
{
    public class Stock : BaseEntity
    {
        public int ProductId { get; set; }
        public float Quantity { get; set; }
        public DateTime Date { get; set; }
    }
}
