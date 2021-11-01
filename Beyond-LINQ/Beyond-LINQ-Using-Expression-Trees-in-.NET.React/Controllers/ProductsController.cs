using System.Linq;
using AutoMapper;
using Beyond_LINQ_Using_Expression_Trees_in_.NET.React.Data;
using Beyond_LINQ_Using_Expression_Trees_in_.NET.React.Models;
using Force.Ddd;
using Force.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Beyond_LINQ_Using_Expression_Trees_in_.NET.React.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController: Controller
    {
        //public static readonly Spec<Product> IsForSaleSpec = new Spec<Product>(x => x.IsForSale);
        //public static readonly Spec<Product> IsInStockSpec = new Spec<Product>(x => x.InStock > 900);

        private readonly EntitiesDbContext _dbContext;
        private readonly IMapper _mapper;

        public ProductsController(EntitiesDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get([FromServices] EntitiesDbContext dbContext, [FromQuery] ProductFilter productFilter, [FromQuery] string orderBy)
        {
            var spec = SpecBuilder<ProductListDto>.Build(productFilter);

            //var products = dbContext.Products
            //    .Where(x=>x.IsForSale)
            //    .ToList();

            //var elements = _dbContext.Products.Where(IsForSaleSpec||IsInStockSpec);

            //var prodPlusCategories = dbContext.Products.Select(x=>x.ProductName).Take(5).ToList();

            var results3 = _dbContext.Products.Where(Product.IsForSaleSpec 
                && Product.IsInStockMoreThanSpec
                && Product.IsStartsWithRSpec
                && Product.IsPriceMoreThanSpec
                );

            var q = _mapper
                .ProjectTo<ProductListDto>(results3)
                .Where(spec);

            if (orderBy != null)
            {
                q = q.OrderBy(orderBy);
            }

            var products = q.ToList();
            return Ok(products);
        }
    }
}