using System;

namespace Physics.Systems
{
    public class Infrastructure
    {
        private Universe _unv;
        public readonly Target target;
        public readonly Collision collision;
        public Infrastructure(Universe unv, Random rng)
        {
            _unv = unv;
            target = new Target(_unv, rng);
            collision = new Collision(_unv);
        }
    }
}