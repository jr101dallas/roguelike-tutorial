using System;
using Physics.Components;
using Physics.Interfaces;

namespace Physics.Systems
{
    public class Target : ISystem
    {
        private Universe _unv;
        private Random _rand = new Random();

        public Target(Universe unv)
        {
            _unv = unv;
        }
        
        public void TargetEntity(Entity originEntity, Entity targetEntity)
        {
            if (!originEntity.components.TryGetValue("Aim", out var aimIComponent)) return;

            var aimComponent = (Aim)aimIComponent;
            var aimModifier = aimComponent.BaseAim;
            
            if (_rand.Next(100) + aimModifier > 50)
            {
                var removeEntityId = targetEntity.Id;
                Console.WriteLine($"Entity {removeEntityId.ToString()} has been removed from play!");
                _unv.entities.Remove(removeEntityId);
            }
        }

        public Universe GetUniverse() => _unv;
    }
}