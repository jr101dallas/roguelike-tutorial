using Physics.Interfaces;

namespace Physics.Components
{
    public class Offense : IComponent
    {
        public readonly int BaseAim;
        public readonly int BaseDamage;

        public Offense() : this(3, 5){}

        public Offense(int aim, int dmg)
        {
            BaseAim = aim;
            BaseDamage = dmg;
        }
    }
}