using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TabletopManager.Models;
using TabletopManager.Repositories.Interfaces;

namespace TabletopManager.Repositories
{
    public class MemoryInventoryRepository : IInventoryRepository
    {
        private readonly Dictionary<Guid, Inventory> InventoriesById;

        public Inventory GetInventory(Guid id)
        {
            return InventoriesById.ContainsKey(id) ? InventoriesById[id] : throw new KeyNotFoundException();
        }

        public IEnumerable<Guid> GetInventoryIds()
        {
            return InventoriesById.Keys;
        }

        public void UpdateInventory(Guid id, Inventory inventory)
        {
            if (InventoriesById.ContainsKey(id))
            {
                InventoriesById[id] = inventory;
            }
            else
            {
                throw new KeyNotFoundException();
            }
        }

        public void DeleteInventory(Guid id)
        {
            if (InventoriesById.ContainsKey(id))
            {
                InventoriesById.Remove(id);
            }
            else
            {
                throw new KeyNotFoundException();
            }
        }
    }
}
