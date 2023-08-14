using Entities.Shared;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string? Image_Src { get; set; }
        public double? SalesPrice { get; set; }
        public Category Category { get; set; }
        [ForeignKey("Category")]
        public int Category_Id { get; set; }
    }
}
