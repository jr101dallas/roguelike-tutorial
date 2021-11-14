using Physics.Interfaces;
using Physics.Models;

namespace Physics.Items
{
    public class Weapon : IItem, IOffenseMods
    {
        private int BonusAim = 5;
        private int BonusDamage = 5;

        public OffenseMods GetOffenseModifiers()
        {
            return new OffenseMods()
            {
                totalAim = BonusAim,
                totalDamage = BonusDamage
            };
        }
    }
}