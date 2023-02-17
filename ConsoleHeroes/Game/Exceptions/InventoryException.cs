using System.Runtime.Serialization;

namespace ConsoleHeroes.Game.Equipment.Exceptions
{
    [Serializable]
    internal class InventoryException : Exception
    {
        public InventoryException()
        {
        }

        public InventoryException(string? message) : base(message)
        {
        }
    }
}