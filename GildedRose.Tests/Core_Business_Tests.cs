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
                new Item { Name = "Test Item", Quality = 10, SellIn = 0}
            };

            var ruleset = new Rules();
            ruleset.UpdateQuality(items);

            Assert.IsTrue(items[0].Quality == 8);
        }

        [TestMethod]
        public void Quality_never_goes_negative_if_sellin_greater_than_zero()
        {
            var items = new List<Item>()
            {
                new Item { Name = "Test Item", Quality = 0, SellIn = 1}
            };

            var ruleset = new Rules();
            ruleset.UpdateQuality(items);

            Assert.IsTrue(items[0].Quality == 0);
        }

        [TestMethod]
        public void Quality_never_goes_negative_if_sellin_equals_zero()
        {
            var items = new List<Item>()
            {
                new Item { Name = "Test Item", Quality = 1, SellIn = 0}
            };

            var ruleset = new Rules();
            ruleset.UpdateQuality(items);

            Assert.IsTrue(items[0].Quality == 0);
        }

        [TestMethod]
        public void Quality_increases_by_age_for_aged_brie()
        {
            var items = new List<Item>()
            {
                new Item { Name = "Aged Brie", Quality = 0, SellIn = 2}
            };

            var ruleset = new Rules();
            ruleset.UpdateQuality(items);

            Assert.IsTrue(items[0].Quality == 1);
        }

        [TestMethod]
        public void Quality_never_goes_over_50()
        {
            var items = new List<Item>()
            {
                new Item { Name = "Aged Brie", Quality = 50, SellIn = 20}
            };

            var ruleset = new Rules();
            ruleset.UpdateQuality(items);

            Assert.IsTrue(items[0].Quality == 50);
        }

        [TestMethod]
        public void Legendary_item_sulfuras_never_reduces_quality_or_expires()
        {
            var items = new List<Item>()
            {
                new Item { Name = "Sulfuras, Hand of Ragnaros", Quality = 80, SellIn = 0}
            };

            var ruleset = new Rules();
            ruleset.UpdateQuality(items);

            Assert.IsTrue(items[0].Quality == 80);
            Assert.IsTrue(items[0].SellIn == 0);
        }

        [TestMethod]
        public void Quality_increase_by_age_for_backstage_passes()
        {
            var items = new List<Item>()
            {
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 0, SellIn = 20}
            };

            var ruleset = new Rules();
            ruleset.UpdateQuality(items);

            Assert.IsTrue(items[0].Quality == 1);
        }

        [TestMethod]
        public void Quality_increase_by_2_by_age_for_backstage_passes_when_sellin_less_then_or_equal_to_10()
        {
            var items = new List<Item>()
            {
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 0, SellIn = 10}
            };

            var ruleset = new Rules();
            ruleset.UpdateQuality(items);

            Assert.IsTrue(items[0].Quality == 2);
        }

        [TestMethod]
        public void Quality_increase_by_3_by_age_for_backstage_passes_when_sellin_less_then_or_equal_to_5()
        {
            var items = new List<Item>()
            {
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 0, SellIn = 5}
            };

            var ruleset = new Rules();
            ruleset.UpdateQuality(items);

            Assert.IsTrue(items[0].Quality == 3);
        }

        [TestMethod]
        public void Quality_goes_to_zero_for_backstage_passes_when_sellin_equals_0()
        {
            var items = new List<Item>()
            {
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 10, SellIn = 0}
            };

            var ruleset = new Rules();
            ruleset.UpdateQuality(items);

            Assert.IsTrue(items[0].Quality == 0);
        }
    }
}
