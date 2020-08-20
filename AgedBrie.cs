namespace csharp
{
    public class AgedBrie : Item
    {
        internal AgedBrie()
        {
        }

        public override void Update()
        {
            if (SellIn < 0)
            {
                Quality += 2;
            }
            else
            {
                Quality++;
            }

            EnsureMaxQuality();

            SellIn--;
        }
    }
}