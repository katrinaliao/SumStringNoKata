using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SumStringNoKata
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(3, SumSringAsNumber.StringToInt('2','1'));
        }
    }

    public class SumSringAsNumber
    {
        public static int StringToInt(char str, char str2)
        {
           return Int32.Parse(str.ToString()) + Int32.Parse(str2.ToString());
        }
    }
}
