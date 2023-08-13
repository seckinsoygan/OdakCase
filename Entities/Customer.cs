using Entities.Shared;

namespace Entities
{
    public class Customer : BaseEntity
    {
        public string CustomerTitle { get; set; }
        public string CustomerNumber { get; set; }
    }
}
