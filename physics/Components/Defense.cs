using Physics.Interfaces;

namespace Physics.Components
{
    public class Defense : IComponent
    {
        public readonly int BaseHealth = 50;
        public readonly int BaseArmor = 6;
        
        public int CurrentHealth;

        public Defense()
        {
            CurrentHealth = BaseHealth;
        }
    }
}