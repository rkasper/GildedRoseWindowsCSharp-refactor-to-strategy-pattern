using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        IList<Item> Items;

        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void Update()
        {
            // TODO: I want to replace this with a closure...
            foreach (var item in Items)
            {
                item.Update();
            }
        }
    }
}