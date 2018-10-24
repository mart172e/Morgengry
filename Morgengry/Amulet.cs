using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
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
        private Level Quality
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
        

        public enum Level
        {
            low, medium, high
        }

        public Amulet(string item, Level quality, string design)
        {
            ItemId = item;
            Quality = quality;
            Design = design;
        }
        public Amulet(string item, Level quality) :
            this (item, quality, "Not supplied")
        {
            //itemId = Item;
            //quality = Quality;
        }
        public Amulet(string item) :
            this(item, Level.medium)
        {
            //itemId = Item;
        }



    }
}
