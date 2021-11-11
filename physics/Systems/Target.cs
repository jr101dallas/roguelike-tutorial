using System;
using Physics.Components;
using Physics.Interfaces;

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
            if (!HasDefense(targetEntity, out var defenseComponent)) return;
            if (!HasOffense(originEntity, out var offenseComponent)) return;

            int aimMods = 0;
            if (originEntity.components.TryGetValue(ComponentType.Inventory, out var inventoryIComponent))
            {
                aimMods = GetAimModifiers(inventoryIComponent);
            }

            var aimModifier = offenseComponent.BaseAim;
            var num = _rand.Next(100);
            if (num + aimModifier + aimMods > 50)
            {
                var removeEntityId = targetEntity.Id;
                Console.WriteLine($"Entity {removeEntityId.ToString()} has been removed from play!");

                defenseComponent.CurrentHealth -= offenseComponent.BaseDamage;
                if(defenseComponent.CurrentHealth <= 0)
                    _unv.entities.Remove(removeEntityId);
            }
        }

        public Universe GetUniverse() => _unv;

        public int GetAimModifiers(IComponent inventoryIComponent)
        {
            if (typeof(Inventory) != inventoryIComponent.GetType()) return 0;

            int aimMods = 0;
            var inv = (Inventory)inventoryIComponent;

            foreach(IItem item in inv.items.Values)
            {
                if (item is IOffenseMods)
                {
                    var modItem = (IOffenseMods)item;
                    aimMods += modItem.GetOffenseModifiers();
                }
            }

            return aimMods;
        }

        public bool HasDefense(Entity target, out Defense defCom)
        {
            bool foundDefense = HasComponent(target, ComponentType.Defense, out var defICom);
            defCom = (Defense)defICom;
            return foundDefense;
        }

        public bool HasOffense(Entity origin, out Offense offCom)
        {
            bool foundOffense = HasComponent(origin, ComponentType.Offense, out var offICom);
            offCom = (Offense)offICom;
            return foundOffense;
        }

        public bool HasComponent(Entity entity, ComponentType type, out IComponent component)
        {
            return entity.components.TryGetValue(type, out component);;
        }
    }
}