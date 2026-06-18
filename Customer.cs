using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcomShopApplication
{
    internal class Customer
    {
        private string name;
        private string cart;
        private int orders;

        public Customer(string name, string cart)
        {
            this.name = name;       
            this.cart = cart;
        }
    }
}
