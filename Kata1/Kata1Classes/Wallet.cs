using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata1.Kata1Classes
{
    public class Wallet
    {
        public Wallet() { }
        public Wallet(double Content)
        {
            this.Content = Content;
        }

        public double Content { get; set; }

        public void Transaction(Item item)
        {
            if (item != null)
                this.Content -= item.Price;
            else
                throw new ArgumentNullException("item was nulled");
        }
    }
}
