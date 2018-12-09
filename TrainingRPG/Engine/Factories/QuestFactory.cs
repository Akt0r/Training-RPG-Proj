using Engine.Models;
using System.Collections.Generic;

namespace Engine.Factories
{
    internal static class QuestFactory
    {
        private static readonly Dictionary<int, Quest> _quests;

        static QuestFactory()
        {
            // Create the quest
            _quests = new Dictionary<int, Quest>
            { {1, new Quest(id :              1,
                            name:             "Clear the herb garden",
                            description:      "Defeat the snakes in the Herbalist's garden",
                            itemsToCopmplete: new List<ItemQuantity>() { new ItemQuantity(9001, 5) },
                            rewardExp:        25,
                            rewardGold:       10,
                            rewardItems:      new List<ItemQuantity> { new ItemQuantity(1002, 1)})}
            };
        }

        internal static Quest GetQuestByID(int id)
        {
            Quest result;
            if (_quests.TryGetValue(id, out result))
            {
                return result;
            }
            return null;
        }
    }
}
