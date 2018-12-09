using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class ItemQuantity
    {
        public readonly int ItemId;
        public readonly int Quantity;

        public ItemQuantity(int itemId, int quantity)
        {
            if (quantity < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(quantity), "Must be greater then zero");
            }
            ItemId = itemId;
            Quantity = quantity;
        }
    }
}
