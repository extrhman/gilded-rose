namespace GildedRose.Core.Types
{
    public static class ItemFactory
    {
        public static IItem GetCustomItem(Item item)
        {
            IItem _item = new StandardItem(item);
            switch (item.Name)
            {
                case "Aged Brie":
                    _item = new AgedItem(item);
                    break;
                case "Sulfuras, Hand of Ragnaros":
                    _item = new LegendaryItem(item);
                    break;
                case "Backstage passes to a TAFKAL80ETC concert":
                    _item = new PassItem(item);
                    break;
                case "Conjured Mana Cake":
                    _item = new ConjuredItem(item);
                    break;
                default:
                    break;
            }

            return _item;
        }
    }
}
