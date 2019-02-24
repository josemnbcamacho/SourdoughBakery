using SourdoughBakery.Core.Models.Business;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SourdoughBakery.Business.Interfaces
{
    public interface IProductService
    {
        Task<Product> GetProductAsync(string productId);
    }
}
