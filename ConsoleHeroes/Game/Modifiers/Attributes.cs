using ConsoleHeroes.Game.Output;

namespace ConsoleHeroes.Game.Modifiers
{
    internal class Attributes
    {
        private int _strength;
        private int _dexterity;
        private int _intelligence;

        public int Strength
        {
            get { return _strength; }
            set { _strength = value; }
        }
        public int Dexterity
        {
            get { return _dexterity; }
            set { _dexterity = value; }
        }
        public int Intelligence
        {
            get { return _intelligence; }
            set { _intelligence = value; }
        }

        public Attributes(int strength, int dexterity, int intelligence)
        {
            _strength = strength;
            _dexterity = dexterity;
            _intelligence = intelligence;

        }

        public static Attributes operator +(Attributes lhs, Attributes rhs)
        {
            return new Attributes(lhs.Strength + rhs.Strength,
                                   lhs.Dexterity + rhs.Dexterity,
                                   lhs.Intelligence + rhs.Intelligence);
        }

        public static Attributes operator -(Attributes lhs, Attributes rhs)
        {
            return new Attributes(lhs.Strength - rhs.Strength,
                                   lhs.Dexterity - rhs.Dexterity,
                                   lhs.Intelligence - rhs.Intelligence);
        }

        public override bool Equals(object? obj)
        {
            return obj is Attributes attributes &&
                   Strength == attributes.Strength &&
                   Dexterity == attributes.Dexterity &&
                   Intelligence == attributes.Intelligence;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Strength, Dexterity, Intelligence);
        }
    }
}
