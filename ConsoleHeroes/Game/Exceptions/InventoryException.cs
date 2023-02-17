using System.Runtime.Serialization;

namespace ConsoleHeroes.Game.Equipment.Exceptions
{
    /// <summary>
    /// Exception used for when inventory is negative on init
    /// or when trying to insert item into full backpack.
    /// </summary>
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