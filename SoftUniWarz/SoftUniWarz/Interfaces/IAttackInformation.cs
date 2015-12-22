namespace SoftUniWarz.Interfaces
{
    using Microsoft.Xna.Framework;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public interface IAttackInformation
    {
        int Damage { get; }

        int ManaCost { get; }

        Vector2 DamagePosition { get; }

        Vector2 ManaCostPosition { get; }

        void AddDamageInformation(int damage );

        void AddManaCostInformation(int manaCost);
    }
}
