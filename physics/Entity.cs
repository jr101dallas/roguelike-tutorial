using System.Collections.Generic;

namespace physics
{
    public class Entity
    {
        public int Id;
        public Dictionary<string, IComponent> components = new Dictionary<string, IComponent>();
    }
}