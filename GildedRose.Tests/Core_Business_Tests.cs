using GildedRose.Core.Business;
using GildedRose.Core.Types;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace GildedRose.Tests
{
    [TestClass]
    public class Core_Business_Tests
    {
        [TestMethod]
        public void Quality_decreases_twice_as_fast_after_sell_in_equals_zero()
        {
            var items = new List<Item>()
            {
                new Item("Test Item", 0, 10)
            };

            var ruleset = new Work();
            ruleset.UpdateInventory(items);

            Assert.IsTrue(items[0].Quality == 8);
        }

        [TestMethod]
        public void Quality_never_goes_negative_if_sellin_greater_than_zero()
        {
            var items = new List<Item>()
            {
                new Item("Test Item", 1, 0)
            };

            var ruleset = new Work();
            ruleset.UpdateInventory(items);

            Assert.IsTrue(items[0].Quality == 0);
        }

        [TestMethod]
        public void Quality_never_goes_negative_if_sellin_equals_zero()
        {
            var items = new List<Item>()
            {
                new Item("Test Item", 0, 1)
            };

            var ruleset = new Work();
            ruleset.UpdateInventory(items);

            Assert.IsTrue(items[0].Quality == 0);
        }

        [TestMethod]
        public void Quality_increases_by_age_for_aged_item()
        {
            var items = new List<Item>()
            {
                new Item("Aged Brie", 2, 0)
            };

            var ruleset = new Work();
            ruleset.UpdateInventory(items);

            Assert.IsTrue(items[0].Quality == 1);
        }

        [TestMethod]
        public void Quality_never_goes_over_50()
        {
            var items = new List<Item>()
            {
                new Item("Aged Brie", 20, 50)
            };

            var ruleset = new Work();
            ruleset.UpdateInventory(items);

            Assert.IsTrue(items[0].Quality == 50);
        }

        [TestMethod]
        public void Legendary_item_never_reduces_quality_or_expires()
        {
            var items = new List<Item>()
            {
                new Item("Sulfuras, Hand of Ragnaros", 0, 80)
            };

            var ruleset = new Work();
            ruleset.UpdateInventory(items);

            Assert.IsTrue(items[0].Quality == 80);
            Assert.IsTrue(items[0].SellIn == 0);
        }

        [TestMethod]
        public void Quality_increase_by_age_for_passes()
        {
            var items = new List<Item>()
            {
                new Item("Backstage passes to a TAFKAL80ETC concert", 20, 0)
            };

            var ruleset = new Work();
            ruleset.UpdateInventory(items);

            Assert.IsTrue(items[0].Quality == 1);
        }

        [TestMethod]
        public void Quality_increase_by_2_by_age_for_passes_when_sellin_less_then_or_equal_to_10()
        {
            var items = new List<Item>()
            {
                new Item("Backstage passes to a TAFKAL80ETC concert", 10, 0)
            };

            var ruleset = new Work();
            ruleset.UpdateInventory(items);

            Assert.IsTrue(items[0].Quality == 2);
        }

        [TestMethod]
        public void Quality_increase_by_3_by_age_for_passes_when_sellin_less_then_or_equal_to_5()
        {
            var items = new List<Item>()
            {
                new Item("Backstage passes to a TAFKAL80ETC concert", 5, 0)
            };

            var ruleset = new Work();
            ruleset.UpdateInventory(items);

            Assert.IsTrue(items[0].Quality == 3);
        }

        [TestMethod]
        public void Quality_goes_to_zero_for_passes_when_sellin_equals_0()
        {
            var items = new List<Item>()
            {
                new Item("Backstage passes to a TAFKAL80ETC concert", 0, 10)
            };

            var ruleset = new Work();
            ruleset.UpdateInventory(items);

            Assert.IsTrue(items[0].Quality == 0);
        }
    }
}
