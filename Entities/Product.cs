using Entities.Shared;

namespace Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string? Image_Src { get; set; }
        public double? SalesPrice { get; set; }
        public int Category_Id { get; set; }
    }
}
