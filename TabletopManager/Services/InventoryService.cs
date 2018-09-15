using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TabletopManager.Models;
using TabletopManager.Services.Interfaces;

namespace TabletopManager.Services
{
    public class InventoryService : IInventoryService
    {
        private readonly Inventory _inventory;
        private HashSet<Item> Items => _inventory?.Items;
        private Dictionary<string, HashSet<Item>> ItemsByTag;

        public InventoryService(Inventory inventory)
        {
            _inventory = inventory;
            ItemsByTag = new Dictionary<string, HashSet<Item>>();
            BuildTagLookup();
        }

        public void AddItem(Item item)
        {
            if (Items.Contains(item))
            {
                return;
            }

            this.AddItemToTagLookup(item);

            _inventory.Items.Add(item);
        }

        public void TagItem(string tag, Item item)
        {
            item.Tags.Add(tag);
            if (ItemsByTag.ContainsKey(tag))
            {
                ItemsByTag[tag].Add(item);
            }
            else
            {
                ItemsByTag.Add(tag, new HashSet<Item>() { item });
            }
        }

        public void UntagItem(string tag, Item item)
        {
            item.Tags.Remove(tag);
            if (ItemsByTag.ContainsKey(tag))
            {
                ItemsByTag[tag].Remove(item);
                if (ItemsByTag[tag].Count == 0)
                {
                    ItemsByTag.Remove(tag);
                }
            }
        }

        public void DeleteTag(string tag)
        {
            foreach (Item item in ItemsByTag[tag])
            {
                item.Tags.Remove(tag);
            }
            ItemsByTag.Remove(tag);
        }

        public void BuildTagLookup()
        {
            ItemsByTag.Clear();
            foreach (Item item in Items)
            {
                this.AddItemToTagLookup(item);
            }
        }

        private void AddItemToTagLookup(Item item)
        {
            foreach (string tag in item.Tags)
            {
                if (ItemsByTag.ContainsKey(tag))
                {
                    ItemsByTag[tag].Add(item);
                }
                else
                {
                    ItemsByTag.Add(tag, new HashSet<Item>() { item });
                }
            }
        }
    }
}
