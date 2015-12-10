using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniWarz
{
    class Enemy : Character //, IProjectile(IMagic)
    {
        // Тези характеристики може да ги определим и при Players, както и интерфейса за магийки IProjectile(IMagic) and so on..
        // Можем да отделим проверките при сетърите в отделен клас (e.g. Validations) и да ги преизползваме.
        // Относно двата метода: ProduceToAttack и RespondToAttack са предложение за логиката на играта за атакуване и т.н. 
        private string name;
        private int health;
        private int damage;
        //private IList<Items> items;
        //private IList<Spells> spells;

        public Enemy(string name, int health, int damage)
            
        {
            this.Name = name;
            this.Health = health;
            this.Damage = damage;
            //this.Items = new List<Items>();
            //this.Spells = new List<Spells>();
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Enemy's name cannot be null or whitespace!");
                }

                this.name = value;
            }
        }

        public int Health
        {
            get { return this.health; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Enemy's health cannot be set negative or 0!");
                }

                this.health = value;
            }
        }

        public int Damage
        {
            get { return this.health; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Enemy's health cannot be set negative or 0!");
                }

                this.health = value;
            }
        }

        //public IEnumerable<Items> Items { get { return this.items; } }
        //public IEnumerable<Spells> Spelss { get { return this.spells; } }

        //public override IProjectile ProduceAttack(); // from IAttackable
        //{
        //    int countOfMagics = this.spells.Count;
        //    Random rnd = new Random();
        //    int randomInt = rnd.Next(countOfMagics);

        //    switch (randomInt)
        // {
        //        case 0:
        //        return new this.spells[randomInt];
        //        case 1:
        //        return new this.spells[randomInt];
        //        case 2:
        //        return new this.spells[randomInt];
        //        case 3:
        //        return new this.spells[randomInt];
        //  default:
        //        return new ArgumentOutOfRangeException("Spell not recognised!");
        //        break;
        //    }
        //}

        //public void RespondToAttack(IProjectile attack)
        //{
        //    attack.Hit();
        //}

        //public void AddSpell(Spell spell)
        //{
        //    this.spells.Add(spell);
        //}

        //public void AddItem(Item item)
        //{
        //    this.items.Add(item);
        //}
    }
}
