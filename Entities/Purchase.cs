using Entities.Shared;

namespace Entities
{
    public class Purchase : BaseEntity
    {
        public double? Quantity { get; set; }
        public double? Price { get; set; }
        public double? Amount { get; set; }
        public DateTime? Date { get; set; }
        public int? Product_Id { get; set; }
        public int? Customer_Id { get; set; }
    }
}
