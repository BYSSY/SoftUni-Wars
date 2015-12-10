using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniWarz.Attack
{
    public class Attack: GameObject
    {
        private int damageTake;
        private int manaTake;
        private int coffeeTake;
        private int beerTake;
        private int sandwichTake;
        private bool isParalizable;

        public Attack(int damageTake, int manaTake, int coffeeTake, int beerTake, int sandwichTake, bool isParalizable)
        {
            this.DamageTake = damageTake;
            this.ManaTake = manaTake;
            this.CoffeeTake = coffeeTake;
            this.BeerTake = beerTake;
            this.SandwichTake = sandwichTake;
            this.IsParalizable = isParalizable;
        }

        public bool IsParalizable
        {
            get
            {
                return isParalizable;
            }

            set
            {
                isParalizable = value;
            }
        }
        public int SandwichTake
        {
            get
            {
                return sandwichTake;
            }

            set
            {
                sandwichTake = value;
            }
        }
        public int BeerTake
        {
            get
            {
                return beerTake;
            }

            set
            {
                beerTake = value;
            }
        }
        public int CoffeeTake
        {
            get
            {
                return coffeeTake;
            }

            set
            {
                coffeeTake = value;
            }
        }
        public int ManaTake
        {
            get
            {
                return manaTake;
            }

            set
            {
                manaTake = value;
            }
        }
        public int DamageTake
        {
            get
            {
                return damageTake;
            }

            set
            {
                damageTake = value;
            }
        }
    }
}
