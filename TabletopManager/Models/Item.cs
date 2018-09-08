using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TabletopManager.Models
{
    public class Item
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Nickname { get; set; }
        public string Type { get; set; }

        public HashSet<string> Tags { get; } = new HashSet<string>();
    }
}
