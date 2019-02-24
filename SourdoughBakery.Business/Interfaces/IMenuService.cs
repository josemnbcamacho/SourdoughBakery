using SourdoughBakery.Core.Models.Business;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SourdoughBakery.Business.Interfaces
{
    public interface IMenuService
    {
        Task<List<Menu>> GetMenusAsync();

        Task<Menu> GetMenuAsync(string menuId);

        Task<List<Product>> GetMenuProductsAsync(string menuId);
    }
}
