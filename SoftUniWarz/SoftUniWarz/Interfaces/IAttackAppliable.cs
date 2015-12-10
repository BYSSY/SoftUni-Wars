using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SoftUniWarz.Attack;
namespace SoftUniWarz.Interfaces
{
    interface IAttackAppliable
    {
        void ApplyAttack(Attack.Attack attack);
    }
}
