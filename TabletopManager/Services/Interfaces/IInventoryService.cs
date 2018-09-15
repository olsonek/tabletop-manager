using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TabletopManager.Models;

namespace TabletopManager.Services.Interfaces
{
    public interface IInventoryService
    {
        void AddItem(Item item);

        void TagItem(string tag, Item item);

        void UntagItem(string tag, Item item);

        void DeleteTag(string tag);

        void BuildTagLookup();
    }
}
