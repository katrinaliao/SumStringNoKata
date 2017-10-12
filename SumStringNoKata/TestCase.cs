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
            Assert.AreEqual(3, SumSringAsNumber.StringToInt("2","1"));
        }

        [TestMethod]
        public void NegativeShouldSuccess()
        {
            Assert.AreEqual(-5, SumSringAsNumber.StringToInt("-6", "1"));
        }

        [TestMethod]
        public void BothNullShouldReturnZero()
        {
            Assert.AreEqual(0, SumSringAsNumber.StringToInt("", ""));
        }
    }

    public class SumSringAsNumber
    {
        public static int StringToInt(string str, string str2)
        {
            if (String.IsNullOrEmpty(str) && String.IsNullOrEmpty(str2))
            {
                return 0;
            }
            return Int32.Parse(str) + Int32.Parse(str2);
        }
    }
}
