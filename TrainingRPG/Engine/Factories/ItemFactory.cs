using Engine.Models;
using System.Collections.Generic;

namespace Engine.Factories
{
    internal static class ItemFactory
    {
        private static Dictionary<int, GameItem> _standartGameItems;

        static ItemFactory()
        {
            _standartGameItems = new Dictionary<int, GameItem>
            {
                { 1001, new Weapon(1001, "Pointy Stick", 1, 1, 2) },
                { 1002, new Weapon(1002, "Rusty Sword", 5, 1, 3) },
                { 9001, new GameItem(9001, "Snake fang", 1)},
                { 9002, new GameItem(9002, "Snakeskin", 2) }
            };
        }

        public static GameItem CreateGameItem(int itemTypeId)
        {
            GameItem result;
            if (_standartGameItems.TryGetValue(itemTypeId, out result))
            {
                return result.Clone();
            }
            return null;
        }
    }
}
