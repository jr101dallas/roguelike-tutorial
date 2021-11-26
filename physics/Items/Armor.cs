using Physics.Interfaces;
using Physics.Models;

namespace Physics.Items
{
    public class Armor : IItem, IDefenseMods
    {
        private int BonusAblation = 8;
        private int BonusArmor = 8;

        public DefenseMods GetDefenseModifiers()
        {
            return new DefenseMods()
            {
                totalAblation = BonusAblation,
                totalArmor = BonusArmor
            };
        }
    }
}