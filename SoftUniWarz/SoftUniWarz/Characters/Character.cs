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
<<<<<<< HEAD
    public abstract class Character : GameObject,IBonusAppliable, IAttackAppliable, IAttackable, IDestructable, IConsumable
=======
    public abstract class Character : GameObject, IAttackAppliable, IAttackable
>>>>>>> febc18d86f38e2d09970638aaef45910015a3c72
    {
        private string name;
        //private string nameValidation;
<<<<<<< HEAD
        private  int healthPoints;
        private  int manaPoints;
        private static readonly int maxHealth=500;
        private static readonly int maxMana = 500;
        public Character(string name, int healthPoints, int manaPoints,Texture2D texture,Vector2 position,int width,int height,bool isVisible , bool isActive)
=======
        private int healthPoints;
        private int manaPoints;

        public Character(string name, int healthPoints, int manaPoints,string texturePath,Vector2 position,int width,int height)
>>>>>>> febc18d86f38e2d09970638aaef45910015a3c72
            //TODO: implement the base ctor of the game object
            //:base()
            : base(texturePath,position,width,height)
        {
            this.Name = name;
            this.HealthPoints = healthPoints;
            this.ManaPoints = manaPoints;
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
                if (value>maxHealth)
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
