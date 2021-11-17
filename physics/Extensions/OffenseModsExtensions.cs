using Physics.Components;
using Physics.Interfaces;
using Physics.Models;

namespace Physics
{
    public static class OffenseModsExtensions
    {
        public static void Add(this OffenseMods addend1, OffenseMods addend2)
        {
            addend1.totalAim += addend2.totalAim;
            addend1.totalDamage += addend2.totalDamage;   
        }

        public static void Add(this OffenseMods addend1, IItem addend2)
        {
            if (addend2 is IOffenseMods)
            {
                var modItem = (IOffenseMods)addend2;
                var mods = modItem.GetOffenseModifiers();
                addend1.Add(mods);                    
            }
        }

        public static void Add(this OffenseMods addend1, Offense addend2)
        {
            addend1.Add(addend2.ToOffenseMods());
        }
    }
}