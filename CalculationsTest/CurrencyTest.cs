using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculations;
using System.Collections;

namespace CalculationsTest
{
    [TestClass]
    public class CurrencyTest
    {
        [TestMethod]
        public void countCurrencyTest()
        {
            decimal[] currencyCounter;
            ArrayList expectedResult = new ArrayList { "1 x £10", "2 x £2", "1 x 50p"};
            ArrayList actualResult = CurrencyCalculation.countCurrency(14.5m,out currencyCounter);
            CollectionAssert.AreEqual(actualResult, expectedResult);
        }
    }
}
