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
        public static readonly Spec<Product> IsForSaleSpec = new Spec<Product>(x=>x.IsForSale);
        public static readonly Spec<Product> IsInStockSpec = new Spec<Product>(x=>x.InStock>0);

        private readonly EntitiesDbContext _dbContext;
        private readonly IMapper _mapper;

        public ProductsController(EntitiesDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get([FromServices] DbContext dbContext, [FromQuery] ProductFilter productFilter, [FromQuery] string orderBy)
        {
            var spec = SpecBuilder<ProductListDto>.Build(productFilter);

            //dbContext.Products
            //    .Where(Product.IsForSaleSpec || Product.IsInStockSpec)
            //    .ToList();

            var q = _mapper
                .ProjectTo<ProductListDto>(_dbContext.Products)
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