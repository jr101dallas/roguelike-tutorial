using System;
using Physics.Components;
using Physics.Interfaces;
using Physics.Models;

namespace Physics.Systems
{
    public class Collision : ISystem
    {
        private Universe _unv;

        public Collision(Universe unv)
        {
            _unv = unv;
        }
        
        public Universe GetUniverse() => _unv;

        public void ResolveCollision(OffenseMods off, Entity def)
        {
            if (!def.HasDefense(out var defenseComponent)) return;
            
            if (off.rngValue + off.totalAim > 50)
            {
                defenseComponent.CurrentHealth -= off.totalDamage;
                if(defenseComponent.CurrentHealth <= 0)
                {
                    Console.WriteLine($"Entity {def.Id.ToString()} has been removed from play!");
                    _unv.entities.Remove(def.Id);
                }
            }
        }
    }
}