using Physics.Components;
using Physics.Interfaces;

namespace Physics
{
    public static class EntityExtensions
    {
        public static bool HasDefense(this Entity target, out Defense defCom)
        {
            bool foundDefense = HasComponent(target, ComponentType.Defense, out var defICom);
            defCom = (Defense)defICom;
            return foundDefense;
        }

        public static bool HasInventory(this Entity origin, out Inventory offCom)
        {
            bool foundInventory = HasComponent(origin, ComponentType.Inventory, out var invICom);
            offCom = (Inventory)invICom;
            return foundInventory;
        }

        public static bool HasOffense(this Entity origin, out Offense offCom)
        {
            bool foundOffense = HasComponent(origin, ComponentType.Offense, out var offICom);
            offCom = (Offense)offICom;
            return foundOffense;
        }

        public static bool HasComponent(this Entity entity, ComponentType type, out IComponent component)
        {
            return entity.components.TryGetValue(type, out component);;
        }
    }
}