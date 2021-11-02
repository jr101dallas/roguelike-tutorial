using System.Collections.Generic;
using Physics.Interfaces;

namespace Physics
{
    public class Entity : IEntity
    {
        public int Id;
        public Dictionary<string, IComponent> components = new Dictionary<string, IComponent>();
    }
}