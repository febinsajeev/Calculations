using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations
{
   public static class CurrencyCalculation
    {
        public static void countCurrency(decimal amount)
        {
            
            decimal[] euroCurrencies = new decimal[] { 100, 50, 20, 10, 20, 5, 2, 1, 0.5m, 0.25m, 0.2m, 0.1m, 0.06m,0.05m,0.02m,0.01m,0.005m };
            decimal[] currencyCounter = new decimal[euroCurrencies.Length];

            // count notes using Gre5edy approach
            for (int i = 0; i < euroCurrencies.Length; i++)
            {
                if (amount >= euroCurrencies[i])
                {
                    currencyCounter[i] = Math.Floor(Math.Round(amount / euroCurrencies[i],2));
                    amount = amount - currencyCounter[i] * euroCurrencies[i];
                }
            }

            // Print notes
            Console.WriteLine("Denominations");
            Console.WriteLine("****************");
            for (int i = 0; i < euroCurrencies.Length; i++)
            {
                if (currencyCounter[i] != 0 )
                {
                    if (euroCurrencies[i] > 1)
                    {
                        Console.WriteLine(currencyCounter[i] + " X  \u00A3"
                            + euroCurrencies[i]);
                    }
                    if (euroCurrencies[i] < 1)
                    {
                        Console.WriteLine(currencyCounter[i] + " X  "
                            + Math.Round(euroCurrencies[i] * 100 ,0)+ "p");
                    }

                }

            }

            Console.ReadLine();
        
        }
    }
}
