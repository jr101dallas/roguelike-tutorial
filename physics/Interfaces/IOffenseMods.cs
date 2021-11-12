namespace Physics.Interfaces
{
    public interface IOffenseMods
    {
        public (int aimBonus, int damageBonus) GetOffenseModifiers();
    }
}