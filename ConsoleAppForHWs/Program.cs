using Exchanger;
using System;
using System.Collections.Generic;

namespace Exchanger
{
    class Program
    {
        static void Main(string[] args)
        {
            
            do
            {
                Console.Clear();
                Console.WriteLine("WELCOME! Console currency converter V2.0");
                Menu menu = new Menu();
                Converter converter = new Converter();               
                Currency usd = new Currency("USD", 1);
                Currency euro = new Currency("EUR", 1.18);
                Currency uah = new Currency("UAH", 0.036);
                Currency pln = new Currency("PLN", 0.27);
                Currency rub = new Currency("RUB", 0.013);
                List<Currency> currencies = new List<Currency>() {usd, euro, uah, pln, rub};

                string currencyToConvert = menu.AskCurrency(currencies, "From " );
                if(currencyToConvert == "Wrong input!")
                {
                    continue;
                }
                Console.WriteLine();
                string currencyToConvertIn = menu.AskCurrency(currencies, "To ");
                if (currencyToConvertIn == "Wrong input!")
                {
                    continue;
                }
                Console.WriteLine();
                int sumToConvert = menu.AskSum();
                double rateIn = 0, rateOut = 0;
                foreach (Currency currency in currencies)
                {
                    if (currency.Name == currencyToConvert)
                    {
                        rateIn = currency.ToDollarRate;
                    }
                    if (currency.Name == currencyToConvertIn)
                    {
                        rateOut = currency.ToDollarRate;
                    }
                }
                double temp = converter.ConvertionToDollar(sumToConvert, rateIn);
                double result = converter.DollarConvertion(temp, rateOut);
                menu.ShowResult(result, currencyToConvert, currencyToConvertIn, sumToConvert);
                Console.WriteLine();
                Console.WriteLine("ENTER to continue");
            } while (Console.ReadKey().Key == ConsoleKey.Enter);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("BYE!!!");
            Console.ResetColor();
        }
    }
}
