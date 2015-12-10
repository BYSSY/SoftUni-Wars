using SoftUniWarz.Interfaces;

namespace SoftUniWarz
{
    public interface ICharacter : IBonusAppliable
    {
        int HealthPoints { get; }

        int ManaPoints { get; }

        string Name { get; }

        void AddBonusToInventory(Bonus bonus);

        void AddSpellToSpellPool();
    }
}