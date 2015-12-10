using SoftUniWarz.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniWarz
{
    public abstract class Character : GameObject, IAttackable, IDestructable, IConsumable
    {
        private readonly string name;
        //private string nameValidation;
        private  int healthPoints;
        private  int manaPoints;

        public Character(string name, int healthPoints, int manaPoints)
        {

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
        public int HealthPoints { get; private set; }
        public int ManaPoints { get; private set; }
    }
}
