using System.Runtime.Serialization;

namespace ConsoleHeroes.Game.Exceptions
{
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