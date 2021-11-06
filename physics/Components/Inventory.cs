using System.Collections.Generic;
using Physics.Interfaces;
using Physics.Items;

namespace Physics.Components
{
    public class Inventory : IComponent
    {
        public Dictionary<int, IItem> items = new Dictionary<int, IItem>();

        public Inventory()
        {
            items.Add(1,new Item());
        }
    }
}