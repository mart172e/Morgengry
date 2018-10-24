using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    class Book
    {
        private string itemId;
        private string title;
        private double price;

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
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        public Book(string item, string title, double price)
        {
            ItemId = item;
            Title = title;
            Price = price;
        }
        public Book(string item, string title) :
            this (item, title, 0.0)
        {
            //ItemId = item;
            //Title = title;
        }
        public Book(string item) :
            this (item, "no title")
        {
            //ItemId = item;
        }


    }
}
