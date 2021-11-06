using System;

namespace Physics.Systems
{
    public class Infrastructure
    {
        private Universe _unv;
        public readonly Target target;
        public Infrastructure(Universe unv, Random rng)
        {
            _unv = unv;
            target = new Target(_unv, rng);
        }
    }
}