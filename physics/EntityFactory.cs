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
            newEntity.components.Add(ComponentType.Defense, new Defense());
            newEntity.components.Add(ComponentType.Inventory, new Inventory());
            newEntity.components.Add(ComponentType.Offense, new Offense());
            return newEntity;
        }
    }
}