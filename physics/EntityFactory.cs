using System;

namespace Physics
{
    public class EntityFactory
    {
        public Entity GetEntity(int lastEntityId)
        {
            var newEntityId = ++lastEntityId;
            Console.WriteLine($"Entity {newEntityId.ToString()} has entered play!");            
            return new Entity(){
                Id = newEntityId
            };
        }
    }
}