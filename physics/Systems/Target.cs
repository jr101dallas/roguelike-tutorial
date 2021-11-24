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
        
        public Universe GetUniverse() => _unv;

        public void TargetEntity(Entity originEntity, Entity targetEntity)
        {
            var num = _rand.Next(100);
            var offenseMods = new OffenseMods(num);
            offenseMods.Add(GetEntityOffenseModifiers(originEntity));
            
            _unv.inf.collision.ResolveCollision(offenseMods, targetEntity);
        }

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