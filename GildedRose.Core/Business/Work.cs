using GildedRose.Core.Types;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GildedRose.Core.Business
{
    public class Work
    {
        public void UpdateInventory(IList<Item> Items)
        {
            Parallel.ForEach(Items, (x) => ItemFactory.GetCustomItem(x).UpdateItem());
        }
    }
}
