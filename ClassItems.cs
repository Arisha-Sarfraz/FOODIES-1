using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ooad
{
    class ClassItems
    {
        private string itemname;
        private string category;
        private double price;

        public string Itemname
        {
            get
            {
                return itemname;
            }

            set
            {
                itemname = value;
            }
        }

        public string Category
        {
            get
            {
                return category;
            }

            set
            {
                category = value;
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
    }
}
