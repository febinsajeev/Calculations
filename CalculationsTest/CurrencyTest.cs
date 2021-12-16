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
        public void CountCurrencyTest()
        {
            ArrayList expectedResult = new ArrayList { "1 x £10", "2 x £2", "1 x 50p"};
            ArrayList actualResult = CurrencyCalculation.CountCurrency(14.5m);
            CollectionAssert.AreEqual(actualResult, expectedResult);         
        }

        [TestMethod]
        public void CurrencyCounterTest()
        {
            decimal[] expectedCounter = {0,0,0,1,0,0,2,0,1,0,0,0,0,0,0,0,0};
            decimal[] actualResult = CurrencyCalculation.PassCurrencyCounter(expectedCounter);
            CollectionAssert.AreEqual(actualResult, expectedCounter);
        }
    }
}
