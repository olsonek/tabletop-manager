using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TabletopManager.Models;

namespace TabletopManager.Repositories.Interfaces
{
    public interface IInventoryRepository
    {
        Inventory GetInventory(Guid id);
        IEnumerable<Guid> GetInventories();
        void UpdateInventory(Guid id, Inventory inventory);
        void DeleteInventory(Guid id);
    }
}
