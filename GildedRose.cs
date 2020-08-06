using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        private const string AgedBrie = "Aged Brie";
        private const string BackstagePasses = "Backstage passes to a TAFKAL80ETC concert";
        private const string Sulfuras = "Sulfuras, Hand of Ragnaros";
        private const int MinQuality = 0;
        private const int MaxQuality = 50;
        private const int ConcertDateIsClose = 11;
        private const int ConcertDateIsReallyClose = 6;

        IList<Item> Items;

        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                if (item.Name == AgedBrie)
                {
                    if (item.SellIn < 0)
                    {
                        item.Quality += 2;
                    }
                    else
                    {
                        item.Quality++;
                    }
                    EnsureMaxQuality(item);

                    item.SellIn--;
                }
                else if (item.Name == BackstagePasses)
                {
                    if (item.SellIn <= 0)
                    {
                        item.Quality = MinQuality;
                    }
                    else if (item.SellIn < ConcertDateIsReallyClose)
                    {
                        item.Quality += 3;
                    }
                    else if (item.SellIn < ConcertDateIsClose)
                    {
                        item.Quality += 2;
                    }
                    else
                    {
                        item.Quality++;
                    }
                    EnsureMaxQuality(item);

                    item.SellIn--;
                }
                else if (item.Name == Sulfuras)
                {
                    // Do nothing
                }
                else // It's a normal item
                {
                    if (item.SellIn <= 0)
                    {
                        item.Quality -= 2;
                    }
                    else
                    {
                        item.Quality--;
                    }

                    item.SellIn--;
                }
            }
        }

        private static void EnsureMaxQuality(Item item)
        {
            if (item.Quality > MaxQuality)
            {
                item.Quality = MaxQuality;
            }
        }
    }
}