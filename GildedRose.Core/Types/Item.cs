using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRose.Core.Types
{
    public class Item
    {
        public string Name { get; set; }

        public int SellIn { get; set; }

        public int Quality { get; set; }

        public Item(string name, int sellin, int quality)
        {
            this.Name = name;
            this.SellIn = sellin;
            this.Quality = quality;
        }

        public string toString()
        {
            return this.Name + ", " + this.SellIn + ", " + this.Quality;
        }
    }
}
