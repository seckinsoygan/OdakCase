using Entities.Shared;

namespace Entities
{
    public class Sales : BaseEntity
    {
        public int ProductId { get; set; }
        public float Quantity { get; set; }
        public float SalePrice { get; set; }
        public DateTime Date { get; set; }
        public float Amount { get; set; }
        public int CustomerId { get; set; }
        public float ListPrice { get; set; }
        public float Discountrate { get; set; }
    }
}
