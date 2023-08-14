using Entities.Shared;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Purchase : BaseEntity
    {
        public double? Quantity { get; set; }
        public double? Price { get; set; }
        public double? Amount { get; set; }
        public DateTime? Date { get; set; }
        public Product Product { get; set; }
        [ForeignKey("Product")]
        public int Product_Id { get; set; }
        [ForeignKey("Customer")]
        public int Customer_Id { get; set; }
        public Customer Customer { get; set; }
    }
}
