namespace SoftUniWarz
{
    using Interfaces;
    using System;
    using Microsoft.Xna.Framework;
    using Validation;
    using System.Collections.Generic;
    using Content;

    public abstract class Character : GameObject, IAttackable
    {
        private string name;
        private string nameValidation;
        private int healthPoints;
        private int manaPoints;
        private const int DefaultMaxHealth = 800;
        private const int DefaultMaxMana = 500;
        private List<Attack.Attack> spellPool;

        public Character(string name,
            int healthPoints,
            int manaPoints,
            string texturePath,
            Vector2 position)
            : base(
                  texturePath,
                  position,
                  -1,
                  -1)
        {
            this.Name = name;
            this.HealthPoints = healthPoints;
            this.ManaPoints = manaPoints;
            this.spellPool = new List<Attack.Attack>();
        }


        public int HealthPoints
        {
            get { return this.healthPoints; }
            set
            {
                ValidateData.ValidateNumber(0, DefaultMaxHealth, value, nameof(HealthPoints));
                this.healthPoints = value;
            }
        }

        public int ManaPoints
        {
            get { return this.manaPoints; }
            private set
            {
                ValidateData.ValidateNumber(0, DefaultMaxMana, value, nameof(ManaPoints));
                this.manaPoints = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                ValidateData.CheckIsNull(value, nameof(Name));
                this.name = value;
            }
        }

        public List<Attack.Attack> SpellPool { get { return this.spellPool; } }

        public virtual void ApplyAttack(Attack.Attack attack)
        {
            this.healthPoints -= attack.Damage;
            this.manaPoints -= attack.ManaCost;
        }

        public virtual void ApplyBonus(Bonus bonus)
        {
            this.HealthPoints += bonus.HealthBoost;
            if (this.HealthPoints > DefaultMaxHealth)
            {
                this.HealthPoints = DefaultMaxHealth;
            }

            this.ManaPoints += bonus.ManaBoost;
            if (this.ManaPoints > DefaultMaxMana)
            {
                this.ManaPoints = DefaultMaxMana;
            }
        }

        public void ProduceAttack(Attack.Attack attack)
        {
            spellPool.Add(attack);
        }

        public void AddSpellToInventory(Attack.Attack attack)
        {
            ValidateData.CheckIsNull(attack, nameof(Attack.Attack));
            this.spellPool.Add(attack);
        }
    }

}
