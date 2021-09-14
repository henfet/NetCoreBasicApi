using Microsoft.AspNetCore.Mvc;
using NetCoreBase.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreBase.Features.Inventory
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : Controller
    {
        private readonly InventoryAppService _inventoryAppService;
        public InventoryController(InventoryAppService inventoryAppService)
        {
            _inventoryAppService = inventoryAppService;
        }

        [HttpGet]
        [Route("get-items")]
        public async Task<IActionResult> GetAllItems()
        {
            Response response = await _inventoryAppService.GetAllItems();

            return Ok(response);
        }

        [HttpPost]
        [Route("post")]
        public async Task<IActionResult> saveGroupMember(string code, decimal quantity /*AlohaGroupMember member*/)
        {
            Response response = await _inventoryAppService.SaveNewItem(code, quantity/*member*/);

            return Ok(response);
        }
    }
}
