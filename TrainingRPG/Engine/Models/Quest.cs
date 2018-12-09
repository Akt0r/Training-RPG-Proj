using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Quest
    {
        public readonly int ID;
        public readonly string Name;
        public readonly string Description;

        public readonly List<ItemQuantity> ItemsToComplete;

        public readonly int RewardExperiencePoints;
        public readonly int RewardGold;

        public readonly List<ItemQuantity> RewardItems;

        public Quest(int id, string name, string description, List<ItemQuantity> itemsToCopmplete,
            int rewardExp, int rewardGold, List<ItemQuantity> rewardItems)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException(nameof(name));
            }
            if (string.IsNullOrEmpty(description))
            {
                throw new ArgumentException(nameof(description));
            }
            if (itemsToCopmplete == null)
            {
                throw new ArgumentNullException(nameof(itemsToCopmplete));
            }
            if (rewardExp < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(rewardExp), "Must be non-negative");
            }
            if (rewardGold < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(rewardGold), "Must be non-negative");
            }
            if (rewardItems == null)
            {
                throw new ArgumentNullException(nameof(rewardItems));
            }

            ID = id;
            Name = name;
            Description = description;
            ItemsToComplete = itemsToCopmplete;
            RewardExperiencePoints = rewardExp;
            RewardGold = rewardGold;
            RewardItems = rewardItems;
        }
    }
}
