using System.Linq;
using Physics.Components;

namespace Physics
{
    public static class InventoryExtensions
    {
        public static Inventory GetFilteredInventory<T>(this Inventory inventory, T filterType)
        {            
            var inv = new Inventory();
            
            inv.items = inventory.items.Where(i => (i.Value is T)).ToDictionary(i => i.Key, i => i.Value);

            return inv;
        }
    }
}