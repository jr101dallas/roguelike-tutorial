using physics.Interfaces;

namespace physics.Systems
{
    public class Target : ISystem
    {
        public void TargetEntity(Universe unv, Entity originEntity, Entity targetEntity)
        {
            unv.entities.Remove(targetEntity.Id);
        }
    }
}