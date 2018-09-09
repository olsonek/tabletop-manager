using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TabletopManager.Models;
using TabletopManager.Repositories.Interfaces;

namespace TabletopManager.Repositories
{
    public class InventoryRepository : IInventoryRepository
    {
        public Inventory GetInventory(Guid id)
        {
            return new Inventory() { Id = id };
        }

        public IEnumerable<Guid> GetInventories()
        {
            return new List<Guid>() { Guid.Empty };
        }

        public void UpdateInventory(Guid id, Inventory inventory)
        {
            return;
        }

        public void DeleteInventory(Guid id)
        {
            return;
        }
    }
}
