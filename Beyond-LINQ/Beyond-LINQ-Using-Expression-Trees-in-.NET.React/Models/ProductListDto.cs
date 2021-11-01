using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Force.Ddd;


namespace Beyond_LINQ_Using_Expression_Trees_in_.NET.React.Models
{
    public class ProductListDto
    {
        public string Name { get; set; }
        
        public string CategoryName { get; set; }
        
        public decimal Price { get; set; }

        public long Id { get; set; }

        public static readonly Spec<Product> IsForSaleSpec
    = new Spec<Product>(x => x.IsForSale);

        public static readonly Spec<Product> IsInStockSpec
            = new Spec<Product>(x => x.InStock > 900);
    }
}