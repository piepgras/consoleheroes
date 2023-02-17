using System.Runtime.Serialization;

namespace ConsoleHeroes.Game.Exceptions
{
    /// <summary>
    /// Exception used for when hero tries to equip
    /// an invalid armor.
    /// </summary>
    [Serializable]
    internal class InvalidArmorException : Exception
    {
        public InvalidArmorException()
        {
        }

        public InvalidArmorException(string? message) : base(message)
        {
        }
    }
}