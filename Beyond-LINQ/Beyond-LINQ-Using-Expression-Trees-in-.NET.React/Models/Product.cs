using System.Collections.Generic;

namespace Beyond_LINQ_Using_Expression_Trees_in_.NET.React.Models
{
    public class Product
    {
        public long ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int InStock { get; set; }
        public bool IsForSale { get; set; }
        public Category Category  { get; set; }
        public IEnumerable<OrderProduct> OrderProducts { get; set; }

    }
}