using System;
using System.Collections.Generic;
using System.Text;
using Bogus;
using SourdoughBakery.Core.Models.Business;

namespace SourdoughBakery.Business.Mock.Helpers
{
    public static class FakerHelper
    {
        public static Faker<Menu> GetFakeMenu(Faker<Product> product)
        {
            return new Faker<Menu>()
                .RuleFor(m => m.Id, f => f.UniqueIndex.ToString())
                .RuleFor(m => m.Name, f => f.Date.Weekday())
                .RuleFor(m => m.Products, product.Generate(10));
        }

        public static Faker<Product> GetFakeProduct()
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
