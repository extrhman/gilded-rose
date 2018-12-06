using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRose.Core.Types
{
    public class ConjuredItem : IItem
    {
        public Item Item { get; set; }
        public ConjuredItem(Item item)
        {
            this.Item = item;
        }

        public void UpdateItem()
        {
            UpdateQuality();
            UpdateSellin();
        }

        private void UpdateQuality()
        {
            if (this.Item.Quality > 0 && this.Item.SellIn > 0)
                this.Item.Quality -= 2;
            else if (this.Item.Quality > 0 && this.Item.SellIn == 0)
                this.Item.Quality -= 4;

            if (this.Item.Quality < 0)
                this.Item.Quality = 0;
        }

        private void UpdateSellin()
        {
            if (this.Item.SellIn > 0)
                this.Item.SellIn -= 1;
        }
    }
}
