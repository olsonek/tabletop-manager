using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TabletopManager.Models
{
    public class Inventory
    {
        public Guid Id { get; set; }
        public HashSet<Item> Items { get; } = new HashSet<Item>();
        public Dictionary<string, HashSet<Item>> ItemsByTag { get; } = new Dictionary<string, HashSet<Item>>();
    }
}
