using ConsoleHeroes.Game.Modifiers;
using ConsoleHeroes.Game.Output;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// The Base Character inherits all the
// abstract functionality from the Character Interface ICharacter.
// and also implements further abstract(and none abstract) functionality.
namespace ConsoleHeroes.Game.Abstracts
{
    internal abstract class CharacterBase : ICharacter
    {
        // Getters & Setters;
        public string Name { get; set; }
        public double Health { get; set; }
        public bool isAlive { get; set; } = true;
        public double MinimumDamage { get; set; }
        public double MaximumDamage { get; set; }
        public Experience Experience { get; set; } = new Experience();
        public Attributes Attributes { get; set; } = null!;
        public Attributes AttributesGain { get; set; } = null!;

        public double Defend(double incomingDamage)
        {
            double damageAfterMitigation = incomingDamage * 0.9;
            Health -= damageAfterMitigation;
            Narrator.TakeDamage(Name, damageAfterMitigation);
            if (Health <= 0)
            {
                isAlive = false;
            }
            return damageAfterMitigation;
        }

        // Abstracts from ICharacter:
        public double Attack(CharacterBase target, double damage)
        {
            Narrator.DealDamage(Name, target, damage);
            return damage;
        }
        //public abstract double Defend(double incomingDamage);
        public abstract void Die(string reason);
        public abstract void DeathQuote();

    }
}
