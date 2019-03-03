using Bogus;
using SourdoughBakery.Business.Interfaces;
using SourdoughBakery.Core.Models.Business;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SourdoughBakery.Business.Mock.Helpers;

namespace SourdoughBakery.Business.Mock
{
    public class MockMenuService : IMenuService
    {
        public async Task<Menu> GetMenuAsync(string menuId)
        {
            var product = FakerHelper.GetFakeProduct();
            var menu = FakerHelper.GetFakeMenu(product);

            return await Task.FromResult(menu.Generate());
        }

        public async Task<List<Product>> GetMenuProductsAsync(string menuId)
        {
            var product = FakerHelper.GetFakeProduct();
            return await Task.FromResult(product.Generate(10));
        }

        public async Task<List<Menu>> GetMenusAsync()
        {
            var product = FakerHelper.GetFakeProduct();
            var menu = FakerHelper.GetFakeMenu(product);

            return await Task.FromResult(menu.Generate(7));
        }
    }
}
