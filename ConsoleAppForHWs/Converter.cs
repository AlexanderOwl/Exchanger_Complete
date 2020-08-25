using System;
using System.Collections.Generic;
using System.Text;

namespace Exchanger
{
    class Converter
    {
        public double ConvertionToDollar(double SumToConvert, double rate)
        {
            double inDollars = SumToConvert * rate;
            return inDollars;
        }

        public double DollarConvertion(double sumInDollars, double rate)
        {
            double convertedSum = sumInDollars / rate;
            return convertedSum;
        }
    }
}
