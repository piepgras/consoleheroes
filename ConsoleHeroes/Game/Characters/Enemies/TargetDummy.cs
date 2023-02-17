using ConsoleHeroes.Game.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHeroes.Game.Characters
{
    internal class TargetDummy : Foe
    {
        public TargetDummy(string name) : base(name)
        {
            Health = 100;
        }
    }
}
