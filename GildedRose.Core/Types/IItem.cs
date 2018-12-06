using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRose.Core.Types
{
    public interface IItem
    {
        Item Item { get; set; }
        void UpdateItem();
    }
}
