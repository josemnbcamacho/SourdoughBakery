using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using SourdoughBakery.Business.Interfaces;

namespace SourdoughBakery.AzureFunctions.Functions
{
    public class GetMenusFunction
    {
        private readonly IMenuService _menuService;

        public GetMenusFunction(IMenuService menuService)
        {
            _menuService = menuService;
        }

        [FunctionName("GetMenusFunction")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            var menus = await _menuService.GetMenusAsync();

            return new OkObjectResult(menus);
        }
    }
}
