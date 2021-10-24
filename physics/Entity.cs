using System.Collections.Generic;
using physics.Interfaces;

namespace physics
{
    public class Entity : IEntity
    {
        public int Id;
        public Dictionary<string, IComponent> components = new Dictionary<string, IComponent>();
    }
}