using System;
using Physics.Components;
using Physics.Interfaces;
using Physics.Models;

namespace Physics.Systems
{
    public class Target : ISystem
    {
        private Universe _unv;
        private Random _rand;

        public Target(Universe unv, Random rng)
        {
            _unv = unv;
            _rand = rng;
        }
        
        public void TargetEntity(Entity originEntity, Entity targetEntity)
        {
            if (!targetEntity.HasDefense(out var defenseComponent)) return;

            var offenseMods = GetEntityOffenseModifiers(originEntity);
            var num = _rand.Next(100);
            if (num + offenseMods.totalAim > 50)
            {
                defenseComponent.CurrentHealth -= offenseMods.totalDamage;
                if(defenseComponent.CurrentHealth <= 0)
                {
                    Console.WriteLine($"Entity {targetEntity.Id.ToString()} has been removed from play!");
                    _unv.entities.Remove(targetEntity.Id);
                }
            }
        }

        public Universe GetUniverse() => _unv;

        public OffenseMods GetEntityOffenseModifiers(Entity entity)
        {
            var offenseMods = GetOffenseModifiers(entity);
            offenseMods.Add(GetInventoryOffenseModifiers(entity));
            return offenseMods;
        }

        public OffenseMods GetOffenseModifiers(Entity entity)
        {
            var offenseMods = new OffenseMods();
            
            if (!entity.HasOffense(out var offenseComponent)) return offenseMods;

            offenseMods.Add(offenseComponent);

            return offenseMods;
        }

        public OffenseMods GetInventoryOffenseModifiers(Entity entity)
        {
            var offenseMods = new OffenseMods();

            if (entity.HasInventory(out var inventoryComponent))
            {
                foreach(IItem item in inventoryComponent.items.Values)
                {
                    offenseMods.Add(item);                    
                }
            }

            return offenseMods;
        }

        public OffenseMods GetItemOffenseModifiers(Inventory inv)
        {
            var offenseMods = new OffenseMods();
            foreach(IItem item in inv.items.Values)
            {
                offenseMods.Add(item);                    
            }

            return offenseMods;
        }
    }
}