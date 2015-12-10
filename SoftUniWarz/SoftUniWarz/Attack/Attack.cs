using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

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

        public Attack(int damageTake, int manaTake, int coffeeTake, int beerTake, int sandwichTake, bool isParalizable,Texture2D texture,Vector2 position , int width , int height,bool isActive,bool isVisible)
            :base(texture,position,width,height,isActive,isVisible)
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
                if (value<0)
                {
                    throw new ArgumentOutOfRangeException("Sandwich HP update cannot negative");
                }
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
                if (value<0)
                {
                    throw new ArgumentOutOfRangeException("Beer cannot be negative");
                }
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
                if (value<0)
                {
                    throw new ArgumentOutOfRangeException("Coffee cannot be negative!");
                }
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
                if (value<0)
                {
                    throw new ArgumentOutOfRangeException("Mana cannot take less a negative number and over 150");
                }
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
                if (value<0)
                {
                    throw new ArgumentOutOfRangeException("Damage cannot be negative!");
                }
                damageTake = value;
            }
        }
    }
}
