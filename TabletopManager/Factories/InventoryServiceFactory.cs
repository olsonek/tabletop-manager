using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TabletopManager.Factories.Interfaces;
using TabletopManager.Models;
using TabletopManager.Services;
using TabletopManager.Services.Interfaces;

namespace TabletopManager.Factories
{
    public class InventoryServiceFactory : IInventoryServiceFactory
    {
        public IInventoryService CreateInventoryService(Inventory inventory)
        {
            return new InventoryService(inventory);
        }
    }
}
