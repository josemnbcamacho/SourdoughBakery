using SourdoughBakery.Business.Interfaces;
using SourdoughBakery.Core.Models.Business;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SourdoughBakery.Business.Mock
{
    public class MockProductService : IProductService
    {
        public async Task<Product> GetProductAsync(string productId)
        {
            return await Task.FromResult(new Product());
        }
    }
}
