using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TabletopManager.Models;
using TabletopManager.Services.Interfaces;

namespace TabletopManager.Factories.Interfaces
{
    public interface IInventoryServiceFactory
    {
        IInventoryService CreateInventoryService(Inventory inventory);
    }
}
