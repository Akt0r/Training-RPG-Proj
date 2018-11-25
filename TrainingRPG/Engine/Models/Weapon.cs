namespace Engine.Models
{
    public class Weapon : GameItem
    {
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }

        public Weapon(int itemTypeId, string name, int price, int minDamage, int maxDamage) : base(itemTypeId, name, price)
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
        }

        public override GameItem Clone()
        {
            var clone = (Weapon)base.Clone();
            clone.MinDamage = MinDamage;
            clone.MaxDamage = MaxDamage;
            return clone;
        }
    }
}
