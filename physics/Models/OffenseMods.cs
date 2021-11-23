namespace Physics.Models
{
    public class OffenseMods
    {
        public readonly int rngValue;
        public int totalAim;
        public int totalDamage;

        public OffenseMods(){}
        public OffenseMods(int roll)
        {
            rngValue = roll;
        }
    }
}