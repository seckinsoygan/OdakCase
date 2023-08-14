using Entities.Shared;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Sales : BaseEntity
    {
        public Product Product { get; set; }
        [ForeignKey("Product")]
        public int Product_Id { get; set; }
        public double? Quantity { get; set; }
        public double? SalesPrice { get; set; }
        public DateTime? Date { get; set; }
        public double? Amount { get; set; }
        public Customer Customer { get; set; }
        [ForeignKey("Customer")]
        public int Customer_Id { get; set; }
        public double? ListPrice { get; set; }
        public double? Discountrate { get; set; }
    }
}
