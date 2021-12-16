using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations
{
    public static class CurrencyCalculation
    {   /// <summary>
        /// This class is for calculating the Currency denominations
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="currencyCounter"></param>
        /// <returns></returns>       
        public static ArrayList CountCurrency(decimal amount)
        {
            //Denominations of eurocurrencies            
            decimal[] euroCurrencies = FetchCurrencies();
            ArrayList tempCurrencies = new ArrayList();
            decimal[] currencyCounter = new decimal[euroCurrencies.Length];

            // to calculate the count against each denominations from the balance amount 
            for (int i = 0; i < euroCurrencies.Length; i++)
            {
                if (amount >= euroCurrencies[i])
                {
                    currencyCounter[i] = Math.Floor(Math.Round(amount / euroCurrencies[i], 2));
                    amount = amount - currencyCounter[i] * euroCurrencies[i];
                }
            }

            PassCurrencyCounter(currencyCounter);
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
        public static decimal[] PassCurrencyCounter(decimal[] currencyCounter)
        {
            return currencyCounter;
        }

        /// <summary>
        /// Fetch pound currencies from file
        /// </summary>
        /// <returns></returns>
        private static decimal[] FetchCurrencies()
        {
            string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string sFile = System.IO.Path.Combine(sCurrentDirectory, @"..\..\..\Currencies.txt");
            string sFilePath = Path.GetFullPath(sFile);
            var list = new List<decimal>();
            var fileStream = new FileStream(sFilePath, FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    list.Add(Convert.ToDecimal(line));
                }
            }
            return list.ToArray();
        }
    }
}

