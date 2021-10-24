using System.Collections.Generic;
using physics.Interfaces;

namespace physics
{
    public class Universe
    {
        public Dictionary<int, IEntity> components = new Dictionary<int, IEntity>();
    }
}