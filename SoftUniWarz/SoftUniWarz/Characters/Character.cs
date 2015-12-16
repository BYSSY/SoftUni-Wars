namespace SoftUniWarz
{
    using Interfaces;
    using System;
    using Microsoft.Xna.Framework;
    using Validation;
    using System.Collections.Generic;

    public abstract class Character : GameObject, IDestroyable, IAttackable
    {
        private string name;
        private string nameValidation;
        private int healthPoints;
        private int manaPoints;
        private const int DefaultMaxHealth = 800;
        private const int DefaultMaxMana = 500;
        private IList<Bonus> inventory;

        public Character(string name, int healthPoints, int manaPoints,string texturePath,Vector2 position,int width,int height)
            : base(texturePath,position,width,height)
        {
            this.Name = name;
            this.HealthPoints = healthPoints;
            this.ManaPoints = manaPoints;
            this.inventory = new List<Bonus>();
        }


        public int HealthPoints
        {
            get { return this.healthPoints; }
            private set
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

        public IEnumerable<Bonus> Inventory{ get; }

        public virtual void ApplyAttack(Attack.Attack attack)
        {
            this.healthPoints -= attack.DamageTake;
            this.manaPoints -= attack.ManaTake;
        }

        public virtual void ApplyBonus(Bonus bonus)
        {
            this.HealthPoints += bonus.HealthBoost;
            this.ManaPoints += bonus.ManaBoost;
        }

        public IAttack ProduceAttack()
        {
            throw new NotImplementedException();
        }

        public void RespondToAttack(IAttack attack)
        {
            throw new NotImplementedException();
        }

        public void AddBonusToInventory(Bonus bonusToAdd)
        {
            ValidateData.CheckIsNull(bonusToAdd,nameof(Bonus));
            this.inventory.Add(bonusToAdd);
        }
    }
    
}
