using physics.Interfaces;

namespace physics.Systems
{
    public class Target : ISystem
    {
        private Universe _unv;        

        public Target(Universe unv)
        {
            _unv = unv;
        }
        
        public void TargetEntity(Entity originEntity, Entity targetEntity)
        {
            _unv.entities.Remove(targetEntity.Id);
        }

        public Universe GetUniverse() => _unv;
    }
}