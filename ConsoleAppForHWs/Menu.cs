using System;
using System.Collections.Generic;
using System.Text;

namespace Exchanger
{
    class Menu
    {
        public string AskCurrency(List<Currency> currencies, string act)
        {
            int input, count = 1;
            string currency = "";           
           
                Console.WriteLine($"Convert {act}");
                foreach (var item in currencies)
                {
                    Console.WriteLine($"{count}. {item.Name}");
                    count++;
                }
          
            switch(Console.ReadLine())
            {
                case "UAH":
                    currency = "UAH";
                    break;
                case "USD":
                    currency = "USD";
                    break;
                case "EUR":
                    currency = "EUR";
                    break;
                case "PLN":
                    currency = "PLN";
                    break;
                case "RUB":
                    currency = "RUB";
                    break;
                case "exit":
                    
                    break;
                default:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong input!");
                    Console.ResetColor();
                    return "Wrong input";
                    
            }
            return currency;
        }

        public int AskSum()
        {
            int sum;
            do
            {
                Console.Write("Sum: ");
            } while (!int.TryParse(Console.ReadLine(), out sum) 
            || sum < 1 );
            return sum;
        }
        public void ShowResult(double res, string currencyToConvert, string currencyToConvertIn, int sumToConvert)
        {
            Console.WriteLine(sumToConvert +" "+ currencyToConvert + " = " + Math.Round(res, 2) +" "+ currencyToConvertIn);
        }
    }
}
