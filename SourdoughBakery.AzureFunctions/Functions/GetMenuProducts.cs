using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using SourdoughBakery.Business.Interfaces;

namespace SourdoughBakery.AzureFunctions.Functions
{
    public class GetMenuProducts
    {
        private readonly IMenuService _menuService;

        public GetMenuProducts(IMenuService menuService)
        {
            _menuService = menuService;
        }

        [FunctionName("GetMenuProducts")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get")] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            string menuId = req.Query["menuId"];

            if (string.IsNullOrEmpty(menuId))
                return new BadRequestObjectResult("Please pass a menuId on the query string");

            var products = await _menuService.GetMenuProductsAsync(menuId);

            return new OkObjectResult(products);
        }
    }
}
