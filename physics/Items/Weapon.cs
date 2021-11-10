using Physics.Interfaces;

namespace Physics.Items
{
    public class Weapon : IItem, IOffenseMods
    {
        private int BonusAim = 5;

        public int GetOffenseModifiers()
        {
            return BonusAim;
        }
    }
}