using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public enum Level
    {
        low, medium, high
    }
    public class Amulet
    {
        private string itemId;
        private string design;
        private Level quality;

        public string ItemId
        {
            get
            {
                return itemId;
            }
            set
            {
                itemId = value;
            }
        }
        public string Design
        {
            get
            {
                return design;
            }
            set
            {
                design = value;
            }
        }
        public Level Quality
        {
            get
            {
                return quality;
            }
            set
            {
                quality = value;
            }
        }


        public Amulet(string itemId, Level quality, string design)
        {
            ItemId = itemId;
            Quality = quality;
            Design = design;
        }
        public Amulet(string itemId, Level quality) :
            this (itemId, quality, "")
        {
            //itemId = Item;
            //quality = Quality;
        }
        public Amulet(string itemId) :
            this(itemId, Level.medium)
        {
            //itemId = Item;
        }

        public override string ToString()
        {
            return "ItemId: " + itemId + ", Quality: " + quality + ", Design: " + design;
        }


    }
}
