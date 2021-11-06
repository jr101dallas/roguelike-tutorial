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
            if (!originEntity.components.TryGetValue("Aim", out var aimIComponent)) return;

            int aimMods = 0;
            if (originEntity.components.TryGetValue("Inventory", out var inventoryIComponent))
            {
                aimMods = GetAimModifiers(inventoryIComponent);
            }

            var aimComponent = (Aim)aimIComponent;
            var aimModifier = aimComponent.BaseAim;
            var num = _rand.Next(100);
            if (num + aimModifier + aimMods > 50)
            {
                var removeEntityId = targetEntity.Id;
                Console.WriteLine($"Entity {removeEntityId.ToString()} has been removed from play!");
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
                if (item is IAimMods)
                {
                    var modItem = (IAimMods)item;
                    aimMods += modItem.GetAimModifiers();
                }
            }

            return aimMods;
        }
    }
}