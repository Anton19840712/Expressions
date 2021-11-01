using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Force.Ddd;

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

        public static readonly Spec<Product> IsPriceMoreThanSpec
            = new Spec<Product>(x => x.ProductPrice>700);

        public static readonly Spec<Product> IsStartsWithRSpec
            = new Spec<Product>(x => x.ProductName.StartsWith("R"));

        public static readonly Spec<Product> IsInStockMoreThanSpec
            = new Spec<Product>(x => x.InStock>2000);

        public static readonly Spec<Product> IsForSaleSpec
            = new Spec<Product>(x => x.IsForSale);
    }
}