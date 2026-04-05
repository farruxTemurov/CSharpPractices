using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculatorApp
{
    internal class Product
    {
        public string name;
        public double amount;
        public double unitPrice;
        public double CalculateTotalPrice()
        {
            return amount * unitPrice;
        }

        public string ProductString()
        {
            return $"{name};{amount};{unitPrice};{CalculateTotalPrice()}";
        }
    }

}
