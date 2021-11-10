using System;
using Physics.Components;

namespace Physics
{
    public class EntityFactory
    {
        public Entity GetEntity(int lastEntityId)
        {
            var newEntityId = ++lastEntityId;
            Console.WriteLine($"Entity {newEntityId.ToString()} has entered play!");
            var newEntity = new Entity(){Id = newEntityId};
            newEntity.components.Add(ComponentType.Offense, new Offense());
            newEntity.components.Add(ComponentType.Inventory, new Inventory());
            return newEntity;
        }
    }
}