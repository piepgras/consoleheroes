using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// The Character Interface ICharacter defines all abstract
// base functionality for all characters in the game:
// heroes & foes.
namespace ConsoleHeroes.Game.Abstracts.Interfaces
{
    internal interface ICharacter
    {
        // Necessary
        protected abstract double Attack();
        protected abstract double Defend(double incomingDamage);
        protected abstract void Die(string reason);


        // Fun
        protected abstract void DeathQuote();
    }
}
