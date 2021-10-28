namespace physics.Systems
{
    public class Infrastructure
    {
        private Universe _unv;
        public readonly Target target;
        public Infrastructure(Universe unv)
        {
            _unv = unv;
            target = new Target(_unv);
        }
    }
}