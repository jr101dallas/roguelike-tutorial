using Physics.Interfaces;

namespace Physics.Items
{
    public class Weapon : IItem, IAimMods
    {
        private int BonusAim = 5;

        public int GetAimModifiers()
        {
            return BonusAim;
        }
    }
}