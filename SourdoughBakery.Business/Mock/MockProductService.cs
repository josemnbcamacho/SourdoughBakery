using SourdoughBakery.Business.Interfaces;
using SourdoughBakery.Core.Models.Business;
using System.Threading.Tasks;
using Bogus;
using SourdoughBakery.Business.Mock.Helpers;

namespace SourdoughBakery.Business.Mock
{
    public class MockProductService : IProductService
    {
        public async Task<Product> GetProductAsync(string productId)
        {
            var product = FakerHelper.GetFakeProduct();
            return await Task.FromResult(product.Generate());
        }
    }
}
