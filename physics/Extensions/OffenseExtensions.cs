using Physics.Components;
using Physics.Models;

namespace Physics
{
    public static class OffenseExtensions
    {
        public static OffenseMods ToOffenseMods(this Offense offense)
        {            
            return new OffenseMods()
            {
                totalAim = offense.BaseAim,
                totalDamage = offense.BaseDamage
            };
        }
    }
}