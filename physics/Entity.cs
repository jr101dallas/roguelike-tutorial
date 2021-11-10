using System.Collections.Generic;
using Physics.Components;
using Physics.Interfaces;

namespace Physics
{
    public class Entity : IEntity
    {
        public int Id;
        public Dictionary<ComponentType, IComponent> components = new Dictionary<ComponentType, IComponent>();
    }
}