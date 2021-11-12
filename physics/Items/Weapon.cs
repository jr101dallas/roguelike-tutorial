using Physics.Interfaces;

namespace Physics.Items
{
    public class Weapon : IItem, IOffenseMods
    {
        private int BonusAim = 5;
        private int BonusDamage = 5;

        public (int aimBonus, int damageBonus) GetOffenseModifiers()
        {
            return (BonusAim, BonusDamage);
        }
    }
}