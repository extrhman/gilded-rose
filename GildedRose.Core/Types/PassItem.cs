namespace GildedRose.Core.Types
{
    public class PassItem : IItem
    {
        public Item Item { get; set; }
        public PassItem(Item item)
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
            int adjustment = this.Item.SellIn <= 10 ? this.Item.SellIn <= 5 ? this.Item.SellIn == 0 ? -this.Item.Quality : 3 : 2 : 1;
            if (this.Item.Quality < 50 || this.Item.SellIn == 0)
                this.Item.Quality += adjustment;
        }

        private void UpdateSellin()
        {
            if (this.Item.SellIn > 0)
                this.Item.SellIn -= 1;
        }
    }
}
