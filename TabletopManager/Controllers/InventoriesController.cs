using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TabletopManager.Factories.Interfaces;
using TabletopManager.Models;
using TabletopManager.Repositories.Interfaces;

namespace TabletopManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoriesController : ControllerBase
    {
        private readonly IInventoryServiceFactory _inventoryServiceFactory;
        private readonly IInventoryRepository _inventoryRepository;

        public InventoriesController(
            IInventoryServiceFactory inventoryServiceFactory,
            IInventoryRepository inventoryRepository)
        {
            _inventoryServiceFactory = inventoryServiceFactory;
            _inventoryRepository = inventoryRepository;
        }

        [HttpGet]
        public IActionResult GetInventoriesIds()
        {
            return new ObjectResult(_inventoryRepository.GetInventories());
        }

        [HttpGet("{id}")]
        public IActionResult GetInventory(Guid id)
        {
            return new ObjectResult(_inventoryRepository.GetInventory(id));
        }

        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody] Inventory inventory)
        {
            try
            {
                _inventoryRepository.UpdateInventory(id, inventory);
                return new StatusCodeResult(200);
            }
            catch
            {
                return new StatusCodeResult(400);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            try
            {
                _inventoryRepository.DeleteInventory(id);
                return new StatusCodeResult(200);
            }
            catch
            {
                return new StatusCodeResult(400);
            }
        }
    }
}
