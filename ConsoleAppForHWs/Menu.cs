using System;
using System.Collections.Generic;
using System.Text;

namespace Exchanger
{
    class Menu
    {
        public bool Game()
        {
            bool answer = false;
            string input = "";
            Console.WriteLine("\nWould you like to convert one more time?");
            Console.WriteLine("\nPress '1' if yes, any other button to exit.");
            input = Console.ReadLine();
            if (input == "1")
            {
                answer = true;
            }
            return answer;
        }

        public string AskCurrency(List<Currency> currencies, string act)
        {
            int input, count = 1;
            string currency = "";           
            do
            {
                Console.WriteLine($"Convert {act}");
                foreach (var item in currencies)
                {
                    Console.WriteLine($"{count}. {item.Name}");
                    count++;
                }
            } while (!int.TryParse(Console.ReadLine(), out input)
            || input < 1
            || input > 5);
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
                default:
                    Console.WriteLine("Wrong input");
                    break;
            }
            return currency;
        }

        public int AskSum()
        {
            int sum = 0;
            do
            {
                Console.WriteLine("Please, write how much you would like to convert:");
            } while (!int.TryParse(Console.ReadLine(), out sum) 
            || sum < 1 );
            return sum;
        }

        public void ShowResult(double res)
        {
            Console.WriteLine("The result is: " + Math.Round(res, 2));
        }
    }
}
