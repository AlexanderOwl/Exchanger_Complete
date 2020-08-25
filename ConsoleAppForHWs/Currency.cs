using System;
using System.Collections.Generic;
using System.Text;

namespace Exchanger
{
    class Currency
    {
        public string Name;
        public double ToDollarRate;

        public Currency(string Name, double ToDollarRate)
        {
            this.Name = Name;
            this.ToDollarRate = ToDollarRate;
        }
    }
}
