using SoftUniWarz.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SoftUniWarz.Attack;

namespace SoftUniWarz
{
    public abstract class Character : GameObject, IAttackAppliable, IAttackable, ICharacter
    {
        private string name;
        //private string nameValidation;
        private  int healthPoints;
        private  int manaPoints;
        private static readonly int maxHealth=500;
        private static readonly int maxMana = 500;

        //private IEnumarable<Magic> spellPool; 
        //private IEnumarable<Bonus> inventory; 
        // May throw exception or not to compile.

        public Character(string name,
            int healthPoints,
            int manaPoints,
            string texturePath,
            Vector2 position,
            int width,
            int height)

            // TODO: implement the base ctor of the game object
            //:base()
            : base(texturePath,position,width,height)
        {
            this.Name = name;
            this.HealthPoints = healthPoints;
            this.ManaPoints = manaPoints;
            //IEnumarable<Magic> spellPool = new List<Magic>(); 
            //IEnumarable<Bonus> inventory = new List<Magic>(); 

        }

        //public string NameValidation
        //{
        //    get { return this.nameValidation; }
        //    set
        //    {
        //        if (string.IsNullOrWhiteSpace(value) || value.Length < 3)
        //        {
        //            throw new ArgumentException("Name must be more than 3 characters long!");
        //        }
        //        this.nameValidation = value;
        //    }
        //}

        public int HealthPoints
        {
            get { return this.healthPoints; }
            private set
            {
                if (value<0)
                {
                    throw  new ArgumentOutOfRangeException("HP cannot be negative!");
                }
                if (value > maxHealth)
                {
                    this.healthPoints = maxHealth;
                }
                this.healthPoints = value;
            }
        }

        public int ManaPoints
        {
            get { return this.manaPoints; }
            private set
            {
                if (value<0)
                {
                    throw new ArgumentOutOfRangeException("Mana cannot be negative!");
                }
                if (value>maxMana)
                {
                    this.ManaPoints = maxMana;
                }
                this.manaPoints = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            private set { this.name = value; }
        }

        //public IEnumerable<Magic> SpellPool { get { return this.spellPool; } }
        //public IEnumerable<Bonus> Inventory { get { return this.inventory; } }

        public void AddBonusToInventory(Bonus bonus)
        {
            //this.inventory.Add(bonus)
        }
        public void AddSpellToSpellPool() // TODO: add Magic spell here.
        {
            //this.spellPool.Add(spell)
        }

        public void ApplyAttack(Attack.Attack attack)
        {
            //TODO: Aplly effect of attack
        }

        public void ApplyBonus(Bonus bonus)
        {
            this.HealthPoints += bonus.HealthBoost;
            this.ManaPoints += bonus.ManaBoost;
        }
    }
    
}
