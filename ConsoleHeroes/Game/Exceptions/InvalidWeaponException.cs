using System.Runtime.Serialization;

namespace ConsoleHeroes.Game.Exceptions
{
    /// <summary>
    /// Exception used for when hero tries to equip
    /// an invalid weapon.
    /// </summary>
    [Serializable]
    internal class InvalidWeaponException : Exception
    {
        public InvalidWeaponException()
        {
        }

        public InvalidWeaponException(string? message) : base(message)
        {
        }
    }
}