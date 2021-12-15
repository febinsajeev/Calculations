using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations
{
    public static class CurrencyCalculation
    {   /// <summary>
        /// this class is for calculating the Currency denominations
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="currencyCounter"></param>
        /// <returns></returns>
        public static ArrayList countCurrency(decimal amount, out decimal[] currencyCounter)
        {
            //Denominations of eurocurrencies
            decimal[] euroCurrencies = new decimal[] { 100, 50, 20, 10, 20, 5, 2, 1, 0.5m, 0.25m, 0.2m, 0.1m, 0.06m, 0.05m, 0.02m, 0.01m, 0.005m };
            ArrayList tempCurrencies = new ArrayList();
            currencyCounter = new decimal[euroCurrencies.Length];

            // to calculate the count against each denominations from the balance amount 
            for (int i = 0; i < euroCurrencies.Length; i++)
            {
                if (amount >= euroCurrencies[i])
                {
                    currencyCounter[i] = Math.Floor(Math.Round(amount / euroCurrencies[i], 2));
                    amount = amount - currencyCounter[i] * euroCurrencies[i];
                }
            }


            // constructing the output
            for (int i = 0; i < euroCurrencies.Length; i++)
            {
                if (currencyCounter[i] != 0)
                {
                    if (euroCurrencies[i] > 1)
                    {
                        tempCurrencies.Add(currencyCounter[i] + " x \u00A3"
                            + euroCurrencies[i]);
                    }
                    if (euroCurrencies[i] < 1)
                    {
                        tempCurrencies.Add(currencyCounter[i] + " x "
                            + Math.Round(euroCurrencies[i] * 100, 0) + "p");
                    }

                }

            }
            return tempCurrencies;

        }
    }
}

