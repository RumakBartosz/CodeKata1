using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata1.Kata1Classes
{
    public class Item
    {
        public Item() { }

        public Item(double price)
        {
            this.Price = price;
        }
        public double Price { get; set; }
        public void PercentPromotion(double promotionValue)
        {
            this.Price -=  (promotionValue/100) * this.Price;

        }

        public void MinusPromotion(double promotionValue)
        {
            this.Price -= promotionValue;
        }

    }
}
