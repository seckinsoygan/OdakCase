using Entities.Shared;

namespace Entities
{
    public class Sales : BaseEntity
    {
        public int? Product_Id { get; set; }
        public double? Quantity { get; set; }
        public double? SalesPrice { get; set; }
        public DateTime? Date { get; set; }
        public double? Amount { get; set; }
        public int? Customer_Id { get; set; }
        public double? ListPrice { get; set; }
        public double? Discountrate { get; set; }
    }
}
