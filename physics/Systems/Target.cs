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

            (int aimBonus, int damageBonus) offenseMods = (0, 0);
            if (HasInventory(originEntity, out var inventoryComponent))
            {
                offenseMods = GetItemModifiers(inventoryComponent);
            }

            var aimModifier = offenseComponent.BaseAim;
            var num = _rand.Next(100);
            if (num + aimModifier + offenseMods.aimBonus > 50)
            {
                var removeEntityId = targetEntity.Id;
                Console.WriteLine($"Entity {removeEntityId.ToString()} has been removed from play!");

                defenseComponent.CurrentHealth -= offenseComponent.BaseDamage + offenseMods.damageBonus;
                if(defenseComponent.CurrentHealth <= 0)
                    _unv.entities.Remove(removeEntityId);
            }
        }

        public Universe GetUniverse() => _unv;

        public (int aimBonus, int damageBonus) GetItemModifiers(Inventory inventoryComponent)
        {
            (int aimBonus, int damageBonus) offenseMods = (0, 0);

            foreach(IItem item in inventoryComponent.items.Values)
            {
                if (item is IOffenseMods)
                {
                    var modItem = (IOffenseMods)item;
                    var mods = modItem.GetOffenseModifiers();
                    offenseMods.aimBonus += mods.aimBonus;
                    offenseMods.damageBonus += mods.damageBonus;                    
                }
            }

            return offenseMods;
        }

        public bool HasDefense(Entity target, out Defense defCom)
        {
            bool foundDefense = HasComponent(target, ComponentType.Defense, out var defICom);
            defCom = (Defense)defICom;
            return foundDefense;
        }

        public bool HasInventory(Entity origin, out Inventory offCom)
        {
            bool foundInventory = HasComponent(origin, ComponentType.Inventory, out var invICom);
            offCom = (Inventory)invICom;
            return foundInventory;
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