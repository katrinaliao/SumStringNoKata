using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SumStringNoKata
{
    [TestClass]
    public class TestCase
    {
        [TestMethod]
        public void Success()
        {
            Assert.AreEqual("3", SumSringAsNumber.StringToInt("2", "1"));
        }

        [TestMethod]
        public void Success_7and8()
        {
            Assert.AreEqual("15", SumSringAsNumber.StringToInt("7", "8"));
        }

        [TestMethod]
        public void Success_9and9()
        {
            Assert.AreEqual("18", SumSringAsNumber.StringToInt("9", "9"));
        }

        [TestMethod]
        public void Success_9999()
        {
            Assert.AreEqual("20", SumSringAsNumber.StringToInt("10", "10"));
        }

        [TestMethod]
        public void NegativeShouldSuccess()
        {
            Assert.AreEqual("-5", SumSringAsNumber.StringToInt("-6", "1"));
        }

        [TestMethod]
        public void BothZeroShouldReturnZero()
        {
            Assert.AreEqual("0", SumSringAsNumber.StringToInt("0", "0"));
        }

        [TestMethod]
        public void BothNullShouldReturnZero()
        {
            Assert.AreEqual("0", SumSringAsNumber.StringToInt("", ""));
        }

        [TestMethod]
        public void OneNullShouldReturnAnother()
        {
            Assert.AreEqual("5", SumSringAsNumber.StringToInt("", "5"));
        }
    }

    public class SumSringAsNumber
    {
        public static string StringToInt(string str, string str2)
        {
            if (String.IsNullOrEmpty(str) && String.IsNullOrEmpty(str2))
            {
                return "0";
            }
            if (String.IsNullOrEmpty(str))
            {
                return $"{Int32.Parse(str2)}";
            }
            if (String.IsNullOrEmpty(str2))
            {
                return $"{Int32.Parse(str)}";
            }

            return $"{Int32.Parse(str) + Int32.Parse(str2)}";
        }
    }
}
