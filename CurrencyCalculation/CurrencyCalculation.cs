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

            //CalculateDenominations
            currencyCounter = CalculateDenominations(euroCurrencies, currencyCounter, amount);
           
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
     
        /// <summary>
        /// Calculate Denominations
        /// </summary>
        /// <param name="euroCurrencies"></param>
        /// <param name="currencyCounter"></param>
        /// <param name="amount"></param>
        public static decimal[] CalculateDenominations(decimal[] euroCurrencies, decimal[] currencyCounter, decimal amount)
        {
            // to calculate the count against each denominations from the balance amount 
            for (int i = 0; i < euroCurrencies.Length; i++)
            {
                if (amount >= euroCurrencies[i])
                {
                    currencyCounter[i] = Math.Floor(Math.Round(amount / euroCurrencies[i], 2));
                    amount = amount - currencyCounter[i] * euroCurrencies[i];
                }
            }
            return currencyCounter;
        }

        /// <summary>
        /// Fetch pound currencies from file
        /// </summary>
        /// <returns></returns>
        public static decimal[] FetchCurrencies()
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
        /// <summary>
        /// method to calculateBalance amount
        /// </summary>
        /// <param name="amountProduct"></param>
        /// <param name="amountReceived"></param>
        /// <returns></returns>
        public static decimal CalculateBalance(decimal amountProduct = 0, decimal amountReceived = 0)
        {
            decimal amountBalance = 0;
            amountBalance = amountReceived - amountProduct;
            return amountBalance;

        }
        /// <summary>
        /// method to Validate Inputs
        /// </summary>
        /// <param name="amountproduct"></param>
        /// <param name="amountreceived"></param>
        /// <returns></returns>
        public static int ValidateInputs(string amountproduct, string amountreceived)
        {
            decimal result;
            if (amountproduct == string.Empty || amountreceived == string.Empty)
            {
                return 1;
            }
            else if (!Decimal.TryParse(amountproduct, out result) || !Decimal.TryParse(amountreceived, out result))
            {
                return 2;
            }
            return 0;
        }

    }
}

