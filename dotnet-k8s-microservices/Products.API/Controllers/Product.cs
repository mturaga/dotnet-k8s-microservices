using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Products.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Oranges", "Apple", "PineApple"
        };

        private readonly ILogger<Product> _logger;

        public ProductController(ILogger<Product> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 3).Select(index => new Product
            {
                Id = Guid.NewGuid().ToString(),
                ProductName = Summaries[index-1],
                Quantity = Math.Abs(rng.Next() * index)
            })
            .ToArray();
        }
    }
}
