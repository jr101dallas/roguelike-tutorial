using System;
using Physics.Interfaces;

namespace Physics.Systems
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
            var removeEntityId = targetEntity.Id;
            Console.WriteLine($"Entity {removeEntityId.ToString()} has been removed from play!");
            _unv.entities.Remove(removeEntityId);
        }

        public Universe GetUniverse() => _unv;
    }
}