using SoftUniWarz.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SoftUniWarz.Attack;

namespace SoftUniWarz
{
    public abstract class Character : GameObject, IAttackAppliable, IAttackable, IDestructable, IConsumable
    {
        private  string name;
        //private string nameValidation;
        private  int healthPoints;
        private  int manaPoints;

        public Character(string name, int healthPoints, int manaPoints)
            //TODO: implement the base ctor of the game object
            //:base()
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
