namespace GildedRose.Core.Types
{
    public class LegendaryItem : IItem
    {
        public Item Item { get; set; }
        public LegendaryItem(Item item)
        {
            this.Item = item;
        }

        public void UpdateItem()
        {
        }
    }
}
