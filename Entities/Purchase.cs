using Entities.Shared;

namespace Entities
{
    public class Purchase : BaseEntity
    {
        public float Quantity { get; set; }
        public float Price { get; set; }
        public float Amount { get; set; }
        public DateTime Date { get; set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
    }
}
