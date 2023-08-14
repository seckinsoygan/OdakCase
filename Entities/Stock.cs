using Entities.Shared;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Stock : BaseEntity
    {
        public Product Product { get; set; }
        [ForeignKey("Product")]
        public int Product_Id { get; set; }
        public double? Quantity { get; set; }
        public DateTime? Date { get; set; }
    }
}
