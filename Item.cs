namespace csharp
{
    public class Item
    {
        protected const int MinQuality = 0;
        private const int MaxQuality = 50;

        internal Item()
        {
        }

        public static Item NormalItem(string name, int sellin, int quality)
        {
            return new Item {Name = name, SellIn = sellin, Quality = quality};
        }

        public static AgedBrie AgedBrie(string name, int sellin, int quality)
        {
            return new AgedBrie { Name = name, SellIn = sellin, Quality = quality };
        }

        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        public override string ToString()
        {
            return this.Name + ", " + this.SellIn + ", " + this.Quality;
        }

        public virtual void Update()
        {
            if (SellIn <= 0)
            {
                Quality -= 2;
            }
            else
            {
                Quality--;
            }

            SellIn--;
        }

        protected void EnsureMaxQuality()
        {
            if (Quality > Item.MaxQuality)
            {
                Quality = Item.MaxQuality;
            }
        }
    }
}
