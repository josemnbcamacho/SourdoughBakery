using Bogus;
using SourdoughBakery.Business.Interfaces;
using SourdoughBakery.Core.Models.Business;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SourdoughBakery.Business.Mock
{
    public class MockMenuService : IMenuService
    {
        public async Task<Menu> GetMenuAsync(string menuId)
        {
            Faker<Product> product = GetFakeProduct();
            Faker<Menu> menu = GetFakeMenu(product);

            return await Task.FromResult(menu.Generate());
        }

        public async Task<List<Product>> GetMenuProductsAsync(string menuId)
        {
            Faker<Product> product = GetFakeProduct();

            return await Task.FromResult(product.Generate(10));
        }

        public async Task<List<Menu>> GetMenusAsync()
        {
            Faker<Product> product = GetFakeProduct();
            Faker<Menu> menu = GetFakeMenu(product);

            return await Task.FromResult(menu.Generate(7));
        }

        private static Faker<Menu> GetFakeMenu(Faker<Product> product)
        {
            return new Faker<Menu>()
                .RuleFor(m => m.Id, f => f.UniqueIndex.ToString())
                .RuleFor(m => m.Name, f => f.Date.Weekday())
                .RuleFor(m => m.Products, product.Generate(10));
        }

        private static Faker<Product> GetFakeProduct()
        {
            return new Faker<Product>()
                .RuleFor(p => p.Available, f => f.Random.Bool())
                .RuleFor(p => p.Description, f => f.Commerce.ProductAdjective())
                .RuleFor(p => p.Id, f => f.UniqueIndex.ToString())
                .RuleFor(p => p.IsGlutenFree, f => f.Random.Bool())
                .RuleFor(p => p.Name, f => f.Commerce.ProductName())
                .RuleFor(p => p.Price, f => f.Random.Decimal(0.5M, 2));
        }
    }
}
