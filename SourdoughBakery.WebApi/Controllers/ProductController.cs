using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SourdoughBakery.Business.Interfaces;
using SourdoughBakery.Core.Models.Business;

namespace SourdoughBakery.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        /// <summary>
        /// Gets a product for the corresponding id
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        [HttpGet("GetProduct/{productId}")]
        public async Task<ActionResult<Product>> GetProduct(string productId)
        {
            var product = await _productService.GetProductAsync(productId);
            return product;
        }
    }
}
