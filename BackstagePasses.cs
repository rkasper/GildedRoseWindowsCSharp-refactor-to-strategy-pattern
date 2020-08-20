namespace csharp
{
    internal class BackstagePasses : Item
    { 
        private const int ConcertDateIsClose = 11;
        private const int ConcertDateIsReallyClose = 6;

       public override void Update()
        {
            if (SellIn <= 0)
            {
                Quality = MinQuality;
            }
            else if (SellIn < ConcertDateIsReallyClose)
            {
                Quality += 3;
            }
            else if (SellIn < ConcertDateIsClose)
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