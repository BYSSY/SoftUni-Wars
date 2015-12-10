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
    public abstract class Character : GameObject, IAttackAppliable, IAttackable
    {
        private string name;
        //private string nameValidation;
        private int healthPoints;
        private int manaPoints;

        public Character(string name, int healthPoints, int manaPoints,string texturePath,Vector2 position,int width,int height)
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
            private set { this.healthPoints = value; }
        }

        public int ManaPoints
        {
            get { return this.manaPoints; }
            private set { this.manaPoints = value; }
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
    }
    
}
