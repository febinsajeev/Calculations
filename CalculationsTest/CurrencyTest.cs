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
        public void CalculateBalanceTest()
        {
            decimal expectedBalance = 14.5m;
            decimal actualBalance = CurrencyCalculation.CalculateBalance(5.5m,20);
            Assert.AreEqual(actualBalance, expectedBalance);
        }

        [TestMethod]
        public void ValidateEmptyInputsTest()
        {
            int expectedValue = 1;
            int actualValue = CurrencyCalculation.ValidateInputs("", "");
            Assert.AreEqual(actualValue, expectedValue);
        }

        [TestMethod]
        public void ValidateStringInputsTest()
        {
            int expectedValue = 2;
            int actualValue = CurrencyCalculation.ValidateInputs("ss", "ss");
            Assert.AreEqual(actualValue, expectedValue);
        }

        [TestMethod]
        public void ValidateCorrectInputsTest()
        {
            int expectedValue = 0;
            int actualValue = CurrencyCalculation.ValidateInputs("5.5", "20");
            Assert.AreEqual(actualValue, expectedValue);
        }

        [TestMethod]
        public void CalculateDenominationsTest()
        {
            decimal[] expectedCounter = { 0, 0, 0, 1, 0, 0, 2, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0 };
            decimal[] euroCurrencies = CurrencyCalculation.FetchCurrencies();
            decimal[] currencyCounter = new decimal[euroCurrencies.Length];
            decimal[] actualCounter = CurrencyCalculation.CalculateDenominations(euroCurrencies, currencyCounter, 14.5m);
            CollectionAssert.AreEqual(actualCounter, expectedCounter);
        }


    }
}
