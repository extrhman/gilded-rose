using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRose.Core.Types
{
    public class StandardItem : IItem
    {
        public Item Item { get; set; }
        public StandardItem(Item item)
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
                this.Item.Quality -= 1;
            else if (this.Item.Quality > 0 && this.Item.SellIn == 0)
                this.Item.Quality -= 2;

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
