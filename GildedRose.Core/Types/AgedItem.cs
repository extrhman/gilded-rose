namespace GildedRose.Core.Types
{
    public class AgedItem : IItem
    {
        public Item Item { get; set; }
        public AgedItem(Item item)
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
            if (this.Item.Quality < 50)
                this.Item.Quality += 1;
        }

        private void UpdateSellin()
        {
            if (this.Item.SellIn > 0)
                this.Item.SellIn -= 1;
        }
    }
}
