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
    public class MenuController : ControllerBase
    {
        private readonly IMenuService _menuService;

        public MenuController(IMenuService menuService)
        {
            _menuService = menuService;
        }

        /// <summary>
        /// Gets the current list of available Menus
        /// </summary>
        /// <returns>A list of available Menus</returns>
        [HttpGet("GetMenus")]
        public async Task<ActionResult<List<Menu>>> GetMenus()
        {
            var menus = await _menuService.GetMenusAsync();
            return menus;
        }

        /// <summary>
        /// Gets
        /// Gets a menu for the corresponding id
        /// </summary>
        /// <param name="menuId"></param>
        /// <returns></returns>
        [HttpGet("GetMenu/{menuId}")]
        public async Task<ActionResult<Menu>> GetMenu(string menuId)
        {
            var menu = await _menuService.GetMenuAsync(menuId);
            return menu;
        }

        /// <summary>
        /// Gets the lists of Products for a Menu
        /// </summary>
        /// <param name="menuId"></param>
        /// <returns>A list of Products</returns>
        [HttpGet("GetProducts/{menuId}")]
        public async Task<ActionResult<List<Product>>> GetProducts(string menuId)
        {
            var products = await _menuService.GetMenuProductsAsync(menuId);
            return products;
        }
    }
}
